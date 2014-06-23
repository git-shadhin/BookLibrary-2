using System;
using System.Collections.Generic;
using System.Linq;
using COUCHEBO;
using COUCHEDAL;

namespace COUCHEBL
{
    public static class ClsBLExemp
    {
        public static List<ClsBOExemp> SelectAllExemp()
        {
            List<ClsBOExemp> lstResult;

            using (var dal = new ClsDALExemp(CUtil.GetConnexion()))
                lstResult = dal.SelectAllExemp().ToList();
            return lstResult;
        }

        public static List<ClsBOExemp> SelectExempByBiblioID(Int32 Bibliotheque_ID)
        {
            List<ClsBOExemp> lstResult;

            using (var dal = new ClsDALExemp(CUtil.GetConnexion()))
                lstResult = dal.SelectExempByBiblioID(Bibliotheque_ID).ToList();
            return lstResult;
        }

        public static List<ClsBOExemp> SelectExempByISBN(String ISBN)
        {
            List<ClsBOExemp> lstResult;

            using (var dal = new ClsDALExemp(CUtil.GetConnexion()))
                lstResult = dal.SelectExempByISBN(ISBN).ToList();
            return lstResult;
        }

        public static List<ClsBOExemp> SelectExempByEtat(Int32 Etat_ID)
        {
            List<ClsBOExemp> lstResult;

            using (var dal = new ClsDALExemp(CUtil.GetConnexion()))
                lstResult = dal.SelectExempByEtat(Etat_ID).ToList();
            return lstResult;
        }

        public static List<ClsBOExemp> SelectExempByISBNAndBiblioID(String ISBN, Int32 Biblio_ID)
        {
            List<ClsBOExemp> lstResult;

            using (var dal = new ClsDALExemp(CUtil.GetConnexion()))
                lstResult = dal.SelectExempByISBNAndBiblioID(ISBN, Biblio_ID).ToList();
            return lstResult;
        }

        public static ClsBOExemp AddExemplaire(String ISBN, Int32 Biblio_ID)
        {
            ClsBOExemp objRetour = null;
            List<ClsBOExemp> lstRetour;

            using (var dal = new ClsDALExemp(CUtil.GetConnexion()))
                lstRetour = dal.AddExemplaire(ISBN, Biblio_ID).ToList();

            if (lstRetour.Count > 0)
                objRetour = lstRetour[0];
            return objRetour;
        }

        public static ClsBOExemp SelectEtatByExempID(Int32 Exemp_ID)
        {
            ClsBOExemp objRetour = null;
            List<ClsBOExemp> lstRetour;

            using (var dal = new ClsDALExemp(CUtil.GetConnexion()))
                lstRetour = dal.AddExemplaire(Exemp_ID).ToList();

            if (lstRetour.Count > 0)
                objRetour = lstRetour[0];
            return objRetour;
        }
    }
}
