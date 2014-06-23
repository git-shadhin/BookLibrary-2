using System;
using System.Runtime.Serialization;

namespace COUCHEBO
{
    [DataContract(Namespace = "urn:COUCHEBO.ClsBOAuteur")]
    public class ClsBOAuteur
    {
        public ClsBOAuteur()
        {
        }

        public ClsBOAuteur(String Nom, String Prenom)
        {
            _Nom = Nom;
            _Prenom = Prenom;
        }

        private Int32 _Auteur_ID;
        private String _Nom;
        private String _Prenom;

        private String _NomPrenom;

        [DataMember(Name = "Auteur_ID")]
        public Int32 Auteur_ID
        {
            get { return _Auteur_ID; }
            set { _Auteur_ID = value; }
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

        [DataMember]
        public String NomPrenom
        {
            get { return _Nom + ", " + _Prenom; }
            set { _NomPrenom = value; }
        }

    }
}
