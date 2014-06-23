using System;
using System.Collections.Generic;
using System.Linq;
using COUCHEIFAC;
using COUCHEBL;
using COUCHEBO;
using COUCHEERROR;

namespace COUCHEFAC
{
    public class ClsFACLivre_Auteur : ClsIFACLivre_Auteur
    {
        public List<ClsBOLivre_Auteur> SelectAllLivreAuteur()
        {
            try
            {
                return ClsBLLivre_Auteur.SelectAllLivreAuteur().ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
