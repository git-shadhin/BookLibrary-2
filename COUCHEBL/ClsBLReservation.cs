using System;
using System.Collections.Generic;
using System.Linq;
using COUCHEBO;
using COUCHEDAL;

namespace COUCHEBL
{
    public static class ClsBLReservation
    {
        public static List<ClsBOReservation> SelectAllReservation()
        {
            List<ClsBOReservation> lstRetour;

            using (var dal = new ClsDALReservation(CUtil.GetConnexion()))
                lstRetour = dal.SelectAllReservation().ToList();
            return lstRetour;
        }

        public static ClsBOReservation Reserver(String ISBN, Int32 Lecteur_ID)
        {
            ClsBOReservation objRetour = null;
            List<ClsBOReservation> lstRetour;

            using (var dal = new ClsDALReservation(CUtil.GetConnexion()))
                lstRetour = dal.Reserver(ISBN, Lecteur_ID).ToList();

            if (lstRetour.Count > 0)
                objRetour = lstRetour[0];
            return objRetour;
        }

        public static List<ClsBOReservation> SelectReservEnCoursByUtilisateur(Int32 Lecteur_ID)
        {
            List<ClsBOReservation> lstRetour;

            using (var dal = new ClsDALReservation(CUtil.GetConnexion()))
                lstRetour = dal.SelectReservEnCoursByUtilisateur(Lecteur_ID).ToList();
            return lstRetour;
        }

        public static List<ClsBOReservation> SelectReservHistoriqueByUtilisateur(Int32 Lecteur_ID)
        {
            List<ClsBOReservation> lstRetour;

            using (var dal = new ClsDALReservation(CUtil.GetConnexion()))
                lstRetour = dal.SelectReservHistoriqueByUtilisateur(Lecteur_ID).ToList();
            return lstRetour;
        }
    }
}
