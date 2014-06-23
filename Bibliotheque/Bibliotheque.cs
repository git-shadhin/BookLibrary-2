using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Configuration;
using COUCHEBO;
using COUCHEERROR;
using Bibliotheque.Proxies;
using BibliothequeSolution.ServiceAmazon;
using System.Net;

namespace BibliothequeSolution
{
    public partial class Bibliotheque : Form
    {
        public Bibliotheque(Int32 Lecteur_ID, Boolean isAdmin, Int32 Biblio_ID, String Username)
        {
            InitializeComponent();
            _IsAdmin = isAdmin;
            _BiblioID = Biblio_ID;
            _Lecteur_ID = Lecteur_ID;
            _Username = Username;
        }

        private Int32 _Lecteur_ID;
        private Int32 _BiblioID;
        private Boolean _IsAdmin;
        private String _Username;

        private Byte[] _cover;

        private void Bibliotheque_Load(object sender, EventArgs e)
        {
            try
            {
                using (ClsIFACGestion_BibliothequeClient proxGestBiblio = new ClsIFACGestion_BibliothequeClient())
                {
                    ClsBOGestion_Bibliotheque objGestionBiblio = proxGestBiblio.SelectWhereIsAdmin(_Lecteur_ID, _BiblioID);

                    using (ClsIFACReservationClient proxReserv = new ClsIFACReservationClient())
                    {
                        using (ClsIFACEmpruntClient prox = new ClsIFACEmpruntClient())
                        {
                            ClsBOEmprunt objEmprunt = prox.SelectPrixByLecteur(_Lecteur_ID);
                            if (_IsAdmin != true)
                            {
                                #region Controls Hide si juste lecteur
                                tabControl1.Controls.Remove(tabStats);
                                tabControl2.Controls.Remove(tabAuteurs);
                                tabControl2.Controls.Remove(tabGenres);
                                tabControl2.Controls.Remove(tabExemplaires);
                                groupBox1.Hide();
                                groupBox2.Hide();
                                groupBox3.Hide();
                                #endregion
                                dgvEmpruntsEnCours.DataSource = prox.SelectEmpruntEnCoursByUtilisateur(_Lecteur_ID);
                                dgvHistEmp.DataSource = prox.SelectEmpruntHistoriqueByUtilisateur(_Lecteur_ID);
                                lblPrixHistEmp.Text = objEmprunt.Prix.ToString();

                                dgvReservEnCours.DataSource = proxReserv.SelectReservEnCoursByUtilisateur(_Lecteur_ID);
                                dgvHistReserv.DataSource = proxReserv.SelectReservHistoriqueByUtilisateur(_Lecteur_ID);

                            }
                            else
                            {
                                dgvEmpruntsEnCours.DataSource = prox.SelectAllEmpruntEnCours().ToList();
                                dgvHistEmp.DataSource = prox.SelectEmpruntHistoriqueByUtilisateur(_Lecteur_ID);
                                lblPrixHistEmp.Text = objEmprunt.Prix.ToString();

                                dgvReservEnCours.DataSource = proxReserv.SelectReservEnCoursByUtilisateur(_Lecteur_ID);
                                dgvHistReserv.DataSource = proxReserv.SelectReservHistoriqueByUtilisateur(_Lecteur_ID);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        #region Amazon
        private void btnLivreAmazonRecherche_Click(object sender, EventArgs e)
        {
            ItemLookupResponse response;
            AWSECommerceServicePortTypeClient client = new AWSECommerceServicePortTypeClient("AWSECommerceServicePort");

            client.ChannelFactory.Endpoint.EndpointBehaviors.Add(
                new AmazonSigningEndpointBehavior(ConfigurationManager.AppSettings.Get("accessKeyId"),
                                                  ConfigurationManager.AppSettings.Get("secretKey")));

            ItemLookupRequest recherche_ISBN = new ItemLookupRequest();
            recherche_ISBN.SearchIndex = "Books";
            recherche_ISBN.ItemId = new string[] { txtISBN.Text };
            recherche_ISBN.IdType = ItemLookupRequestIdType.ISBN;
            recherche_ISBN.IdTypeSpecified = true;
            recherche_ISBN.ResponseGroup = new string[] { "Images", "Small" };

            ItemLookup itemlookup = new ItemLookup();
            itemlookup.Request = new ItemLookupRequest[] { recherche_ISBN };
            itemlookup.AWSAccessKeyId = ConfigurationManager.AppSettings.Get("accessKeyId");
            itemlookup.AssociateTag = ConfigurationManager.AppSettings.Get("associateTag");

            try
            {
                response = client.ItemLookup(itemlookup);

                foreach (var item in response.Items[0].Item)
                {
                    txtTitre.Text = item.ItemAttributes.Title;
                    txtAuteur.Text = item.ItemAttributes.Author[0];

                    // Create a web request to the URL for the picture
                    WebRequest webRequest = HttpWebRequest.Create(item.MediumImage.URL);

                    // Execute the request synchronuously
                    HttpWebResponse webResponse = (HttpWebResponse)webRequest.GetResponse();

                    // Create an image from the stream returned by the web request
                    pictureBoxLivre.Image = new System.Drawing.Bitmap(webResponse.GetResponseStream());

                    WebClient clientWeb = new WebClient();
                    _cover = clientWeb.DownloadData(item.MediumImage.URL);

                    // Finally, close the request
                    webResponse.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion


        #region Recherche

        #region Livres
        private void btnLivreRechercheDB_Click(object sender, EventArgs e)
        {
            try
            {
                using (ClsIFACLivreClient prox = new ClsIFACLivreClient())
                {
                    if (txtLivresDB.Text == "" && txtISBNDB.Text == "")
                    {
                        List<ClsBOLivre> _ListLivre;
                        _ListLivre = prox.SelectAllLivre().ToList();
                        dgvLivresDB.DataSource = DisplayLivreAll(_ListLivre);
                    }
                    else if (txtLivresDB.Text != "" && txtISBNDB.Text == "")
                    {
                        List<ClsBOLivre> _ListLivre;
                        _ListLivre = prox.SelectLivreByTitre(txtLivresDB.Text);
                        dgvLivresDB.DataSource = DisplayLivreAll(_ListLivre);
                    }
                    else
                    {
                        List<ClsBOLivre> _ListLivre;
                        _ListLivre = prox.SelectLivreByISBN(txtISBNDB.Text);
                        dgvLivresDB.DataSource = DisplayLivreAll(_ListLivre);
                    }
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Ce livre n'éxiste pas !", "Erreur");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLivresAjout_Click(object sender, EventArgs e)
        {
            try
            {
                using (ClsIFACLivreClient proxLivres = new ClsIFACLivreClient())
                {
                    List<ClsBOLivre> objLivres = proxLivres.SelectLivreByISBN(txtISBN.Text);

                    if (objLivres.Count == 0)
                    {
                        using (ClsIFACLivreClient prox = new ClsIFACLivreClient())
                        {
                            dgvLivresDB.DataSource = prox.AddLivre(txtISBN.Text, txtTitre.Text, Convert.ToInt32(cmbGenre.SelectedValue.ToString()), _cover, _BiblioID, Convert.ToInt32(cmbAuteur.SelectedValue.ToString()));
                            dgvLivresDB.DataSource = null;
                            dgvLivresDB.DataSource = prox.SelectAllLivre().ToList();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ce livre existe déjà");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private DataTable DisplayLivreAll(List<ClsBOLivre> _ListLivre)
        {
            ClsIFACGenreClient _ClsIFACGenreClient = new ClsIFACGenreClient();

            DataTable _DataTable = new DataTable();
            _DataTable.Columns.Add("ISBN", typeof(String));
            _DataTable.Columns.Add("Titre", typeof(String));
            _DataTable.Columns.Add("Genre", typeof(String));
            _DataTable.Columns.Add("Cover", typeof(Byte[]));

            foreach (ClsBOLivre _Livre in _ListLivre)
            {
                ClsBOGenre _Genre = _ClsIFACGenreClient.SelectAllGenre().Find(x => x.Genre_ID == _Livre.Genre_ID) as ClsBOGenre;

                DataRow _DataRow = _DataTable.NewRow();
                _DataRow["ISBN"] = _Livre.ISBN;
                _DataRow["Titre"] = _Livre.Titre;
                _DataRow["Genre"] = _Genre.Libelle;
                _DataRow["Cover"] = _Livre.Cover;

                _DataTable.Rows.Add(_DataRow);
            }
            return _DataTable;
        }
        #endregion

        #region Auteurs
        private void btnAuteurRecherche_Click(object sender, EventArgs e)
        {
            try
            {
                using (ClsIFACAuteurClient prox = new ClsIFACAuteurClient())
                {
                    dgvAuteur.DataSource = prox.SelectAllAuteur().ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAuteursAjout_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtAuteurNom.Text == "" && txtAuteurPrenom.Text == "")
                {
                    MessageBox.Show("Vous devez insérer un nom et un prenom !");
                }
                else
                {
                    using (ClsIFACAuteurClient prox = new ClsIFACAuteurClient())
                    {
                        dgvAuteur.DataSource = prox.AddAuteur(txtAuteurNom.Text, txtAuteurPrenom.Text);
                        dgvAuteur.DataSource = prox.SelectAllAuteur().ToList();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbAuteur_DropDown(object sender, EventArgs e)
        {
            try
            {
                using (ClsIFACAuteurClient prox = new ClsIFACAuteurClient())
                {
                    cmbAuteur.DataSource = prox.SelectAllAuteur().ToList();
                    cmbAuteur.DisplayMember = "NomPrenom";
                    cmbAuteur.ValueMember = "Auteur_ID";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Genres
        private void btnGenreAjout_Click(object sender, EventArgs e)
        {
            try
            {
                using (ClsIFACGenreClient prox = new ClsIFACGenreClient())
                {
                    dgvGenre.DataSource = prox.SelectAllGenre().ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGenreRecherche_Click(object sender, EventArgs e)
        {
            try
            {
                using (ClsIFACGenreClient prox = new ClsIFACGenreClient())
                {
                    dgvGenre.DataSource = prox.SelectAllGenre().ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbGenre_DropDown(object sender, EventArgs e)
        {
            try
            {
                using (ClsIFACGenreClient prox = new ClsIFACGenreClient())
                {
                    cmbGenre.DataSource = prox.SelectAllGenre().ToList();
                    cmbGenre.DisplayMember = "Libelle";
                    cmbGenre.ValueMember = "Genre_ID";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Exemplaires
        private void btnExempRecherche_Click(object sender, EventArgs e)
        {
            try
            {
                using (ClsIFACExempClient prox = new ClsIFACExempClient())
                {
                    if (!checkBoxISBNBilbio.Checked && cmbExempEtat.SelectedIndex < 0 && cmbExempISBN.SelectedIndex < 0 && cmbExempBiblio.SelectedIndex < 0)
                    {
                        List<ClsBOExemp> _ListExemp;
                        _ListExemp = prox.SelectAllExemp().ToList();
                        dgvExemp.DataSource = DisplayExempAll(_ListExemp);
                        //dgvExemp.DataSource = prox.SelectAllExemp();
                    }

                    if (checkBoxISBNBilbio.Checked && cmbExempEtat.SelectedIndex < 0 && cmbExempISBN.SelectedIndex > -1 && cmbExempBiblio.SelectedIndex > -1)
                    {
                        List<ClsBOExemp> _ListExemp;
                        _ListExemp = prox.SelectExempByISBNAndBiblioID(cmbExempISBN.SelectedValue.ToString(), Convert.ToInt32(cmbExempBiblio.SelectedValue));
                        dgvExemp.DataSource = DisplayExempAll(_ListExemp);
                        //dgvExemp.DataSource = prox.SelectExempByISBNAndBiblioID(cmbExempISBN.SelectedValue.ToString(), Convert.ToInt32(cmbExempBiblio.SelectedValue));
                    }

                    if (!checkBoxISBNBilbio.Checked && cmbExempEtat.SelectedIndex < 0 && cmbExempISBN.SelectedIndex > -1 && cmbExempBiblio.SelectedIndex < 0)
                    {
                        List<ClsBOExemp> _ListExemp;
                        _ListExemp = prox.SelectExempByISBN(cmbExempISBN.SelectedValue.ToString());
                        dgvExemp.DataSource = DisplayExempAll(_ListExemp);
                        //dgvExemp.DataSource = prox.SelectExempByISBN(cmbExempISBN.SelectedValue.ToString());
                    }

                    if (!checkBoxISBNBilbio.Checked && cmbExempEtat.SelectedIndex < 0 && cmbExempISBN.SelectedIndex < 0 && cmbExempBiblio.SelectedIndex > -1)
                    {
                        List<ClsBOExemp> _ListExemp;
                        _ListExemp = prox.SelectExempByBiblioID(Convert.ToInt32(cmbExempBiblio.SelectedValue));
                        dgvExemp.DataSource = DisplayExempAll(_ListExemp);
                        //dgvExemp.DataSource = prox.SelectExempByBiblioID(Convert.ToInt32(cmbExempBiblio.SelectedValue));
                    }

                    else if (!checkBoxISBNBilbio.Checked && cmbExempEtat.SelectedIndex > -1 && cmbExempISBN.SelectedIndex < 0 && cmbExempBiblio.SelectedIndex < 0)
                    {
                        List<ClsBOExemp> _ListExemp;
                        _ListExemp = prox.SelectExempByEtat(Convert.ToInt32(cmbExempEtat.SelectedValue));
                        dgvExemp.DataSource = DisplayExempAll(_ListExemp);
                        //dgvExemp.DataSource = prox.SelectExempByEtat(Convert.ToInt32(cmbExempEtat.SelectedValue));
                    }

                    else
                    { }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExempAjout_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbExempISBN.SelectedIndex > -1 && cmbExempBiblio.SelectedIndex > -1)
                {
                    using (ClsIFACExempClient prox = new ClsIFACExempClient())
                    {
                        dgvExemp.DataSource = prox.AddExemplaire(cmbExempISBN.SelectedValue.ToString(), Convert.ToInt32(cmbExempBiblio.SelectedValue));
                        dgvExemp.DataSource = null;
                        dgvExemp.DataSource = prox.SelectAllExemp().ToList();
                    }
                }
                else
                {
                    MessageBox.Show("Veuillez sélectionner un livre et une bibliothèque pour ajouter un exemplaire");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbExempISBN_DropDown(object sender, EventArgs e)
        {
            try
            {
                using (ClsIFACLivreClient prox = new ClsIFACLivreClient())
                {
                    cmbExempISBN.DataSource = prox.SelectAllLivre().ToList();
                    cmbExempISBN.DisplayMember = "ISBN";
                    cmbExempISBN.ValueMember = "ISBN";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbExempBiblio_DropDown(object sender, EventArgs e)
        {
            try
            {
                using (ClsIFACBiblioClient prox = new ClsIFACBiblioClient())
                {
                    cmbExempBiblio.DataSource = prox.SelectAllBiblio().ToList();
                    cmbExempBiblio.DisplayMember = "Libelle";
                    cmbExempBiblio.ValueMember = "Bibliotheque_ID";
                }
            }
            catch (CustomException ce)
            {
                MessageBox.Show(ce.Message);
            }
        }

        private void cmbExempEtat_DropDown(object sender, EventArgs e)
        {
            try
            {
                using (ClsIFACEtatClient prox = new ClsIFACEtatClient())
                {
                    cmbExempEtat.DataSource = prox.SelectAllEtat().ToList();
                    cmbExempEtat.DisplayMember = "Libelle";
                    cmbExempEtat.ValueMember = "Etat_ID";
                }
            }
            catch (CustomException ce)
            {
                MessageBox.Show(ce.Message);
            }
        }

        private DataTable DisplayExempAll(List<ClsBOExemp> _ListExemp)
        {
            ClsIFACBiblioClient _ClsIFACBiblioClient = new ClsIFACBiblioClient();
            ClsIFACEtatClient _ClsIFACEtatClient = new ClsIFACEtatClient();

            DataTable _DataTable = new DataTable();
            _DataTable.Columns.Add("Exemplaire_ID", typeof(Int32));
            _DataTable.Columns.Add("ISBN", typeof(String));
            _DataTable.Columns.Add("Bibliotheque_ID", typeof(String));
            _DataTable.Columns.Add("Etat_ID", typeof(String));
            _DataTable.Columns.Add("Date_Creation", typeof(DateTime));

            foreach (ClsBOExemp _Exemp in _ListExemp)
            {
                ClsBOBiblio _Biblio = _ClsIFACBiblioClient.SelectAllBiblio().Find(x => x.Bibliotheque_ID == _Exemp.Bibliotheque_ID) as ClsBOBiblio;
                ClsBOEtat _Etat = _ClsIFACEtatClient.SelectAllEtat().Find(x => x.Etat_ID == _Exemp.Etat_ID) as ClsBOEtat;

                DataRow _DataRow = _DataTable.NewRow();
                _DataRow["Exemplaire_ID"] = _Exemp.Exemplaire_ID;
                _DataRow["ISBN"] = _Exemp.ISBN;
                _DataRow["Bibliotheque_ID"] = _Biblio.Libelle;
                _DataRow["Etat_ID"] = _Etat.Libelle;
                _DataRow["Date_Creation"] = _Exemp.Date_Creation;

                _DataTable.Rows.Add(_DataRow);
            }
            return _DataTable;
        }
        #endregion

        #endregion

        #region Emprunts
        private void btnEmprunter_Click(object sender, EventArgs e)
        {
            try
            {
                using (ClsIFACLecteurClient proxLect = new ClsIFACLecteurClient())
                {
                    ClsBOLecteur objLecteur = proxLect.SelectNb_EmpruntByLecteurID(_Lecteur_ID);

                    using (ClsIFACLecteur_BibliothequeClient proxLectBiblio = new ClsIFACLecteur_BibliothequeClient())
                    {
                        ClsBOLecteur_Bibliotheque objLecteurBiblio = proxLectBiblio.SelectLecteurBiblioByLecteurID(_Lecteur_ID);

                        if (objLecteurBiblio.Bibliotheque_ID == _BiblioID && objLecteur.NB_EMPRUNT >= 3)
                        {
                            MessageBox.Show("Vous ne pouvez faire plus de trois emprunts dans toutes les bibliothèques !");
                        }

                        if (objLecteurBiblio.Bibliotheque_ID != _BiblioID && objLecteur.NB_EMPRUNT >= 1)
                        {
                            MessageBox.Show("Vous ne pouvez faire plus de un emprunt dans une bibliothèque secondaire !");
                        }

                        if (objLecteurBiblio.Bibliotheque_ID == _BiblioID && objLecteur.NB_EMPRUNT <= 2)
                        {
                            using (ClsIFACEmpruntClient proxEmp = new ClsIFACEmpruntClient())
                            {
                                dgvEmprunter.DataSource = proxEmp.Emprunter(_Lecteur_ID, Convert.ToInt32(cmbEmpruntExemp.SelectedValue));
                                dgvEmprunter.DataSource = proxEmp.SelectAllEmprunt().ToList();
                                dgvEmpruntsEnCours.DataSource = proxEmp.SelectEmpruntEnCoursByUtilisateur(_Lecteur_ID);
                                MessageBox.Show("Votre emprunt a bien été enregistré !");
                            }
                        }
                        else if (objLecteurBiblio.Bibliotheque_ID != _BiblioID && objLecteur.NB_EMPRUNT < 1)
                        {
                            using (ClsIFACEmpruntClient proxEmp = new ClsIFACEmpruntClient())
                            {
                                dgvEmprunter.DataSource = proxEmp.Emprunter(_Lecteur_ID, Convert.ToInt32(cmbEmpruntExemp.SelectedValue));
                                dgvEmprunter.DataSource = proxEmp.SelectAllEmprunt().ToList();
                                dgvEmpruntsEnCours.DataSource = proxEmp.SelectEmpruntEnCoursByUtilisateur(_Lecteur_ID);
                                MessageBox.Show("Votre emprunt a bien été enregistré !");
                            }
                        }
                        else
                        {
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbExempEmprunt_DropDown(object sender, EventArgs e)
        {
            try
            {
                using (ClsIFACExempClient prox = new ClsIFACExempClient())
                {
                    cmbEmpruntExemp.DataSource = prox.SelectExempByEtat(3).ToList();
                    cmbEmpruntExemp.DisplayMember = "ISBN";
                    cmbEmpruntExemp.ValueMember = "Exemplaire_ID";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Emprunts en cours
        private Int32 SelectRowEmpruntID;
        private Int32 SelectRowExemplaireID;
        private Int32 SelectRowLecteurID;

        private void dgvEmpruntsEnCours_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectRowEmpruntID = (Int32)dgvEmpruntsEnCours.CurrentRow.Cells[0].Value;

            SelectRowLecteurID = (Int32)dgvEmpruntsEnCours.CurrentRow.Cells[1].Value;

            SelectRowExemplaireID = (Int32)dgvEmpruntsEnCours.CurrentRow.Cells[2].Value;
        }

        private void btnEmpruntRetour_Click(object sender, EventArgs e)
        {
            try
            {
                using (ClsIFACGestion_BibliothequeClient proxGestBiblio = new ClsIFACGestion_BibliothequeClient())
                {
                    ClsBOGestion_Bibliotheque objGestionBiblio = proxGestBiblio.SelectWhereIsAdmin(_Lecteur_ID, _BiblioID);

                    using (ClsIFACEmpruntClient prox = new ClsIFACEmpruntClient())
                    {
                        if (SelectRowLecteurID != _Lecteur_ID)
                        {
                            dgvEmpruntsEnCours.DataSource = prox.EmpruntRetour(SelectRowEmpruntID, SelectRowExemplaireID, SelectRowLecteurID);
                            dgvEmpruntsEnCours.DataSource = null;
                            dgvEmpruntsEnCours.DataSource = prox.SelectEmpruntEnCoursByUtilisateur(_Lecteur_ID);
                        }
                        if (objGestionBiblio == null && SelectRowLecteurID == _Lecteur_ID)
                        {
                            MessageBox.Show("Vous n'êtes pas Admin dans cette bibliothèque, vous payerez donc l'emprunt");
                            dgvEmpruntsEnCours.DataSource = prox.EmpruntRetour(SelectRowEmpruntID, SelectRowExemplaireID, SelectRowLecteurID);
                            dgvEmpruntsEnCours.DataSource = null;
                            dgvEmpruntsEnCours.DataSource = prox.SelectEmpruntEnCoursByUtilisateur(_Lecteur_ID);
                        }
                        if (objGestionBiblio != null && SelectRowLecteurID == _Lecteur_ID)
                        {
                            MessageBox.Show("Vous êtes Admin dans la bibliothèque " + objGestionBiblio.Bibliotheque_ID + ", vous ne payerez donc pas !");
                            dgvEmpruntsEnCours.DataSource = prox.EmpruntRetourAdmin(SelectRowEmpruntID, SelectRowExemplaireID, SelectRowLecteurID);
                            dgvEmpruntsEnCours.DataSource = null;
                            dgvEmpruntsEnCours.DataSource = prox.SelectEmpruntEnCoursByUtilisateur(_Lecteur_ID);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbEmpEnCoursByLecteur_DropDown(object sender, EventArgs e)
        {
            try
            {
                using (ClsIFACLecteurClient prox = new ClsIFACLecteurClient())
                {
                    cmbEmpEnCoursByLecteur.DataSource = prox.SelectAllLecteur().ToList();
                    cmbEmpEnCoursByLecteur.DisplayMember = "Username";
                    cmbEmpEnCoursByLecteur.ValueMember = "Lecteur_ID";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEmpEnCoursRech_Click(object sender, EventArgs e)
        {
            try
            {
                using (ClsIFACEmpruntClient prox = new ClsIFACEmpruntClient())
                {
                    if (cmbEmpEnCoursByLecteur.SelectedIndex < 0)
                    {
                        dgvEmpruntsEnCours.DataSource = prox.SelectAllEmpruntEnCours().ToList();
                    }
                    else
                    {
                        dgvEmpruntsEnCours.DataSource = prox.SelectEmpruntEnCoursByUtilisateur(Convert.ToInt32(cmbEmpEnCoursByLecteur.SelectedValue));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Statistiques
        private void cmbLecteursStats_DropDown(object sender, EventArgs e)
        {
            try
            {
                using (ClsIFACLecteurClient prox = new ClsIFACLecteurClient())
                {
                    cmbLecteursStats.DataSource = prox.SelectAllLecteur().ToList();
                    cmbLecteursStats.DisplayMember = "Username";
                    cmbLecteursStats.ValueMember = "Lecteur_ID";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLecteursStats_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbLecteursStats.SelectedIndex < 0)
                {
                    MessageBox.Show("Veuillez sélectionner un lecteur dans la liste");
                }
                else
                {
                    using (ClsIFACEmpruntClient prox = new ClsIFACEmpruntClient())
                    {
                        ClsBOEmprunt objEmprunt = prox.SelectPrixByLecteur(Convert.ToInt32(cmbLecteursStats.SelectedValue));
                        lblPrixParLecteur.Text = objEmprunt.Prix.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbBiblioStats_DropDown(object sender, EventArgs e)
        {
            try
            {
                using (ClsIFACBiblioClient prox = new ClsIFACBiblioClient())
                {
                    cmbBiblioStats.DataSource = prox.SelectAllBiblio().ToList();
                    cmbBiblioStats.DisplayMember = "Libelle";
                    cmbBiblioStats.ValueMember = "Bibliotheque_ID";
                }
            }
            catch (CustomException ce)
            {
                MessageBox.Show(ce.Message);
            }
        }

        private void btnBiblioStats_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbBiblioStats.SelectedIndex < 0)
                {
                    MessageBox.Show("Veuillez sélectionner une bibliothèque dans la liste");
                }
                else
                {
                    using (ClsIFACEmpruntClient prox = new ClsIFACEmpruntClient())
                    {
                        ClsBOEmprunt objEmprunt = prox.SelectPrixByBiblio(Convert.ToInt32(cmbBiblioStats.SelectedValue));
                        lblPrixParBiblio.Text = objEmprunt.Prix.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Réservations
        private void cmbReservLivres_DropDown(object sender, EventArgs e)
        {
            try
            {
                using (ClsIFACLivreClient prox = new ClsIFACLivreClient())
                {
                    cmbReservLivres.DataSource = prox.SelectAllLivre().ToList();
                    cmbReservLivres.DisplayMember = "ISBN";
                    cmbReservLivres.ValueMember = "ISBN";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnReserver_Click(object sender, EventArgs e)
        {
            try
            {
                using (ClsIFACEmpruntClient proxEmp = new ClsIFACEmpruntClient())
                {
                    List<ClsBOEmprunt> lstEmprunt = proxEmp.CountNbrExemplaireByISBN(cmbReservLivres.SelectedValue.ToString());

                    if (lstEmprunt.Count != 0)
                    {
                        MessageBox.Show("Il reste des exemplaires disponibles du livre choisi, dirigez vous vers l'onglet emprunts pour en emprunter un !");
                    }
                    else if (cmbReservLivres.SelectedIndex < 0)
                    {
                        MessageBox.Show("Veuillez sélectionner un livre à réserver !");
                    }
                    else if (cmbReservLivres.SelectedIndex > -1)
                    {
                        using (ClsIFACReservationClient prox = new ClsIFACReservationClient())
                        {
                            dgvReservation.DataSource = prox.Reserver(cmbReservLivres.SelectedValue.ToString(), _Lecteur_ID);
                            dgvReservEnCours.DataSource = prox.SelectReservEnCoursByUtilisateur(_Lecteur_ID);
                            MessageBox.Show("Votre réservation a bien été enregistrée !");
                        }
                    }
                    else
                    {
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Réservations en cours
        private void btnReservEnCoursRech_Click(object sender, EventArgs e)
        {
            try
            {
                using (ClsIFACReservationClient prox = new ClsIFACReservationClient())
                {
                    if (cmbReservEnCoursByLecteur.SelectedIndex < 0)
                    {
                        dgvReservEnCours.DataSource = prox.SelectAllReservation().ToList();
                    }
                    else
                    {
                        dgvReservEnCours.DataSource = prox.SelectReservEnCoursByUtilisateur(Convert.ToInt32(cmbReservEnCoursByLecteur.SelectedValue));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbReservEnCoursByLecteur_DropDown(object sender, EventArgs e)
        {
            try
            {
                using (ClsIFACLecteurClient prox = new ClsIFACLecteurClient())
                {
                    cmbReservEnCoursByLecteur.DataSource = prox.SelectAllLecteur().ToList();
                    cmbReservEnCoursByLecteur.DisplayMember = "Username";
                    cmbReservEnCoursByLecteur.ValueMember = "Lecteur_ID";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
    }
}