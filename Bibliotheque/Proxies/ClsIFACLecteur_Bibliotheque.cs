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
    [System.ServiceModel.ServiceContractAttribute(Namespace="COUCHEIFAC/ClsIFACLecteur_Bibliotheque", ConfigurationName="Bibliotheque.Proxies.ClsIFACLecteur_Bibliotheque")]
    public interface ClsIFACLecteur_Bibliotheque
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="COUCHEIFAC/ClsIFACLecteur_Bibliotheque/ClsIFACLecteur_Bibliotheque/SelectAllLecte" +
            "urBiblio", ReplyAction="COUCHEIFAC/ClsIFACLecteur_Bibliotheque/ClsIFACLecteur_Bibliotheque/SelectAllLecte" +
            "urBiblioResponse")]
        System.Collections.Generic.List<COUCHEBO.ClsBOLecteur_Bibliotheque> SelectAllLecteurBiblio();
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="COUCHEIFAC/ClsIFACLecteur_Bibliotheque/ClsIFACLecteur_Bibliotheque/SelectAllLecte" +
            "urBiblio", ReplyAction="COUCHEIFAC/ClsIFACLecteur_Bibliotheque/ClsIFACLecteur_Bibliotheque/SelectAllLecte" +
            "urBiblioResponse")]
        System.IAsyncResult BeginSelectAllLecteurBiblio(System.AsyncCallback callback, object asyncState);
        
        System.Collections.Generic.List<COUCHEBO.ClsBOLecteur_Bibliotheque> EndSelectAllLecteurBiblio(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(Action="COUCHEIFAC/ClsIFACLecteur_Bibliotheque/ClsIFACLecteur_Bibliotheque/SelectLecteurB" +
            "iblioByLecteurID", ReplyAction="COUCHEIFAC/ClsIFACLecteur_Bibliotheque/ClsIFACLecteur_Bibliotheque/SelectLecteurB" +
            "iblioByLecteurIDResponse")]
        COUCHEBO.ClsBOLecteur_Bibliotheque SelectLecteurBiblioByLecteurID(int Lecteur_ID);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="COUCHEIFAC/ClsIFACLecteur_Bibliotheque/ClsIFACLecteur_Bibliotheque/SelectLecteurB" +
            "iblioByLecteurID", ReplyAction="COUCHEIFAC/ClsIFACLecteur_Bibliotheque/ClsIFACLecteur_Bibliotheque/SelectLecteurB" +
            "iblioByLecteurIDResponse")]
        System.IAsyncResult BeginSelectLecteurBiblioByLecteurID(int Lecteur_ID, System.AsyncCallback callback, object asyncState);
        
        COUCHEBO.ClsBOLecteur_Bibliotheque EndSelectLecteurBiblioByLecteurID(System.IAsyncResult result);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ClsIFACLecteur_BibliothequeChannel : Bibliotheque.Proxies.ClsIFACLecteur_Bibliotheque, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ClsIFACLecteur_BibliothequeClient : System.ServiceModel.ClientBase<Bibliotheque.Proxies.ClsIFACLecteur_Bibliotheque>, Bibliotheque.Proxies.ClsIFACLecteur_Bibliotheque
    {
        
        public ClsIFACLecteur_BibliothequeClient()
        {
        }
        
        public ClsIFACLecteur_BibliothequeClient(string endpointConfigurationName) : 
                base(endpointConfigurationName)
        {
        }
        
        public ClsIFACLecteur_BibliothequeClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress)
        {
        }
        
        public ClsIFACLecteur_BibliothequeClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress)
        {
        }
        
        public ClsIFACLecteur_BibliothequeClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Collections.Generic.List<COUCHEBO.ClsBOLecteur_Bibliotheque> SelectAllLecteurBiblio()
        {
            return base.Channel.SelectAllLecteurBiblio();
        }
        
        public System.IAsyncResult BeginSelectAllLecteurBiblio(System.AsyncCallback callback, object asyncState)
        {
            return base.Channel.BeginSelectAllLecteurBiblio(callback, asyncState);
        }
        
        public System.Collections.Generic.List<COUCHEBO.ClsBOLecteur_Bibliotheque> EndSelectAllLecteurBiblio(System.IAsyncResult result)
        {
            return base.Channel.EndSelectAllLecteurBiblio(result);
        }
        
        public COUCHEBO.ClsBOLecteur_Bibliotheque SelectLecteurBiblioByLecteurID(int Lecteur_ID)
        {
            return base.Channel.SelectLecteurBiblioByLecteurID(Lecteur_ID);
        }
        
        public System.IAsyncResult BeginSelectLecteurBiblioByLecteurID(int Lecteur_ID, System.AsyncCallback callback, object asyncState)
        {
            return base.Channel.BeginSelectLecteurBiblioByLecteurID(Lecteur_ID, callback, asyncState);
        }
        
        public COUCHEBO.ClsBOLecteur_Bibliotheque EndSelectLecteurBiblioByLecteurID(System.IAsyncResult result)
        {
            return base.Channel.EndSelectLecteurBiblioByLecteurID(result);
        }
    }
}
