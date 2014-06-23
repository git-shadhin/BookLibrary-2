using System;
using System.Runtime.Serialization;

namespace COUCHEBO
{
    [DataContract(Namespace = "urn:COUCHEBO.ClsBOEtat")]
    public class ClsBOEtat
    {
        private Int32 _Etat_ID;
        private String _Libelle;

        [DataMember(Name = "Etat_ID")]
        public Int32 Etat_ID
        {
            get { return _Etat_ID; }
            set { _Etat_ID = value; }
        }

        [DataMember(Name = "Libelle")]
        public String Libelle
        {
            get { return _Libelle; }
            set { _Libelle = value; }
        }
    }
}
