using System;
using System.Collections.Generic;
using System.Linq;
using COUCHEBO;
using COUCHEDAL;

namespace COUCHEBL
{
    public static class ClsBLLecteur_Bibliotheque
    {
        public static List<ClsBOLecteur_Bibliotheque> SelectAllLecteurBiblio()
        {
            List<ClsBOLecteur_Bibliotheque> lstRetour;

            using (var dal = new ClsDALLecteur_Bibliotheque(CUtil.GetConnexion()))
                lstRetour = dal.SelectAllLecteurBiblio().ToList();
            return lstRetour;
        }

        public static ClsBOLecteur_Bibliotheque SelectLecteurBiblioByLecteurID(Int32 Lecteur_ID)
        {
            ClsBOLecteur_Bibliotheque objRetour = null;
            List<ClsBOLecteur_Bibliotheque> lstRetour;

            using (var dal = new ClsDALLecteur_Bibliotheque(CUtil.GetConnexion()))
                lstRetour = dal.SelectLecteurBiblioByLecteurID(Lecteur_ID).ToList();

            if (lstRetour.Count > 0)
                objRetour = lstRetour[0];
            return objRetour;
        }
    }
}
