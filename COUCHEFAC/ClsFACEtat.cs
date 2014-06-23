using System;
using System.Collections.Generic;
using System.Linq;
using COUCHEIFAC;
using COUCHEBL;
using COUCHEBO;
using COUCHEERROR;

namespace COUCHEFAC
{
    public class ClsFACEtat : ClsIFACEtat
    {
        public List<ClsBOEtat> SelectAllEtat()
        {
            try
            {
                return ClsBLEtat.SelectAllEtat().ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
