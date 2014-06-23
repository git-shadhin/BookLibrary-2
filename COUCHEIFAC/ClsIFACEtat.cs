using System;
using System.Collections.Generic;
using System.ServiceModel;
using COUCHEBO;

namespace COUCHEIFAC
{
    [ServiceContract(Namespace = "COUCHEIFAC/ClsIFACEtat")]
    public interface ClsIFACEtat
    {
        [OperationContract]
        List<ClsBOEtat> SelectAllEtat();
    }
}
