using System;
using System.Collections.Generic;
using System.Linq;
using COUCHEIFAC;
using COUCHEBL;
using COUCHEBO;
using COUCHEERROR;

namespace COUCHEFAC
{
    public class ClsFACReservation : ClsIFACReservation
    {
        public List<ClsBOReservation> SelectAllReservation()
        {
            try
            {
                return ClsBLReservation.SelectAllReservation().ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public ClsBOReservation Reserver(String ISBN, Int32 Lecteur_ID)
        {
            try
            {
                return ClsBLReservation.Reserver(ISBN, Lecteur_ID);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<ClsBOReservation> SelectReservEnCoursByUtilisateur(Int32 Lecteur_ID)
        {
            try
            {
                return ClsBLReservation.SelectReservEnCoursByUtilisateur(Lecteur_ID).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<ClsBOReservation> SelectReservHistoriqueByUtilisateur(Int32 Lecteur_ID)
        {
            try
            {
                return ClsBLReservation.SelectReservHistoriqueByUtilisateur(Lecteur_ID).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
