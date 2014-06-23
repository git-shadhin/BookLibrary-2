using System;
using System.Runtime.Serialization;

namespace COUCHEBO
{
    [DataContract(Namespace = "urn:COUCHEBO.ClsBOLecteur_Bibliotheque")]
    public class ClsBOLecteur_Bibliotheque
    {
        private Int32 _Bibliotheque_ID;
        private Int32 _Lecteur_ID;

        [DataMember(Name = "Bibliotheque_ID")]
        public Int32 Bibliotheque_ID
        {
            get { return _Bibliotheque_ID; }
            set { _Bibliotheque_ID = value; }
        }

        [DataMember(Name = "Lecteur_ID")]
        public Int32 Lecteur_ID
        {
            get { return _Lecteur_ID; }
            set { _Lecteur_ID = value; }
        }
    }
}
