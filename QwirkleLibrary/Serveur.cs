using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace QwirkleLibrary
{
    class Serveur
    {
        public static void start(TcpListener listener, Socket s)
        {   
            listener.Start();
            s = listener.AcceptSocket(); //Accepte les clients 
        }

        public static void InitScore()
        {
            Plateau.joueur1.SetScore(0); //Initialise les scores 
            Plateau.joueur2.SetScore(0);
            Plateau.joueur3.SetScore(0);
            Plateau.joueur4.SetScore(0);
        }

        public static void InitNomJoueur()
        {
            Plateau.joueur1.SetName("Test 1"); // Initialise le nom des joueurs 
            Plateau.joueur2.SetName("Test 2");
            Plateau.joueur3.SetName("Test 3");
            Plateau.joueur4.SetName("Test 4");
        }

        public static void InitMainJoueur()
        {
            Plateau.joueur1.AjouterTuileMain(); //Initialise la main des joueurs
            Plateau.joueur2.AjouterTuileMain();
            Plateau.joueur3.AjouterTuileMain();
            Plateau.joueur4.AjouterTuileMain();
        }

        public static int InitTourJeu() //Initialise les tour du jeu 
        {
            int Tour = 0;
            return Tour;
        }

        public static int InitTourJoueur() //Initialise les tour des joueurs
        {
            int Tour_Joueur = 0;
            return Tour_Joueur;
        }
        public static void InitJeu()
        {
            Plateau.Init(); //Initialise le tableau pour le plateau
            Pioche.Init();// Initialise la pioche
            InitScore();
            InitNomJoueur();
            InitMainJoueur();
            InitTourJeu();
            InitTourJoueur();
        }

        public static void retourTableau()
        {
            //Creer un tableau de 20 par 20 vide
            //Clear le tableau avant de prendre le plateau
            //Recupere le plateau dans le tableau
            //Retourne le tableau 
        }

        public static void EnvoieduTableau()
        {
            //Recupere le tableau de la fonction retour Tableau
            //Envoie grace au send le tableau a tous les joueurs 
        }

        public static void BoutonValider()
        {
            //Instruction quand un joueur clique sur le bouton valider
            //Incrementation des tours , tours joueur, scores
            //Envoie du tableau a tous les joueurs
            //Ajout des tuiles dans la main du joueur qui vient de finir son tour 
        }

        public static void Close(Socket s, TcpListener listener)
        {
            s.Close();
            listener.Stop();
        }

        public static void main()
        {
            IPAddress ipAd = IPAddress.Parse("127.0.0.1"); //utilise l'adresse local
            TcpListener Listener = new TcpListener(ipAd, 8001); // Le port est 8001
            Socket s = null;
            try
            {
                start(Listener, s);
                InitJeu();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error ....");
            }

            //If Code de fin de partie
            //Close();
        }
    }
}
