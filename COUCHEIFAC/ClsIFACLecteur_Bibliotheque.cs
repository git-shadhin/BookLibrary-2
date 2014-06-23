using System;
using System.Collections.Generic;
using System.ServiceModel;
using COUCHEBO;

namespace COUCHEIFAC
{
    [ServiceContract(Namespace = "COUCHEIFAC/ClsIFACLecteur_Bibliotheque")]
    public interface ClsIFACLecteur_Bibliotheque
    {
        [OperationContract]
        List<ClsBOLecteur_Bibliotheque> SelectAllLecteurBiblio();

        [OperationContract]
        ClsBOLecteur_Bibliotheque SelectLecteurBiblioByLecteurID(Int32 Lecteur_ID);
    }
}
