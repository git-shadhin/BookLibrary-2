using System;
using System.Collections.Generic;
using System.ServiceModel;
using COUCHEBO;

namespace COUCHEIFAC
{
    [ServiceContract(Namespace = "COUCHEIFAC/ClsIFACLivre_Auteur")]
    public interface ClsIFACLivre_Auteur
    {
        [OperationContract]
        List<ClsBOLivre_Auteur> SelectAllLivreAuteur();
    }
}
