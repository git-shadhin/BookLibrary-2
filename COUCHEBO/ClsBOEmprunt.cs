using System;
using System.Runtime.Serialization;

namespace COUCHEBO
{
    [DataContract(Namespace = "urn:COUCHEBO.ClsBOEmprunt")]
    public class ClsBOEmprunt
    {
        private Int32 _Emprunt_ID;
        private Int32 _Lecteur_ID;
        private Int32 _Exemplaire_ID;
        private DateTime _Date_Emprunt;
        private DateTime? _Date_Retour;
        private DateTime _Date_Retour_Effective;
        private Int32 _Prix;

        [DataMember(Name = "Emprunt_ID")]
        public Int32 Emprunt_ID
        {
            get { return _Emprunt_ID; }
            set { _Emprunt_ID = value; }
        }

        [DataMember(Name = "Lecteur_ID")]
        public Int32 Lecteur_ID
        {
            get { return _Lecteur_ID; }
            set { _Lecteur_ID = value; }
        }

        [DataMember(Name = "Exemplaire_ID")]
        public Int32 Exemplaire_ID
        {
            get { return _Exemplaire_ID; }
            set { _Exemplaire_ID = value; }
        }

        [DataMember(Name = "Date_Emprunt")]
        public DateTime Date_Emprunt
        {
            get { return _Date_Emprunt; }
            set { _Date_Emprunt = value; }
        }

        [DataMember(Name = "Date_Retour")]
        public DateTime? Date_Retour
        {
            get { return _Date_Retour; }
            set { _Date_Retour = value; }
        }

        [DataMember(Name = "Date_Retour_Effective")]
        public DateTime Date_Retour_Effective
        {
            get { return _Date_Retour_Effective; }
            set { _Date_Retour_Effective = value; }
        }

        [DataMember(Name = "Prix")]
        public Int32 Prix
        {
            get { return _Prix; }
            set { _Prix = value; }
        }
    }
}
