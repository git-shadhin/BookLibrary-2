using System;
using System.Collections.Generic;
using System.Linq;
using COUCHEIFAC;
using COUCHEBL;
using COUCHEBO;
using COUCHEERROR;

namespace COUCHEFAC
{
    public class ClsFACLecteur : ClsIFACLecteur
    {
        public List<ClsBOLecteur> SelectAllLecteur()
        {
            try
            {
                return ClsBLLecteur.SelectAllLecteur().ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<ClsBOLecteur> SelectLecteurByUsername(String Username)
        {
            try
            {
                return ClsBLLecteur.SelectLecteurByUsername(Username);

            }
            catch (InvalidCastException)
            {
                throw;
            }
        }

        public ClsBOLecteur SelectNb_EmpruntByLecteurID(Int32 Lecteur_ID)
        {
            try
            {
                return ClsBLLecteur.SelectNb_EmpruntByLecteurID(Lecteur_ID);

            }
            catch (Exception)
            {
                throw;
            }
        }

        public ClsBOLecteur Login(String Username, String Password)
        {
            try
            {
                return ClsBLLecteur.Login(Username, Password);

            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
