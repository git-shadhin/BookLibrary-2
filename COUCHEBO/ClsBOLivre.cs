using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace COUCHEBO
{
    [DataContract(Namespace = "urn:COUCHEBO.ClsBOLivre")]
    public class ClsBOLivre
    {
        private String _ISBN;
        private String _Titre;
        private Int32 _Genre_ID;
        private byte[] _Cover;

        [DataMember(Name= "ISBN")]
        public String ISBN
        {
            get { return _ISBN; }
            set { _ISBN = value; }
        }

        [DataMember(Name = "Titre")]
        public String Titre
        {
            get { return _Titre; }
            set { _Titre = value; }
        }

        [DataMember(Name = "Genre_ID")]
        public Int32 Genre_ID
        {
            get { return _Genre_ID; }
            set { _Genre_ID = value; }
        }

        [DataMember(Name = "Cover")]
        public byte[] Cover
        {
            get { return _Cover; }
            set { _Cover = value; }
        }
    }
}
