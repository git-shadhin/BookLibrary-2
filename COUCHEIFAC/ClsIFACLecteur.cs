using System;
using System.Collections.Generic;
using System.ServiceModel;
using COUCHEBO;

namespace COUCHEIFAC
{
    [ServiceContract(Namespace = "COUCHEIFAC/ClsIFACLecteur")]
    public interface ClsIFACLecteur
    {
        [OperationContract]
        List<ClsBOLecteur> SelectAllLecteur();

        [OperationContract]
        List<ClsBOLecteur> SelectLecteurByUsername(String Username);

        [OperationContract]
        ClsBOLecteur Login(String Username, String Password);

        [OperationContract]
        ClsBOLecteur SelectNb_EmpruntByLecteurID(Int32 Lecteur_ID);
    }
}
