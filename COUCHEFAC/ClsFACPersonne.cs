using System;
using System.Collections.Generic;
using System.Linq;
using COUCHEIFAC;
using COUCHEBL;
using COUCHEBO;
using COUCHEERROR;

namespace COUCHEFAC
{
    public class ClsFACPersonne : ClsIFACPersonne
    {
        public List<ClsBOPersonne> SelectAllPersonne()
        {
            try
            {
                return ClsBLPersonne.SelectAllPersonne().ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
