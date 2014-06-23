using System;
using System.Collections.Generic;
using System.ServiceModel;
using COUCHEBO;

namespace COUCHEIFAC
{
    [ServiceContract(Namespace = "COUCHEIFAC/ClsIFACReservation")]
    public interface ClsIFACReservation
    {
        [OperationContract]
        List<ClsBOReservation> SelectAllReservation();

        [OperationContract]
        ClsBOReservation Reserver(String ISBN, Int32 Lecteur_ID);

        [OperationContract]
        List<ClsBOReservation> SelectReservHistoriqueByUtilisateur(Int32 Lecteur_ID);

        [OperationContract]
        List<ClsBOReservation> SelectReservEnCoursByUtilisateur(Int32 Lecteur_ID);
    }
}
