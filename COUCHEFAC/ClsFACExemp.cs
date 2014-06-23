using System;
using System.Collections.Generic;
using System.Linq;
using COUCHEIFAC;
using COUCHEBL;
using COUCHEBO;
using COUCHEERROR;

namespace COUCHEFAC
{
    public class ClsFACExemp : ClsIFACExemp
    {
        public List<ClsBOExemp> SelectAllExemp()
        {
            try
            {
                return ClsBLExemp.SelectAllExemp().ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<ClsBOExemp> SelectExempByBiblioID(Int32 Biblio_ID)
        {
            try
            {
                return ClsBLExemp.SelectExempByBiblioID(Biblio_ID).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<ClsBOExemp> SelectExempByISBN(String ISBN)
        {
            try
            {
                return ClsBLExemp.SelectExempByISBN(ISBN);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<ClsBOExemp> SelectExempByEtat(Int32 Etat_ID)
        {
            try
            {
                return ClsBLExemp.SelectExempByEtat(Etat_ID).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<ClsBOExemp> SelectExempByISBNAndBiblioID(String ISBN, Int32 Biblio_ID)
        {
            try
            {
                return ClsBLExemp.SelectExempByISBNAndBiblioID(ISBN, Biblio_ID);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public ClsBOExemp AddExemplaire(String ISBN, Int32 Biblio_ID)
        {
            try
            {
                return ClsBLExemp.AddExemplaire(ISBN, Biblio_ID);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public ClsBOExemp SelectEtatByExempID(Int32 Exemp_ID)
        {
            try
            {
                return ClsBLExemp.SelectEtatByExempID(Exemp_ID);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
