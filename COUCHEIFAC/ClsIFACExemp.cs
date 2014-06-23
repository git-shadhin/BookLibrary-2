using System;
using System.Collections.Generic;
using System.ServiceModel;
using COUCHEBO;


namespace COUCHEIFAC
{
    [ServiceContract(Namespace = "COUCHEIFAC/ClsIFACExemp")]
    public interface ClsIFACExemp
    {
        [OperationContract]
        List<ClsBOExemp> SelectAllExemp();

        [OperationContract]
        List<ClsBOExemp> SelectExempByBiblioID(Int32 Biblio_ID);

        [OperationContract]
        List<ClsBOExemp> SelectExempByISBN(String ISBN);

        [OperationContract]
        List<ClsBOExemp> SelectExempByEtat(Int32 Etat_ID);

        [OperationContract]
        List<ClsBOExemp> SelectExempByISBNAndBiblioID(String ISBN, Int32 Biblio_ID);

        [OperationContract]
        ClsBOExemp AddExemplaire(String ISBN, Int32 Biblio_ID);

        [OperationContract]
        ClsBOExemp SelectEtatByExempID(Int32 Exemp_ID);

    }
}
