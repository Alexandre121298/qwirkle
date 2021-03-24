using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace QwirkleLibrary
{
    public static class Plateau
    {
        public static Tuile[,] plateau = new Tuile[20, 20];
        public static bool findepartie = false;
        public static bool pose_finie = false;
        public static Joueur joueur1 = new Joueur("",1);
        public static Joueur joueur2 = new Joueur("",2);
        public static Joueur joueur3 = new Joueur("",3);
        public static Joueur joueur4 = new Joueur("",4);
        public static string directory = Directory.GetCurrentDirectory();

        //Methode - Getters et Setters

        public static string GetDirectory()
        {
            return directory;
        }
        public static bool GetPose_Finie()
        {
            return pose_finie;
        }
        public static void SetPose_Finie(bool result)
        {
            pose_finie = result;
        }
        public static void SetFinDePartie(bool result)
        {
            findepartie = result;

        }

        public static bool GetFinDePartie()
        {
            return findepartie;

        }
        public static Tuile GetCase(int PositionX, int PositionY)
        {
            return plateau[PositionX, PositionY];

        }

        public static void SetCase(int positionX, int positionY, Tuile tuile)
        {
            plateau[positionX, positionY] = tuile;
        }


        //Methode - autre


        public static void Init()
        {
            Tuile init = new Tuile(' ',' ', @"");
            for (int i=0;i<20;i++)
            {
                for(int j=0;j<20;j++)
                {
                    SetCase(i, j, init);                
                }
            }
        }

        //Recupere les données autour de la tuile dans un tableau que l'on va renvoyé 
        public static char[] RecupAutourTuile(int PositionX, int PositionY)
        {
            char[] Donnee = new char[10];
            if ((PositionX - 1 >= 0) || (PositionX + 1 >= 0) || (PositionY - 1 >= 0) || (PositionY + 1 >= 0))
            {
                Donnee[0] = GetCase(PositionX - 1, PositionY).GetCouleur(); // Doit prendre les donnees de la tuile a gauche de celle qu'on veux poser
                Donnee[1] = GetCase(PositionX - 1, PositionY).GetForme();
                Donnee[2] = GetCase(PositionX + 1, PositionY).GetCouleur(); // Doit prendre les donnees de la tuile a droite de celle qu'on veux poser
                Donnee[3] = GetCase(PositionX + 1, PositionY).GetForme();
                Donnee[4] = GetCase(PositionX, PositionY - 1).GetCouleur();// Doit prendre les donnees de la tuile en haut de celle qu'on veux poser
                Donnee[5] = GetCase(PositionX, PositionY - 1).GetForme();
                Donnee[6] = GetCase(PositionX, PositionY + 1).GetCouleur();// Doit prendre les donnees de la tuile en bas de celle qu'on veux poser
                Donnee[7] = GetCase(PositionX, PositionY + 1).GetForme();
                Donnee[8] = GetCase(PositionX, PositionY).GetCouleur(); // doit prendre les donnees de la tuile que l'on veux posée
                Donnee[9] = GetCase(PositionX, PositionY).GetForme();
            }
            return Donnee;
        }

        //public static bool PremiereTuile(int PositionX, int PositionY, Tuile tuile)
        //{
        //    bool valide = true;
        //    char[] Donnee = new char[10];
        //    Donnee = RecupAutourTuile(PositionX, PositionY);

        //    if((Donnee[0] != ' ') || (Donnee[2] != ' ') || (Donnee [4] != ' ') || (Donnee[6] != ' '))
        //    {
        //        valide = false;
        //    }
        //    return valide;
        //}

        //public static bool ValiderPlacement(int PositionX, int PositionY, Tuile tuile)
        //{
        //    bool valide = false;

        //    if((GetCase(PositionX-1,PositionY).GetCouleur() == ' ') && (GetCase(PositionX + 1, PositionY).GetCouleur() == ' ') && (GetCase(PositionX, PositionY - 1).GetCouleur() == ' ') && (GetCase(PositionX, PositionY +1).GetCouleur() == ' '))
        //    {
        //        valide = true;
        //    }
        //    return valide;
        //}

        public static bool ValiderPlacement(int PositionX, int PositionY, Tuile tuile)
        {
            char forme = tuile.GetForme();
            char couleur = tuile.GetCouleur();
            bool bonne_ligne = false;
            int testpositionX = PositionX; //reprend la position actuelle de la tuile pour pouvoir la manipuler et checker les tuiles alentours
            int testpositionY = PositionY;
            char testX = 'A';  //lettre au hasard, non existante en code couleur ou forme . Si elle change alors ça indique quel indice il faut tester
            char testY = 'A';
            int Nb_pions_lignesX = 0;
            int Nb_pions_lignesY = 0;

            if (GetCase(PositionX, PositionY).GetCouleur() != ' ') //s'il retourne une couleur, il possède normalement aussi une forme donc aucun besoin de tester. Idem pour les autres tests
            {
                return false;
            }

            if ((PositionY - 1 >= 0) && (GetCase(PositionX, PositionY - 1).GetCouleur() != ' ')) //Test si case au dessus valide, et si case au dessus
            {
                if ((GetCase(testpositionX, testpositionY - 1).GetCouleur() != couleur) && (GetCase(testpositionX, testpositionY - 1).GetForme() != forme))  //test si couleur et forme différentes
                {
                    return false;
                }

                if (GetCase(testpositionX, testpositionY - 1).GetCouleur() == couleur) // test si même couleur
                {
                    if (testY == 'A')
                    {
                        testY = couleur;
                    }
                    else
                    {
                        if (testY != couleur)
                        {
                            return false;
                        }
                    }

                    testpositionX = PositionX;
                    testpositionY = PositionY;
                    testpositionY--;
                    while ((testpositionY >= 0) && (GetCase(testpositionX, testpositionY).GetCouleur() != ' ') && (testpositionY >= PositionY - 5))
                    {
                        Nb_pions_lignesY++;
                        if ((GetCase(testpositionX, testpositionY).GetCouleur() != testY) || (GetCase(testpositionX, testpositionY).GetForme() == forme) || (Nb_pions_lignesY > 5))
                        {
                            return false;
                        }
                        testpositionY--;
                    }
                    if ((testpositionY >= 0) && (GetCase(testpositionX, testpositionY).GetCouleur() != ' '))
                    {
                        return false;
                    }
                }
                testpositionX = PositionX;
                testpositionY = PositionY;

                if (GetCase(testpositionX, testpositionY - 1).GetForme() == forme) //test si même forme
                {
                    if (testY == 'A')
                    {
                        testY = forme;
                    }
                    else
                    {
                        if (testY != forme)
                        {
                            return false;
                        }
                    }
                    testpositionX = PositionX;
                    testpositionY = PositionY;
                    testpositionY--;
                    while ((testpositionY >= 0) && (GetCase(testpositionX, testpositionY).GetCouleur() != ' ') && (testpositionY >= PositionY - 5))
                    {
                        Nb_pions_lignesY++;
                        if ((GetCase(testpositionX, testpositionY).GetForme() != testY) || (GetCase(testpositionX, testpositionY).GetCouleur() == couleur) || (Nb_pions_lignesY++ > 5))
                        {
                            return false;
                        }
                        testpositionY--;
                    }
                    if ((testpositionY >= 0) && (GetCase(testpositionX, testpositionY).GetCouleur() != ' '))
                    {
                        return false;
                    }
                }
                bonne_ligne = true;
                testpositionX = PositionX;
                testpositionY = PositionY;
            }

            if ((PositionY + 1 <= 19) && (GetCase(PositionX, PositionY + 1).GetCouleur() != ' ')) // Test si case en dessous
            {
                if ((GetCase(testpositionX, testpositionY + 1).GetCouleur() != couleur) && (GetCase(testpositionX, testpositionY + 1).GetForme() != forme))  //test si couleur et forme différentes
                {
                    return false;
                }

                if (GetCase(testpositionX, testpositionY + 1).GetCouleur() == couleur) // test si même couleur
                {
                    if (testY == 'A')
                    {
                        testY = couleur;
                    }
                    else
                    {
                        if (testY != couleur)
                        {
                            return false;
                        }
                    }
                    testpositionX = PositionX;
                    testpositionY = PositionY;
                    testpositionY++;
                    while ((testpositionY <= 19) && (GetCase(testpositionX, testpositionY).GetCouleur() != ' ') && (testpositionY <= PositionY + 5))
                    {
                        Nb_pions_lignesY++;
                        if ((GetCase(testpositionX, testpositionY).GetCouleur() != testY) || (GetCase(testpositionX, testpositionY).GetForme() == forme) || (Nb_pions_lignesY > 5))
                        {
                            return false;
                        }
                        testpositionY++;
                    }
                    if ((testpositionY <= 19) && (GetCase(testpositionX, testpositionY).GetCouleur() != ' '))
                    {
                        return false;
                    }
                }
                testpositionX = PositionX;
                testpositionY = PositionY;

                if (GetCase(testpositionX, testpositionY + 1).GetForme() == forme) //test si même forme
                {
                    if (testY == 'A')
                    {
                        testY = forme;
                    }
                    else
                    {
                        if (testY != forme)
                        {
                            return false;
                        }
                    }
                    testpositionX = PositionX;
                    testpositionY = PositionY;
                    testpositionY++;
                    while ((testpositionY <= 19) && (GetCase(testpositionX, testpositionY).GetCouleur() != ' ') && (testpositionY <= PositionY + 5))
                    {
                        Nb_pions_lignesY++;
                        if ((GetCase(testpositionX, testpositionY).GetForme() != testY) || (GetCase(testpositionX, testpositionY).GetCouleur() == couleur) || (Nb_pions_lignesY > 5))
                        {
                            return false;
                        }
                        testpositionY++;
                    }
                    if ((testpositionY <= 19) && (GetCase(testpositionX, testpositionY).GetCouleur() != ' '))
                    {
                        return false;
                    }
                }
                bonne_ligne = true;
                testpositionX = PositionX;
                testpositionY = PositionY;
            }

            if ((PositionX - 1 >= 0) && (GetCase(PositionX - 1, PositionY).GetCouleur() != ' ')) //Test si case à gauche
            {
                if ((GetCase(testpositionX - 1, testpositionY).GetCouleur() != couleur) && (GetCase(testpositionX - 1, testpositionY).GetForme() != forme))  //test si couleur et forme différentes
                {
                    return false;
                }

                if (GetCase(testpositionX - 1, testpositionY).GetCouleur() == couleur) // test si même couleur
                {
                    if (testX == 'A')
                    {
                        testX = couleur;
                    }
                    else
                    {
                        if (testX != couleur)
                        {
                            return false;
                        }
                    }
                    testpositionX = PositionX;
                    testpositionY = PositionY;
                    testpositionX--;
                    while ((testpositionX >= 0) && (GetCase(testpositionX, testpositionY).GetCouleur() != ' ') && (testpositionX >= PositionX - 5))
                    {
                        Nb_pions_lignesX++;
                        if ((GetCase(testpositionX, testpositionY).GetCouleur() != testX) || (GetCase(testpositionX, testpositionY).GetForme() == forme) || (Nb_pions_lignesX > 5))
                        {
                            return false;
                        }
                        testpositionX--;
                    }
                    if ((testpositionX >= 0) && (GetCase(testpositionX, testpositionY).GetCouleur() != ' '))
                    {
                        return false;
                    }
                }
                testpositionX = PositionX;
                testpositionY = PositionY;

                if (GetCase(testpositionX - 1, testpositionY).GetForme() == forme) //test si même forme
                {
                    if (testX == 'A')
                    {
                        testX = forme;
                    }
                    else
                    {
                        if (testX != forme)
                        {
                            return false;
                        }
                    }
                    testpositionX = PositionX;
                    testpositionY = PositionY;
                    testpositionX--;
                    while ((testpositionX >= 0) && (GetCase(testpositionX, testpositionY).GetCouleur() != ' ') && (testpositionX >= PositionX - 5))
                    {
                        Nb_pions_lignesX++;
                        if ((GetCase(testpositionX, testpositionY).GetForme() != testX) || (GetCase(testpositionX, testpositionY).GetCouleur() == couleur) || (Nb_pions_lignesX > 5))
                        {
                            return false;
                        }
                        testpositionX--;
                    }
                    if ((testpositionX >= 0) && (GetCase(testpositionX, testpositionY).GetCouleur() != ' '))
                    {
                        return false;
                    }
                }
                bonne_ligne = true;
                testpositionX = PositionX;
                testpositionY = PositionY;
            }

            if ((PositionX + 1 <= 19) && (GetCase(PositionX + 1, PositionY).GetCouleur() != ' ')) //Test si case à droite
            {
                if ((GetCase(testpositionX + 1, testpositionY).GetCouleur() != couleur) && (GetCase(testpositionX + 1, testpositionY).GetForme() != forme))  //test si couleur et forme différentes
                {
                    return false;
                }

                if (GetCase(testpositionX + 1, testpositionY).GetCouleur() == couleur) // test si même couleur
                {
                    if (testX == 'A')
                    {
                        testX = couleur;
                    }
                    else
                    {
                        if (testX != couleur)
                        {
                            return false;
                        }
                    }
                    testpositionX = PositionX;
                    testpositionY = PositionY;
                    testpositionX++;
                    while ((testpositionX <= 19) && (GetCase(testpositionX, testpositionY).GetCouleur() != ' ') && (testpositionX <= PositionX + 5))
                    {
                        Nb_pions_lignesX++;
                        if ((GetCase(testpositionX, testpositionY).GetCouleur() != testX) || (GetCase(testpositionX, testpositionY).GetForme() == forme) || (Nb_pions_lignesX > 5))
                        {
                            return false;
                        }
                        testpositionX++;
                    }
                    if ((testpositionX <= 19) && (GetCase(testpositionX, testpositionY).GetCouleur() != ' '))
                    {
                        return false;
                    }
                }
                testpositionX = PositionX;
                testpositionY = PositionY;

                if (GetCase(testpositionX + 1, testpositionY).GetForme() == forme) //test si même forme
                {
                    if (testX == 'A')
                    {
                        testX = forme;
                    }
                    else
                    {
                        if (testX != forme)
                        {
                            return false;
                        }
                    }
                    testpositionX = PositionX;
                    testpositionY = PositionY;
                    testpositionX++;
                    while ((testpositionX <= 19) && (GetCase(testpositionX, testpositionY).GetCouleur() != ' ') && (testpositionX <= PositionX + 5))
                    {
                        Nb_pions_lignesX++;
                        if ((GetCase(testpositionX, testpositionY).GetForme() != testX) || (GetCase(testpositionX, testpositionY).GetCouleur() == couleur) || (Nb_pions_lignesX > 5))
                        {
                            return false;
                        }
                        testpositionX++;
                    }
                    if ((testpositionX <= 19) && (GetCase(testpositionX, testpositionY).GetCouleur() != ' '))
                    {
                        return false;
                    }
                }
                bonne_ligne = true;
                testpositionX = PositionX;
                testpositionY = PositionY;
            }

            if (bonne_ligne == true) { return true; } //fin de verification et validation
            else { return false; }

        }
        public static int Score(int PositionX, int PositionY, int JoueurScore)
        {
            int score = JoueurScore;
            int CompteurdetuileDroite = 0;
            int CompteurdetuileGauche = 0;
            int CompteurdetuileHaut = 0;
            int CompteurdetuileBas = 0;
            char[] Donnee = new char[10];
            Donnee = RecupAutourTuile(PositionX, PositionY);

            score++;

            if (Donnee[2] != ' ') //Calcule score ligne a droite de la tuile
            {
                for(int i = 1; i <= 5; i++)
                {
                    if (GetCase(PositionX + i, PositionY).GetCouleur() != ' ')
                    {
                        CompteurdetuileDroite++;
                    }
                }
                if (CompteurdetuileDroite == 5)
                    score = score + 6;
            }


            if (Donnee[0] != ' ') //Calcule score ligne a gauche de la tuile
            {
                for (int i = 1; i <= 5; i++)
                {
                    if (GetCase(PositionX - i, PositionY).GetCouleur() != ' ')
                    {
                        CompteurdetuileGauche++;
                    }
                }
                if (CompteurdetuileGauche == 5)
                    score = score + 6;
            }


            if (Donnee[4] != ' ') //Calcule score ligne en haut de la tuile
            {
                for (int i = 1; i <= 5; i++)
                {
                    if (GetCase(PositionX, PositionY - i).GetCouleur() != ' ')
                    {
                        CompteurdetuileHaut++;
                    }
                }
                if (CompteurdetuileHaut == 5)
                    score = score + 6;
            }


            if (Donnee[6] != ' ') //Calcule score ligne en bas de la tuile
            {
                for (int i = 1; i <= 5; i++)
                {
                    if (GetCase(PositionX, PositionY + i).GetCouleur() != ' ')
                    {
                        CompteurdetuileBas++;
                    }
                }
                if (CompteurdetuileBas == 5)
                    score = score + 6;
            }


            return score;
        }





        //Retour la bonne couleur
        public static char testretourcouleur(int PositionX, int PositionY, Tuile tuile)
        {
            char[] Donnee = new char[10];
            Donnee = RecupAutourTuile(PositionX, PositionY);
            //return Donnee[8];
            return GetCase(PositionX+1, PositionY ).GetForme(); // retourne la couleur a droite
        }


    }
}
