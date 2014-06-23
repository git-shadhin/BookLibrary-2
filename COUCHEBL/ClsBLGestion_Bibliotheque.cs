using System;
using System.Collections.Generic;
using System.Linq;
using COUCHEBO;
using COUCHEDAL;

namespace COUCHEBL
{
    public static class ClsBLGestion_Bibliotheque
    {
        public static List<ClsBOGestion_Bibliotheque> SelectAllGestionnaireBiblio()
        {
            List<ClsBOGestion_Bibliotheque> lstRetour;

            using (var dal = new ClsDALGestion_Bibliotheque(CUtil.GetConnexion()))
                lstRetour = dal.SelectAllGestionnaireBiblio().ToList();
            return lstRetour;
        }

        public static ClsBOGestion_Bibliotheque SelectWhereIsAdmin(Int32 Lecteur_ID, Int32 Biblio_ID)
        {
            ClsBOGestion_Bibliotheque objRetour = null;
            List<ClsBOGestion_Bibliotheque> lstRetour;

            using (var dal = new ClsDALGestion_Bibliotheque(CUtil.GetConnexion()))
                lstRetour = dal.SelectWhereIsAdmin(Lecteur_ID, Biblio_ID).ToList();

            if (lstRetour.Count > 0)
                objRetour = lstRetour[0];
            return objRetour;
        }
    }
}
