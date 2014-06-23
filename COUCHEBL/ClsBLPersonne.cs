using System;
using System.Collections.Generic;
using System.Linq;
using COUCHEBO;
using COUCHEDAL;

namespace COUCHEBL
{
    public static class ClsBLPersonne
    {
        public static List<ClsBOPersonne> SelectAllPersonne()
        {
            List<ClsBOPersonne> lstRetour;

            using (var dal = new ClsDALPersonne(CUtil.GetConnexion()))
                lstRetour = dal.SelectAllPersonne().ToList();
            return lstRetour;
        }
    }
}
