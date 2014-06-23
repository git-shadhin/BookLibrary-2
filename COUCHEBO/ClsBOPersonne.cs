using System;
using System.Runtime.Serialization;

namespace COUCHEBO
{
     [DataContract(Namespace = "urn:COUCHEBO.ClsBOPersonne")]
    public class ClsBOPersonne
    {
        private Int32 _Pers_ID;
        private String _Nom;
        private String _Prenom;

        [DataMember(Name = "Pers_ID")]
        public Int32 Pers_ID
        {
            get { return _Pers_ID; }
            set { _Pers_ID = value; }
        }

        [DataMember(Name = "Nom")]
        public String Nom
        {
            get { return _Nom; }
            set { _Nom = value; }
        }

        [DataMember(Name = "Prenom")]
        public String Prenom
        {
            get { return _Prenom; }
            set { _Prenom = value; }
        }
    }
}
