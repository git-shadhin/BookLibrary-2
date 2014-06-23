using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlServerCe;
using System.Data.SqlClient;
using COUCHEBO;
using COUCHEERROR;
using Bibliotheque.Proxies;

namespace BibliothequeSolution
{
    public partial class FrmLogin : Form
    {

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                ClsBOExemp objExemp = new ClsBOExemp();

                using (ClsIFACLecteurClient prox = new ClsIFACLecteurClient())
                {
                    ClsBOLecteur objLecteur = prox.Login(txtUsername.Text, txtPassword.Text);
                    
                    if (objLecteur != null)
                    {
                        if (cmbBiblio.SelectedItem != null)
                        {
                            if (objLecteur.ISADMIN == true)
                            {
                                Bibliotheque biblio = new Bibliotheque(objLecteur.LECTEUR_ID, objLecteur.ISADMIN, Convert.ToInt32(cmbBiblio.SelectedValue), objLecteur.USERNAME);
                                biblio.Text = "Administateur : " + objLecteur.USERNAME + " - " + "Bibliothèque : " + cmbBiblio.SelectedValue;
                                biblio.Show();
                            }
                            else
                            {
                                Bibliotheque biblio = new Bibliotheque(objLecteur.LECTEUR_ID, objLecteur.ISADMIN, Convert.ToInt32(cmbBiblio.SelectedValue), objLecteur.USERNAME);
                                biblio.Text = "Utilisateur : " + objLecteur.USERNAME + " - " + " Bibliothèque : " + cmbBiblio.SelectedValue;
                                biblio.Show();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Aucune bibliothèque sélectionnée, veuillez en choisir une !");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Aucun utilisateur trouvé avec cet Username : " + txtUsername.Text + " et ce Password : " + txtPassword.Text + " !");
                    }
                }
            }
            catch (CustomException ce)
            {
                MessageBox.Show(ce.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cmbBiblio_DropDown(object sender, EventArgs e)
        {
            try
            {
                using (ClsIFACBiblioClient prox = new ClsIFACBiblioClient())
                {
                    cmbBiblio.DataSource = prox.SelectAllBiblio().ToList();
                    cmbBiblio.DisplayMember = "Libelle";
                    cmbBiblio.ValueMember = "Bibliotheque_ID";
                }
            }
            catch (CustomException ce)
            {
                MessageBox.Show(ce.Message);
            }
        }
    }
}