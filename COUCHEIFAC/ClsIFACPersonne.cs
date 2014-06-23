using System;
using System.Collections.Generic;
using System.ServiceModel;
using COUCHEBO;

namespace COUCHEIFAC
{
    [ServiceContract(Namespace = "COUCHEIFAC/ClsIFACPersonne")]
    public interface ClsIFACPersonne
    {
        [OperationContract]
        List<ClsBOPersonne> SelectAllPersonne();
    }
}
