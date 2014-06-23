using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace COUCHEBO
{
    [DataContract(Namespace = "urn:COUCHEBO.ClsBOLivre_Auteur")]
    public class ClsBOLivre_Auteur
    {
        private Int32 _Auteur_ID;
        private String _ISBN;

        [DataMember(Name = "Auteur_ID")]
        public Int32 Auteur_ID
        {
            get { return _Auteur_ID; }
            set { _Auteur_ID = value; }
        }

        [DataMember(Name = "ISBN")]
        public String ISBN
        {
            get { return _ISBN; }
            set { _ISBN = value; }
        }
    }
}
