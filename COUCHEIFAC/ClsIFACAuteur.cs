using System;
using System.Collections.Generic;
using System.ServiceModel;
using COUCHEBO;

namespace COUCHEIFAC
{
    [ServiceContract(Namespace = "COUCHEIFAC/ClsIFACAuteur")]
    public interface ClsIFACAuteur
    {
        [OperationContract]
        List<ClsBOAuteur> SelectAllAuteur();

        [OperationContract]
        ClsBOAuteur AddAuteur(String Nom, String Prenom);
    }
}
