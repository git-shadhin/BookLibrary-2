using System;
using System.Collections.Generic;
using System.Linq;
using COUCHEBO;
using COUCHEDAL;

namespace COUCHEBL
{
    public static class ClsBLAuteur
    {
        public static List<ClsBOAuteur> SelectAllAuteur()
        {
            List<ClsBOAuteur> lstRetour;

            using (var dal = new ClsDALAuteur(CUtil.GetConnexion()))
                lstRetour = dal.SelectAllAuteur().ToList();
            return lstRetour;
        }

        public static ClsBOAuteur AddAuteur(String Nom, String Prenom)
        {
            ClsBOAuteur objRetour = null;
            List<ClsBOAuteur> lstRetour;

            using (var dal = new ClsDALAuteur(CUtil.GetConnexion()))
                lstRetour = dal.AddAuteur(Nom, Prenom).ToList();

            if (lstRetour.Count > 0)
                objRetour = lstRetour[0];
            return objRetour;
        }
    }
}
