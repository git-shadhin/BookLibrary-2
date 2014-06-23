using System;
using System.Runtime.Serialization;

namespace COUCHEBO
{
    [DataContract(Namespace = "urn:COUCHEBO.ClsBOReservation")]
    public class ClsBOReservation
    {
        private Int32 _Reservation_ID;
        private String _ISBN;
        private Int32 _Lecteur_ID;
        private DateTime _Date_Reservation;
        private DateTime? _Date_Annulation;
        private Int32 _Etat_ID;

        [DataMember(Name = "Reservation_ID")]
        public Int32 Reservation_ID
        {
            get { return _Reservation_ID; }
            set { _Reservation_ID = value; }
        }

        [DataMember(Name = "ISBN")]
        public String ISBN
        {
            get { return _ISBN; }
            set { _ISBN = value; }
        }

        [DataMember(Name = "Lecteur_ID")]
        public Int32 Lecteur_ID
        {
            get { return _Lecteur_ID; }
            set { _Lecteur_ID = value; }
        }

        [DataMember(Name = "Date_Reservation")]
        public DateTime Date_Reservation
        {
            get { return _Date_Reservation; }
            set { _Date_Reservation = value; }
        }

        [DataMember(Name = "Date_Annulation")]
        public DateTime? Date_Annulation
        {
            get { return _Date_Annulation; }
            set { _Date_Annulation = value; }
        }

        [DataMember(Name = "Etat_ID")]
        public Int32 Etat_ID
        {
            get { return _Etat_ID; }
            set { _Etat_ID = value; }
        }
    }
}
