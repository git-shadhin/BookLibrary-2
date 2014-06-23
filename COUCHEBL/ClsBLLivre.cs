using System;
using System.Collections.Generic;
using System.Linq;
using COUCHEBO;
using COUCHEDAL;

namespace COUCHEBL
{
    public static class ClsBLLivre
    {
        public static List<ClsBOLivre> SelectAllLivre()
        {
            List<ClsBOLivre> lstRetour;

            using (var dal = new ClsDALLivre(CUtil.GetConnexion()))
                lstRetour = dal.SelectAllLivre().ToList();
            return lstRetour;
        }

        public static List<ClsBOLivre> SelectLivreByTitre(String Titre)
        {
            List<ClsBOLivre> lstRetour;

            using (var dal = new ClsDALLivre(CUtil.GetConnexion()))
                lstRetour = dal.SelectLivreByTitre(Titre).ToList();
            return lstRetour;
        }

        public static List<ClsBOLivre> SelectLivreByISBN(String ISBN)
        {
            List<ClsBOLivre> lstRetour;

            using (var dal = new ClsDALLivre(CUtil.GetConnexion()))
                lstRetour = dal.SelectLivreByISBN(ISBN).ToList();
            return lstRetour;
        }

        public static ClsBOLivre AddLivre(String ISBN, String Titre, Int32 Genre_ID, byte[] Cover, Int32 Biblio_ID, Int32 Auteur_ID)
        {
            ClsBOLivre objRetour = null;
            List<ClsBOLivre> lstRetour;

            using (var dal = new ClsDALLivre(CUtil.GetConnexion()))
                lstRetour = dal.AddLivre(ISBN, Titre, Genre_ID, Cover, Biblio_ID, Auteur_ID).ToList();

            if (lstRetour.Count > 0)
                objRetour = lstRetour[0];
            return objRetour;
        }
    }
}
