using System;
using System.Collections.Generic;
using System.Linq;
using COUCHEIFAC;
using COUCHEBL;
using COUCHEBO;
using COUCHEERROR;

namespace COUCHEFAC
{
    public class ClsFACGestion_Bibliotheque : ClsIFACGestion_Bibliotheque
    {
        public List<ClsBOGestion_Bibliotheque> SelectAllGestionnaireBiblio()
        {
            try
            {
                return ClsBLGestion_Bibliotheque.SelectAllGestionnaireBiblio().ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public ClsBOGestion_Bibliotheque SelectWhereIsAdmin(Int32 Lecteur_ID, Int32 Biblio_ID)
        {
            try
            {
                return ClsBLGestion_Bibliotheque.SelectWhereIsAdmin(Lecteur_ID, Biblio_ID);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
