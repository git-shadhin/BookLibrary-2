using System;
using System.ServiceModel;
using COUCHEFAC;

namespace HOST
{
    class Server
    {
        internal static ServiceHost ServiceLecteur = null;
        internal static ServiceHost ServiceBibliotheque = null;
        internal static ServiceHost ServiceLivre = null;
        internal static ServiceHost ServiceAuteur = null;
        internal static ServiceHost ServiceGenre = null;
        internal static ServiceHost ServiceExemplaire = null;
        internal static ServiceHost ServiceEtat = null;
        internal static ServiceHost ServiceEmprunt = null;
        internal static ServiceHost ServiceReservation = null;
        internal static ServiceHost ServicePersonne = null;

        internal static ServiceHost ServiceLivre_Auteur = null;
        internal static ServiceHost ServiceLecteur_Bibliotheque = null;
        internal static ServiceHost ServiceGestion_Bibliotheque = null;
        

        public void StartService()
        {
            ServiceLecteur = new ServiceHost(typeof(ClsFACLecteur));
            ServiceLecteur.Open();
            Console.WriteLine("Service : Lecteur Started - " + typeof(ClsFACLecteur));

            ServiceBibliotheque = new ServiceHost(typeof(ClsFACBiblio));
            ServiceBibliotheque.Open();
            Console.WriteLine("Service : Bibliotheque Started - " + typeof(ClsFACBiblio));

            ServiceLivre = new ServiceHost(typeof(ClsFACLivre));
            ServiceLivre.Open();
            Console.WriteLine("Service : Livre Started - " + typeof(ClsFACLivre));

            ServiceAuteur = new ServiceHost(typeof(ClsFACAuteur));
            ServiceAuteur.Open();
            Console.WriteLine("Service : Auteur Started - " + typeof(ClsFACAuteur));

            ServiceGenre = new ServiceHost(typeof(ClsFACGenre));
            ServiceGenre.Open();
            Console.WriteLine("Service : Genre Started - " + typeof(ClsFACGenre));

            ServiceExemplaire = new ServiceHost(typeof(ClsFACExemp));
            ServiceExemplaire.Open();
            Console.WriteLine("Service : Exemplaire Started - " + typeof(ClsFACExemp));

            ServiceEtat = new ServiceHost(typeof(ClsFACEtat));
            ServiceEtat.Open();
            Console.WriteLine("Service : Etat Started - " + typeof(ClsFACEtat));

            ServiceEmprunt = new ServiceHost(typeof(ClsFACEmprunt));
            ServiceEmprunt.Open();
            Console.WriteLine("Service : Emprunt Started - " + typeof(ClsFACEmprunt));

            ServiceReservation = new ServiceHost(typeof(ClsFACReservation));
            ServiceReservation.Open();
            Console.WriteLine("Service : Reservation Started - " + typeof(ClsFACReservation));

            ServicePersonne = new ServiceHost(typeof(ClsFACPersonne));
            ServicePersonne.Open();
            Console.WriteLine("Service : Personne Started - " + typeof(ClsFACPersonne));

            
            ServiceLivre_Auteur = new ServiceHost(typeof(ClsFACLivre_Auteur));
            ServiceLivre_Auteur.Open();
            Console.WriteLine("Service : Livre_Auteur Started - " + typeof(ClsFACLivre_Auteur));

            ServiceLecteur_Bibliotheque = new ServiceHost(typeof(ClsFACLecteur_Bibliotheque));
            ServiceLecteur_Bibliotheque.Open();
            Console.WriteLine("Service : Lecteur_Bibliotheque Started - " + typeof(ClsFACLecteur_Bibliotheque));

            ServiceGestion_Bibliotheque = new ServiceHost(typeof(ClsFACGestion_Bibliotheque));
            ServiceGestion_Bibliotheque.Open();
            Console.WriteLine("Service : Gestion_Bibliotheque Started - " + typeof(ClsFACGestion_Bibliotheque));
        }


        public void StopService()
        {
            if (ServiceLecteur != null && ServiceLecteur.State != CommunicationState.Closed)
                ServiceLecteur.Close();

            if (ServiceBibliotheque != null && ServiceBibliotheque.State != CommunicationState.Closed)
                ServiceBibliotheque.Close();

            if (ServiceLivre != null && ServiceLivre.State != CommunicationState.Closed)
                ServiceLivre.Close();

            if (ServiceAuteur != null && ServiceAuteur.State != CommunicationState.Closed)
                ServiceAuteur.Close();

            if (ServiceGenre != null && ServiceGenre.State != CommunicationState.Closed)
                ServiceGenre.Close();

            if (ServiceExemplaire != null && ServiceExemplaire.State != CommunicationState.Closed)
                ServiceExemplaire.Close();

            if (ServiceEtat != null && ServiceEtat.State != CommunicationState.Closed)
                ServiceEtat.Close();

            if (ServiceEmprunt != null && ServiceEmprunt.State != CommunicationState.Closed)
                ServiceEmprunt.Close();

            if (ServiceReservation != null && ServiceReservation.State != CommunicationState.Closed)
                ServiceReservation.Close();

            if (ServicePersonne != null && ServicePersonne.State != CommunicationState.Closed)
                ServicePersonne.Close();


            if (ServiceLivre_Auteur != null && ServiceLivre_Auteur.State != CommunicationState.Closed)
                ServiceLivre_Auteur.Close();

            if (ServiceLecteur_Bibliotheque != null && ServiceLecteur_Bibliotheque.State != CommunicationState.Closed)
                ServiceLecteur_Bibliotheque.Close();

            if (ServiceGestion_Bibliotheque != null && ServiceGestion_Bibliotheque.State != CommunicationState.Closed)
                ServiceGestion_Bibliotheque.Close();
        }
    }
}
