using System;
using System.Collections.Generic;
using System.ServiceModel;
using COUCHEBO;
namespace COUCHEIFAC
{
    [ServiceContract(Namespace = "COUCHEIFAC/ClsIFACBiblio")]
    public interface ClsIFACBiblio
    {
        [OperationContract]
        List<ClsBOBiblio> SelectAllBiblio();
    }
}
