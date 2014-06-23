using System;
using System.Collections.Generic;
using System.Linq;
using COUCHEBO;
using COUCHEDAL;

namespace COUCHEBL
{
    public static class ClsBLGenre
    {
        public static List<ClsBOGenre> SelectAllGenre()
        {
            List<ClsBOGenre> lstResult;

            using (var dal = new ClsDALGenre(CUtil.GetConnexion()))
                lstResult = dal.SelectAllGenre().ToList();
            return lstResult;
        }
    }
}
