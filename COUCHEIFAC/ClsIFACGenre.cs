using System;
using System.Collections.Generic;
using System.ServiceModel;
using COUCHEBO;

namespace COUCHEIFAC
{
    [ServiceContract(Namespace = "COUCHEIFAC/ClsIFACGenre")]
    public interface ClsIFACGenre
    {
        [OperationContract]
        List<ClsBOGenre> SelectAllGenre();
    }
}
