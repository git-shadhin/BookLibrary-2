using System;
using System.Collections.Generic;
using System.ServiceModel;
using COUCHEBO;

namespace COUCHEIFAC
{
    [ServiceContract(Namespace = "COUCHEIFAC/ClsIFACGestion_Bibliotheque")]
    public interface ClsIFACGestion_Bibliotheque
    {
        [OperationContract]
        List<ClsBOGestion_Bibliotheque> SelectAllGestionnaireBiblio();

        [OperationContract]
        ClsBOGestion_Bibliotheque SelectWhereIsAdmin(Int32 Lecteur_ID, Int32 Biblio_ID);
    }
}
