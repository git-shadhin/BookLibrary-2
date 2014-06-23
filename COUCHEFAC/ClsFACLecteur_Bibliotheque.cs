using System;
using System.Collections.Generic;
using System.Linq;
using COUCHEIFAC;
using COUCHEBL;
using COUCHEBO;
using COUCHEERROR;

namespace COUCHEFAC
{
    public class ClsFACLecteur_Bibliotheque : ClsIFACLecteur_Bibliotheque
    {
        public List<ClsBOLecteur_Bibliotheque> SelectAllLecteurBiblio()
        {
            try
            {
                return ClsBLLecteur_Bibliotheque.SelectAllLecteurBiblio().ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public ClsBOLecteur_Bibliotheque SelectLecteurBiblioByLecteurID(Int32 Lecteur_ID)
        {
            try
            {
                return ClsBLLecteur_Bibliotheque.SelectLecteurBiblioByLecteurID(Lecteur_ID);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
