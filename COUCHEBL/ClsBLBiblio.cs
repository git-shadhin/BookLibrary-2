using System;
using System.Collections.Generic;
using System.Linq;
using COUCHEBO;
using COUCHEDAL;

namespace COUCHEBL
{
    public static class ClsBLBiblio
    {
        public static List<ClsBOBiblio> SelectAllBiblio()
        {
            List<ClsBOBiblio> lstResult;
            using (var dal = new ClsDALBiblio(CUtil.GetConnexion()))
                lstResult = dal.SelectAllBiblio().ToList();
            return lstResult;
        }
    }
}
