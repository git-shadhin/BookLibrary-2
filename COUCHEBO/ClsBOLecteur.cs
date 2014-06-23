using System;
using System.Runtime.Serialization;

namespace COUCHEBO
{
    [DataContract(Namespace = "urn:COUCHEBO.ClsBOLecteur")]
    public class ClsBOLecteur
    {
        private Int32 _Lecteur_ID;
        private String _Username;
        private String _Password;
        private Int32 _Nb_Emprunt;
        private Boolean _IsAdmin;
        private Int32 _Pers_ID;

        [DataMember(Name = "Lecteur_ID")]
        public Int32 LECTEUR_ID
        {
            get { return _Lecteur_ID; }
            set { _Lecteur_ID = value; }
        }

        [DataMember(Name = "Username")]
        public String USERNAME
        {
            get { return _Username; }
            set { _Username = value; }
        }

        [DataMember(Name = "Password")]
        public String PASSWORD
        {
            get { return _Password; }
            set { _Password = value; }
        }

        [DataMember(Name = "Nb_Emprunt")]
        public Int32 NB_EMPRUNT
        {
            get { return _Nb_Emprunt; }
            set { _Nb_Emprunt = value; }
        }

        [DataMember(Name = "Pers_ID")]
        public Int32 PERS_ID
        {
            get { return _Pers_ID; }
            set { _Pers_ID = value; }
        }

        [DataMember(Name = "IsAdmin")]
        public Boolean ISADMIN
        {
            get { return _IsAdmin; }
            set { _IsAdmin = value; }
        }
    }
}
