using System;
using System.Collections.Generic;
using System.Linq;
using COUCHEIFAC;
using COUCHEBL;
using COUCHEBO;
using COUCHEERROR;

namespace COUCHEFAC
{
    public class ClsFACLivre : ClsIFACLivre
    {
        public List<ClsBOLivre> SelectAllLivre()
        {
            try
            {
                return ClsBLLivre.SelectAllLivre().ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<ClsBOLivre> SelectLivreByTitre(String Titre)
        {
            try
            {
                return ClsBLLivre.SelectLivreByTitre(Titre);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<ClsBOLivre> SelectLivreByISBN(String ISBN)
        {
            try
            {
                return ClsBLLivre.SelectLivreByISBN(ISBN);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public ClsBOLivre AddLivre(String ISBN, String Titre, Int32 Genre_ID, byte[] Cover, Int32 Biblio_ID, Int32 Auteur_ID)
        {
            try
            {
                return ClsBLLivre.AddLivre(ISBN, Titre, Genre_ID, Cover, Biblio_ID, Auteur_ID);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
