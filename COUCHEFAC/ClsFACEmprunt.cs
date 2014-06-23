using System;
using System.Collections.Generic;
using System.Linq;
using COUCHEIFAC;
using COUCHEBL;
using COUCHEBO;
using COUCHEERROR;

namespace COUCHEFAC
{
    public class ClsFACEmprunt : ClsIFACEmprunt
    {
        public List<ClsBOEmprunt> SelectAllEmprunt()
        {
            try
            {
                return ClsBLEmprunt.SelectAllEmprunt().ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<ClsBOEmprunt> SelectEmpruntEnCoursByUtilisateur(Int32 Lecteur_ID)
        {
            try
            {
                return ClsBLEmprunt.SelectEmpruntEnCoursByUtilisateur(Lecteur_ID).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<ClsBOEmprunt> SelectEmpruntHistoriqueByUtilisateur(Int32 Lecteur_ID)
        {
            try
            {
                return ClsBLEmprunt.SelectEmpruntHistoriqueByUtilisateur(Lecteur_ID).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<ClsBOEmprunt> SelectAllEmpruntEnCours()
        {
            try
            {
                return ClsBLEmprunt.SelectAllEmpruntEnCours().ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public ClsBOEmprunt Emprunter(Int32 Lecteur_ID, Int32 Exemplaire_ID)
        {
            try
            {
                return ClsBLEmprunt.Emprunter(Lecteur_ID, Exemplaire_ID);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public ClsBOEmprunt EmpruntRetour(Int32 Emprunt_ID, Int32 Exemplaire_ID, Int32 Lecteur_ID)
        {
            try
            {
                return ClsBLEmprunt.EmpruntRetour(Emprunt_ID, Exemplaire_ID, Lecteur_ID);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public ClsBOEmprunt EmpruntRetourAdmin(Int32 Emprunt_ID, Int32 Exemplaire_ID, Int32 Lecteur_ID)
        {
            try
            {
                return ClsBLEmprunt.EmpruntRetourAdmin(Emprunt_ID, Exemplaire_ID, Lecteur_ID);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public ClsBOEmprunt SelectPrixByLecteur(Int32 Lecteur_ID)
        {
            try
            {
                return ClsBLEmprunt.SelectPrixByLecteur(Lecteur_ID);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public ClsBOEmprunt SelectPrixByBiblio(Int32 Biblio_ID)
        {
            try
            {
                return ClsBLEmprunt.SelectPrixByBiblio(Biblio_ID);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<ClsBOEmprunt> CountNbrExemplaireByISBN(String ISBN)
        {
            try
            {
                return ClsBLEmprunt.CountNbrExemplaireByISBN(ISBN).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
