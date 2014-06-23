using System;
using System.Collections.Generic;
using System.Linq;
using COUCHEIFAC;
using COUCHEBL;
using COUCHEBO;
using COUCHEERROR;

namespace COUCHEFAC
{
    public class ClsFACGenre : ClsIFACGenre
    {
        public List<ClsBOGenre> SelectAllGenre()
        {
            try
            {
                return ClsBLGenre.SelectAllGenre().ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
