using System;
using System.Collections.Generic;
using System.Linq;
using COUCHEIFAC;
using COUCHEBL;
using COUCHEBO;
using COUCHEERROR;

namespace COUCHEFAC
{
    public class ClsFACAuteur : ClsIFACAuteur
    {
        public List<ClsBOAuteur> SelectAllAuteur()
        {
            try
            {
                return ClsBLAuteur.SelectAllAuteur().ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public ClsBOAuteur AddAuteur(String Nom, String Prenom)
        {
            try
            {
                return ClsBLAuteur.AddAuteur(Nom, Prenom);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}