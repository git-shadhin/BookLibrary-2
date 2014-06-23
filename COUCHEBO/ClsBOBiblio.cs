using System;
using System.Runtime.Serialization;

namespace COUCHEBO
{
    [DataContract(Namespace = "urn:COUCHEBO.ClsBOBiblio")]
    public class ClsBOBiblio
    {
        private Int32 _Bibliotheque_ID;
        private String _Libelle;

        [DataMember(Name = "Bibliotheque_ID")]
        public Int32 Bibliotheque_ID
        {
            get { return _Bibliotheque_ID; }
            set { _Bibliotheque_ID = value; }
        }

        [DataMember(Name = "Libelle")]
        public String Libelle
        {
            get { return _Libelle; }
            set { _Libelle = value; }
        }

        
    }
}
