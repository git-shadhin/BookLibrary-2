using System;
using System.Collections.Generic;
using System.ServiceModel;
using COUCHEBO;

namespace COUCHEIFAC
{
    [ServiceContract(Namespace = "COUCHEIFAC/ClsIFACLivre")]
    public interface ClsIFACLivre
    {
        [OperationContract]
        List<ClsBOLivre> SelectAllLivre();

        [OperationContract]
        List<ClsBOLivre> SelectLivreByTitre(String Titre);

        [OperationContract]
        List<ClsBOLivre> SelectLivreByISBN(String ISBN);

        [OperationContract]
        ClsBOLivre AddLivre(String ISBN, String Titre, Int32 Genre_ID, byte[] Cover, Int32 Biblio_ID, Int32 Auteur_ID);
    }
}
