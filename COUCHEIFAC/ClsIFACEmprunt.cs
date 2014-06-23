using System;
using System.Collections.Generic;
using System.ServiceModel;
using COUCHEBO;

namespace COUCHEIFAC
{
    [ServiceContract(Namespace = "COUCHEIFAC/ClsIFACEmprunt")]
    public interface ClsIFACEmprunt
    {
        [OperationContract]
        List<ClsBOEmprunt> SelectAllEmprunt();

        [OperationContract]
        List<ClsBOEmprunt> SelectEmpruntEnCoursByUtilisateur(Int32 Lecteur_ID);

        [OperationContract]
        List<ClsBOEmprunt> SelectAllEmpruntEnCours();

        [OperationContract]
        List<ClsBOEmprunt> SelectEmpruntHistoriqueByUtilisateur(Int32 Lecteur_ID);

        [OperationContract]
        ClsBOEmprunt Emprunter(Int32 Lecteur_ID, Int32 Exemplaire_ID);

        [OperationContract]
        ClsBOEmprunt EmpruntRetour(Int32 Emprunt_ID, Int32 Exemplaire_ID, Int32 Lecteur_ID);

        [OperationContract]
        ClsBOEmprunt EmpruntRetourAdmin(Int32 Emprunt_ID, Int32 Exemplaire_ID, Int32 Lecteur_ID);

        [OperationContract]
        ClsBOEmprunt SelectPrixByLecteur(Int32 Lecteur_ID);

        [OperationContract]
        ClsBOEmprunt SelectPrixByBiblio(Int32 Biblio_ID);

        [OperationContract]
        List<ClsBOEmprunt> CountNbrExemplaireByISBN(String ISBN);
    }
}
