using System;
using System.Collections.Generic;
using System.Linq;
using COUCHEBO;
using COUCHEDAL;

namespace COUCHEBL
{
    public static class ClsBLEtat
    {
        public static List<ClsBOEtat> SelectAllEtat()
        {
            List<ClsBOEtat> lstRetour;

            using (var dal = new ClsDALEtat(CUtil.GetConnexion()))
                lstRetour = dal.SelectAllEtat().ToList();
            return lstRetour;
        }
    }
}
