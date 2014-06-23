using System;
using System.Collections.Generic;
using System.Linq;
using COUCHEIFAC;
using COUCHEBL;
using COUCHEBO;
using COUCHEERROR;

namespace COUCHEFAC
{
    public class ClsFACBiblio : ClsIFACBiblio
    {
        public List<ClsBOBiblio> SelectAllBiblio()
        {
            try
            {
                return ClsBLBiblio.SelectAllBiblio().ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
