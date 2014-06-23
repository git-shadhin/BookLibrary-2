using System;
using System.Runtime.Serialization;

namespace COUCHEBO
{
    [DataContract(Namespace = "urn:COUCHEBO.ClsBOGenre")]
    public class ClsBOGenre
    {
        private Int32 _Genre_ID;
        private String _Libelle;

        [DataMember(Name = "Genre_ID")]
        public Int32 Genre_ID
        {
            get { return _Genre_ID; }
            set { _Genre_ID = value; }
        }

        [DataMember(Name = "Libelle")]
        public String Libelle
        {
            get { return _Libelle; }
            set { _Libelle = value; }
        }
    }
}
