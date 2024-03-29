﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.18444
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Bibliotheque.Proxies
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="COUCHEIFAC/ClsIFACLivre", ConfigurationName="Bibliotheque.Proxies.ClsIFACLivre")]
    public interface ClsIFACLivre
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="COUCHEIFAC/ClsIFACLivre/ClsIFACLivre/SelectAllLivre", ReplyAction="COUCHEIFAC/ClsIFACLivre/ClsIFACLivre/SelectAllLivreResponse")]
        System.Collections.Generic.List<COUCHEBO.ClsBOLivre> SelectAllLivre();
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="COUCHEIFAC/ClsIFACLivre/ClsIFACLivre/SelectAllLivre", ReplyAction="COUCHEIFAC/ClsIFACLivre/ClsIFACLivre/SelectAllLivreResponse")]
        System.IAsyncResult BeginSelectAllLivre(System.AsyncCallback callback, object asyncState);
        
        System.Collections.Generic.List<COUCHEBO.ClsBOLivre> EndSelectAllLivre(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(Action="COUCHEIFAC/ClsIFACLivre/ClsIFACLivre/SelectLivreByTitre", ReplyAction="COUCHEIFAC/ClsIFACLivre/ClsIFACLivre/SelectLivreByTitreResponse")]
        System.Collections.Generic.List<COUCHEBO.ClsBOLivre> SelectLivreByTitre(string Titre);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="COUCHEIFAC/ClsIFACLivre/ClsIFACLivre/SelectLivreByTitre", ReplyAction="COUCHEIFAC/ClsIFACLivre/ClsIFACLivre/SelectLivreByTitreResponse")]
        System.IAsyncResult BeginSelectLivreByTitre(string Titre, System.AsyncCallback callback, object asyncState);
        
        System.Collections.Generic.List<COUCHEBO.ClsBOLivre> EndSelectLivreByTitre(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(Action="COUCHEIFAC/ClsIFACLivre/ClsIFACLivre/SelectLivreByISBN", ReplyAction="COUCHEIFAC/ClsIFACLivre/ClsIFACLivre/SelectLivreByISBNResponse")]
        System.Collections.Generic.List<COUCHEBO.ClsBOLivre> SelectLivreByISBN(string ISBN);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="COUCHEIFAC/ClsIFACLivre/ClsIFACLivre/SelectLivreByISBN", ReplyAction="COUCHEIFAC/ClsIFACLivre/ClsIFACLivre/SelectLivreByISBNResponse")]
        System.IAsyncResult BeginSelectLivreByISBN(string ISBN, System.AsyncCallback callback, object asyncState);
        
        System.Collections.Generic.List<COUCHEBO.ClsBOLivre> EndSelectLivreByISBN(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(Action="COUCHEIFAC/ClsIFACLivre/ClsIFACLivre/AddLivre", ReplyAction="COUCHEIFAC/ClsIFACLivre/ClsIFACLivre/AddLivreResponse")]
        COUCHEBO.ClsBOLivre AddLivre(string ISBN, string Titre, int Genre_ID, byte[] Cover, int Biblio_ID, int Auteur_ID);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="COUCHEIFAC/ClsIFACLivre/ClsIFACLivre/AddLivre", ReplyAction="COUCHEIFAC/ClsIFACLivre/ClsIFACLivre/AddLivreResponse")]
        System.IAsyncResult BeginAddLivre(string ISBN, string Titre, int Genre_ID, byte[] Cover, int Biblio_ID, int Auteur_ID, System.AsyncCallback callback, object asyncState);
        
        COUCHEBO.ClsBOLivre EndAddLivre(System.IAsyncResult result);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ClsIFACLivreChannel : Bibliotheque.Proxies.ClsIFACLivre, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ClsIFACLivreClient : System.ServiceModel.ClientBase<Bibliotheque.Proxies.ClsIFACLivre>, Bibliotheque.Proxies.ClsIFACLivre
    {
        
        public ClsIFACLivreClient()
        {
        }
        
        public ClsIFACLivreClient(string endpointConfigurationName) : 
                base(endpointConfigurationName)
        {
        }
        
        public ClsIFACLivreClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress)
        {
        }
        
        public ClsIFACLivreClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress)
        {
        }
        
        public ClsIFACLivreClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Collections.Generic.List<COUCHEBO.ClsBOLivre> SelectAllLivre()
        {
            return base.Channel.SelectAllLivre();
        }
        
        public System.IAsyncResult BeginSelectAllLivre(System.AsyncCallback callback, object asyncState)
        {
            return base.Channel.BeginSelectAllLivre(callback, asyncState);
        }
        
        public System.Collections.Generic.List<COUCHEBO.ClsBOLivre> EndSelectAllLivre(System.IAsyncResult result)
        {
            return base.Channel.EndSelectAllLivre(result);
        }
        
        public System.Collections.Generic.List<COUCHEBO.ClsBOLivre> SelectLivreByTitre(string Titre)
        {
            return base.Channel.SelectLivreByTitre(Titre);
        }
        
        public System.IAsyncResult BeginSelectLivreByTitre(string Titre, System.AsyncCallback callback, object asyncState)
        {
            return base.Channel.BeginSelectLivreByTitre(Titre, callback, asyncState);
        }
        
        public System.Collections.Generic.List<COUCHEBO.ClsBOLivre> EndSelectLivreByTitre(System.IAsyncResult result)
        {
            return base.Channel.EndSelectLivreByTitre(result);
        }
        
        public System.Collections.Generic.List<COUCHEBO.ClsBOLivre> SelectLivreByISBN(string ISBN)
        {
            return base.Channel.SelectLivreByISBN(ISBN);
        }
        
        public System.IAsyncResult BeginSelectLivreByISBN(string ISBN, System.AsyncCallback callback, object asyncState)
        {
            return base.Channel.BeginSelectLivreByISBN(ISBN, callback, asyncState);
        }
        
        public System.Collections.Generic.List<COUCHEBO.ClsBOLivre> EndSelectLivreByISBN(System.IAsyncResult result)
        {
            return base.Channel.EndSelectLivreByISBN(result);
        }
        
        public COUCHEBO.ClsBOLivre AddLivre(string ISBN, string Titre, int Genre_ID, byte[] Cover, int Biblio_ID, int Auteur_ID)
        {
            return base.Channel.AddLivre(ISBN, Titre, Genre_ID, Cover, Biblio_ID, Auteur_ID);
        }
        
        public System.IAsyncResult BeginAddLivre(string ISBN, string Titre, int Genre_ID, byte[] Cover, int Biblio_ID, int Auteur_ID, System.AsyncCallback callback, object asyncState)
        {
            return base.Channel.BeginAddLivre(ISBN, Titre, Genre_ID, Cover, Biblio_ID, Auteur_ID, callback, asyncState);
        }
        
        public COUCHEBO.ClsBOLivre EndAddLivre(System.IAsyncResult result)
        {
            return base.Channel.EndAddLivre(result);
        }
    }
}
