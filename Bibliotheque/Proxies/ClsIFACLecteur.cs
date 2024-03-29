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
    [System.ServiceModel.ServiceContractAttribute(Namespace="COUCHEIFAC/ClsIFACLecteur", ConfigurationName="Bibliotheque.Proxies.ClsIFACLecteur")]
    public interface ClsIFACLecteur
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="COUCHEIFAC/ClsIFACLecteur/ClsIFACLecteur/SelectAllLecteur", ReplyAction="COUCHEIFAC/ClsIFACLecteur/ClsIFACLecteur/SelectAllLecteurResponse")]
        System.Collections.Generic.List<COUCHEBO.ClsBOLecteur> SelectAllLecteur();
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="COUCHEIFAC/ClsIFACLecteur/ClsIFACLecteur/SelectAllLecteur", ReplyAction="COUCHEIFAC/ClsIFACLecteur/ClsIFACLecteur/SelectAllLecteurResponse")]
        System.IAsyncResult BeginSelectAllLecteur(System.AsyncCallback callback, object asyncState);
        
        System.Collections.Generic.List<COUCHEBO.ClsBOLecteur> EndSelectAllLecteur(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(Action="COUCHEIFAC/ClsIFACLecteur/ClsIFACLecteur/SelectLecteurByUsername", ReplyAction="COUCHEIFAC/ClsIFACLecteur/ClsIFACLecteur/SelectLecteurByUsernameResponse")]
        System.Collections.Generic.List<COUCHEBO.ClsBOLecteur> SelectLecteurByUsername(string Username);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="COUCHEIFAC/ClsIFACLecteur/ClsIFACLecteur/SelectLecteurByUsername", ReplyAction="COUCHEIFAC/ClsIFACLecteur/ClsIFACLecteur/SelectLecteurByUsernameResponse")]
        System.IAsyncResult BeginSelectLecteurByUsername(string Username, System.AsyncCallback callback, object asyncState);
        
        System.Collections.Generic.List<COUCHEBO.ClsBOLecteur> EndSelectLecteurByUsername(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(Action="COUCHEIFAC/ClsIFACLecteur/ClsIFACLecteur/Login", ReplyAction="COUCHEIFAC/ClsIFACLecteur/ClsIFACLecteur/LoginResponse")]
        COUCHEBO.ClsBOLecteur Login(string Username, string Password);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="COUCHEIFAC/ClsIFACLecteur/ClsIFACLecteur/Login", ReplyAction="COUCHEIFAC/ClsIFACLecteur/ClsIFACLecteur/LoginResponse")]
        System.IAsyncResult BeginLogin(string Username, string Password, System.AsyncCallback callback, object asyncState);
        
        COUCHEBO.ClsBOLecteur EndLogin(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(Action="COUCHEIFAC/ClsIFACLecteur/ClsIFACLecteur/SelectNb_EmpruntByLecteurID", ReplyAction="COUCHEIFAC/ClsIFACLecteur/ClsIFACLecteur/SelectNb_EmpruntByLecteurIDResponse")]
        COUCHEBO.ClsBOLecteur SelectNb_EmpruntByLecteurID(int Lecteur_ID);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="COUCHEIFAC/ClsIFACLecteur/ClsIFACLecteur/SelectNb_EmpruntByLecteurID", ReplyAction="COUCHEIFAC/ClsIFACLecteur/ClsIFACLecteur/SelectNb_EmpruntByLecteurIDResponse")]
        System.IAsyncResult BeginSelectNb_EmpruntByLecteurID(int Lecteur_ID, System.AsyncCallback callback, object asyncState);
        
        COUCHEBO.ClsBOLecteur EndSelectNb_EmpruntByLecteurID(System.IAsyncResult result);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ClsIFACLecteurChannel : Bibliotheque.Proxies.ClsIFACLecteur, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ClsIFACLecteurClient : System.ServiceModel.ClientBase<Bibliotheque.Proxies.ClsIFACLecteur>, Bibliotheque.Proxies.ClsIFACLecteur
    {
        
        public ClsIFACLecteurClient()
        {
        }
        
        public ClsIFACLecteurClient(string endpointConfigurationName) : 
                base(endpointConfigurationName)
        {
        }
        
        public ClsIFACLecteurClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress)
        {
        }
        
        public ClsIFACLecteurClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress)
        {
        }
        
        public ClsIFACLecteurClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Collections.Generic.List<COUCHEBO.ClsBOLecteur> SelectAllLecteur()
        {
            return base.Channel.SelectAllLecteur();
        }
        
        public System.IAsyncResult BeginSelectAllLecteur(System.AsyncCallback callback, object asyncState)
        {
            return base.Channel.BeginSelectAllLecteur(callback, asyncState);
        }
        
        public System.Collections.Generic.List<COUCHEBO.ClsBOLecteur> EndSelectAllLecteur(System.IAsyncResult result)
        {
            return base.Channel.EndSelectAllLecteur(result);
        }
        
        public System.Collections.Generic.List<COUCHEBO.ClsBOLecteur> SelectLecteurByUsername(string Username)
        {
            return base.Channel.SelectLecteurByUsername(Username);
        }
        
        public System.IAsyncResult BeginSelectLecteurByUsername(string Username, System.AsyncCallback callback, object asyncState)
        {
            return base.Channel.BeginSelectLecteurByUsername(Username, callback, asyncState);
        }
        
        public System.Collections.Generic.List<COUCHEBO.ClsBOLecteur> EndSelectLecteurByUsername(System.IAsyncResult result)
        {
            return base.Channel.EndSelectLecteurByUsername(result);
        }
        
        public COUCHEBO.ClsBOLecteur Login(string Username, string Password)
        {
            return base.Channel.Login(Username, Password);
        }
        
        public System.IAsyncResult BeginLogin(string Username, string Password, System.AsyncCallback callback, object asyncState)
        {
            return base.Channel.BeginLogin(Username, Password, callback, asyncState);
        }
        
        public COUCHEBO.ClsBOLecteur EndLogin(System.IAsyncResult result)
        {
            return base.Channel.EndLogin(result);
        }
        
        public COUCHEBO.ClsBOLecteur SelectNb_EmpruntByLecteurID(int Lecteur_ID)
        {
            return base.Channel.SelectNb_EmpruntByLecteurID(Lecteur_ID);
        }
        
        public System.IAsyncResult BeginSelectNb_EmpruntByLecteurID(int Lecteur_ID, System.AsyncCallback callback, object asyncState)
        {
            return base.Channel.BeginSelectNb_EmpruntByLecteurID(Lecteur_ID, callback, asyncState);
        }
        
        public COUCHEBO.ClsBOLecteur EndSelectNb_EmpruntByLecteurID(System.IAsyncResult result)
        {
            return base.Channel.EndSelectNb_EmpruntByLecteurID(result);
        }
    }
}
