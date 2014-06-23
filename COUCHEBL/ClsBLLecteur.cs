using System;
using System.Collections.Generic;
using System.Linq;
using COUCHEBO;
using COUCHEDAL;

namespace COUCHEBL
{
    public static class ClsBLLecteur
    {
        public static List<ClsBOLecteur> SelectAllLecteur()
        {
            List<ClsBOLecteur> lstResult;

            using (var dal = new ClsDALLecteur(CUtil.GetConnexion()))
                lstResult = dal.SelectAllLecteur().ToList();
            return lstResult;
        }

        public static List<ClsBOLecteur> SelectLecteurByUsername(String objUername)
        {
            List<ClsBOLecteur> lstResult;

            using (var dal = new ClsDALLecteur(CUtil.GetConnexion()))
                lstResult = dal.SelectLecteurByUsername(objUername).ToList();
            return lstResult;
        }

        public static ClsBOLecteur Login(String Username, String Password)
        {
            ClsBOLecteur objRetour = null;
            List<ClsBOLecteur> lstResult;

            using (var dal = new ClsDALLecteur(CUtil.GetConnexion()))
                lstResult = dal.Login(Username, Password).ToList();

            if (lstResult.Count > 0)
                objRetour = lstResult[0];
            return objRetour;
        }

        public static ClsBOLecteur SelectNb_EmpruntByLecteurID(Int32 Lecteur_ID)
        {
            ClsBOLecteur objRetour = null;
            List<ClsBOLecteur> lstResult;

            using (var dal = new ClsDALLecteur(CUtil.GetConnexion()))
                lstResult = dal.SelectNb_EmpruntByLecteurID(Lecteur_ID).ToList();

            if (lstResult.Count > 0)
                objRetour = lstResult[0];
            return objRetour;
        }
    }
}
