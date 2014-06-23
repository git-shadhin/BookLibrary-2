using System;
using System.Runtime.Serialization;


namespace COUCHEBO
{
    [DataContract(Namespace = "urn:COUCHEBO.ClsBOExemp")]
    public class ClsBOExemp
    {
        private Int32 _Exemplaire_ID;
        private String _ISBN;
        private Int32 _Bibliotheque_ID;
        private Int32 _Etat_ID;
        private DateTime _Date_Creation;

        [DataMember(Name = "Exemplaire_ID")]
        public Int32 Exemplaire_ID
        {
            get { return _Exemplaire_ID; }
            set { _Exemplaire_ID = value; }
        }

        [DataMember(Name = "ISBN")]
        public String ISBN
        {
            get { return _ISBN; }
            set { _ISBN = value; }
        }

        [DataMember(Name = "Bibliotheque_ID")]
        public Int32 Bibliotheque_ID
        {
            get { return _Bibliotheque_ID; }
            set { _Bibliotheque_ID = value; }
        }

        [DataMember(Name = "Etat_ID")]
        public Int32 Etat_ID
        {
            get { return _Etat_ID; }
            set { _Etat_ID = value; }
        }

        [DataMember(Name = "Date_Creation")]
        public DateTime Date_Creation
        {
            get { return _Date_Creation; }
            set { _Date_Creation = value; }
        }
    }
}
