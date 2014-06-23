using System;
using System.Collections.Generic;
using System.Linq;
using COUCHEBO;
using COUCHEDAL;

namespace COUCHEBL
{
    public static class ClsBLEmprunt
    {
        public static List<ClsBOEmprunt> SelectAllEmprunt()
        {
            List<ClsBOEmprunt> lstRetour;

            using (var dal = new ClsDALEmprunt(CUtil.GetConnexion()))
                lstRetour = dal.SelectAllEmprunt().ToList();
            return lstRetour;
        }

        public static List<ClsBOEmprunt> SelectEmpruntEnCoursByUtilisateur(Int32 Lecteur_ID)
        {
            List<ClsBOEmprunt> lstRetour;

            using (var dal = new ClsDALEmprunt(CUtil.GetConnexion()))
                lstRetour = dal.SelectEmpruntEnCoursByUtilisateur(Lecteur_ID).ToList();
            return lstRetour;
        }

        public static List<ClsBOEmprunt> SelectEmpruntHistoriqueByUtilisateur(Int32 Lecteur_ID)
        {
            List<ClsBOEmprunt> lstRetour;

            using (var dal = new ClsDALEmprunt(CUtil.GetConnexion()))
                lstRetour = dal.SelectEmpruntHistoriqueByUtilisateur(Lecteur_ID).ToList();
            return lstRetour;
        }

        public static List<ClsBOEmprunt> SelectAllEmpruntEnCours()
        {
            List<ClsBOEmprunt> lstRetour;

            using (var dal = new ClsDALEmprunt(CUtil.GetConnexion()))
                lstRetour = dal.SelectAllEmpruntEnCours().ToList();
            return lstRetour;
        }

        public static ClsBOEmprunt Emprunter(Int32 Lecteur_ID, Int32 Exemplaire_ID)
        {
            ClsBOEmprunt objRetour = null;
            List<ClsBOEmprunt> lstRetour;

            using (var dal = new ClsDALEmprunt(CUtil.GetConnexion()))
                lstRetour = dal.Emprunter(Lecteur_ID, Exemplaire_ID).ToList();

            if (lstRetour.Count > 0)
                objRetour = lstRetour[0];
            return objRetour;
        }

        public static ClsBOEmprunt EmpruntRetour(Int32 Emprunt_ID, Int32 Exemplaire_ID, Int32 Lecteur_ID)
        {
            ClsBOEmprunt objRetour = null;
            List<ClsBOEmprunt> lstRetour;

            using (var dal = new ClsDALEmprunt(CUtil.GetConnexion()))
                lstRetour = dal.EmpruntRetour(Emprunt_ID, Exemplaire_ID, Lecteur_ID).ToList();

            if (lstRetour.Count > 0)
                objRetour = lstRetour[0];
            return objRetour;
        }

        public static ClsBOEmprunt EmpruntRetourAdmin(Int32 Emprunt_ID, Int32 Exemplaire_ID, Int32 Lecteur_ID)
        {
            ClsBOEmprunt objRetour = null;
            List<ClsBOEmprunt> lstRetour;

            using (var dal = new ClsDALEmprunt(CUtil.GetConnexion()))
                lstRetour = dal.EmpruntRetourAdmin(Emprunt_ID, Exemplaire_ID, Lecteur_ID).ToList();

            if (lstRetour.Count > 0)
                objRetour = lstRetour[0];
            return objRetour;
        }

        public static ClsBOEmprunt SelectPrixByLecteur(Int32 Lecteur_ID)
        {
            ClsBOEmprunt objRetour = null;
            List<ClsBOEmprunt> lstRetour;

            using (var dal = new ClsDALEmprunt(CUtil.GetConnexion()))
                lstRetour = dal.SelectPrixByLecteur(Lecteur_ID).ToList();

            if (lstRetour.Count > 0)
                objRetour = lstRetour[0];
            return objRetour;
        }

        public static ClsBOEmprunt SelectPrixByBiblio(Int32 Biblio_ID)
        {
            ClsBOEmprunt objRetour = null;
            List<ClsBOEmprunt> lstRetour;

            using (var dal = new ClsDALEmprunt(CUtil.GetConnexion()))
                lstRetour = dal.SelectPrixByBiblio(Biblio_ID).ToList();
            
            if (lstRetour.Count > 0)
                objRetour = lstRetour[0];
            return objRetour;
        }

        public static List<ClsBOEmprunt> CountNbrExemplaireByISBN(String ISBN)
        {
            List<ClsBOEmprunt> lstRetour;

            using (var dal = new ClsDALEmprunt(CUtil.GetConnexion()))
                lstRetour = dal.CountNbrExemplaireByISBN(ISBN).ToList();
            return lstRetour;
        }
    }
}
