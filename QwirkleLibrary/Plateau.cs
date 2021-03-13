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
                    SetCase(i, j, init);                }
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


        public static bool ComparaisonTuileGauche(int PositionX, int PositionY)
        {
            bool valide = false;
            char[] tableau = RecupAutourTuile(PositionX, PositionY);
            if ((tableau[8] == tableau[0]) && (tableau[9] != tableau[1])) // compare la couleur  de la tuile a la tuile de gauche
            {
                valide = true;
            }
            else
            {
                if ((tableau[9] == tableau[1]) && (tableau[8] != tableau[0])) // Compare la forme de la tuile a la tuile de gauche
                {
                    valide = true;
                }
            }
            return valide;
        }

        public static bool ComparisonTuileDroite(int PositionX, int PositionY)
        {
            bool valide = false;
            char[] tableau = RecupAutourTuile(PositionX, PositionY);
            if ((tableau[8] == tableau[2]) && (tableau[9] != tableau[3])) // compare la couleur  de la tuile a la tuile de droite
            {
                valide = true;
            }
            else
            {
                if ((tableau[9] == tableau[3]) && (tableau[8] != tableau[2])) // Compare la forme de la tuile a la tuile de droite
                {
                    valide = true;
                }
            }
            return valide;
        }

        public static bool ComparaisonTuileHaut(int PositionX, int PositionY)
        {
            bool valide = false;
            char[] tableau = RecupAutourTuile(PositionX, PositionY);

            if ((tableau[8] == tableau[4]) && (tableau[9] != tableau[5])) // compare la couleur  de la tuile a la tuile en haut
            {
                valide = true;
            }
            else
            {
                if ((tableau[9] == tableau[5]) && (tableau[8] != tableau[4])) // Compare la forme de la tuile a la tuile en haut
                {
                    valide = true;
                }
            }
            return valide;
        }

        public static bool ComparaisonTuileBas(int PositionX, int PositionY)
        {
            bool valide = false;
            char[] tableau = RecupAutourTuile(PositionX, PositionY);
            if ((tableau[8] == tableau[6]) && (tableau[9] != tableau[7])) // compare la couleur  de la tuile a la tuile en bas
            {
                valide = true;
            }
            else
            {
                if ((tableau[9] == tableau[7]) && (tableau[8] != tableau[6])) // Compare la forme de la tuile a la tuile en bas
                {
                    valide = true;
                }
            }
            return valide;
        }

        public static bool ValiderPlacement(int PositionX, int PositionY, Tuile tuile)
        {
            bool bonne_ligne = false;

            if (ComparaisonTuileGauche(PositionX, PositionY) == true)
            {
                bonne_ligne = true;
            }
            else
            {
                if (ComparaisonTuileHaut(PositionX, PositionY) == true)
                {
                    bonne_ligne = true;
                }
                else
                {
                    if (ComparisonTuileDroite(PositionX, PositionY) == true)
                    {
                        bonne_ligne = true;
                    }
                    else
                    {
                        if (ComparaisonTuileBas(PositionX, PositionY) == true)
                        {
                            bonne_ligne = true;
                        }
                        else
                        {
                            bonne_ligne = false;
                        }
                    }
                }
            }

            if (bonne_ligne == true)
                return bonne_ligne;
            else
                return false;
        }

        public static int CalculScore(int PositionX, int PositionY)
        {
            int score = 0;
            int scoreligneX = 0;
            int scoreligneY = 0;
            int testpositionX = PositionX;
            int testpositionY = PositionY;


            if ((PositionY - 1 >= 0) && (GetCase(PositionX, PositionY - 1).GetCouleur() != ' '))
            {
                    testpositionX = PositionX;
                    testpositionY = PositionY;
                    testpositionY--;
                    while ((testpositionY >= 0) && (GetCase(testpositionX, testpositionY).GetCouleur() != ' '))
                    {
                        scoreligneY++;
                        testpositionY--;
                    }
                    testpositionX = PositionX;
                    testpositionY = PositionY;
            } //on ne teste que les couleurs car par principe, tous pions à couleur a forcemment une forme dans ce cas précis

            if ((PositionY + 1 <=19) && (GetCase(PositionX, PositionY + 1).GetCouleur() != ' '))
            {
                testpositionX = PositionX;
                testpositionY = PositionY;
                testpositionY++;
                while ((testpositionY <= 19) && (GetCase(testpositionX, testpositionY).GetCouleur() != ' '))
                {
                    scoreligneY++;
                    testpositionY++;
                }
                testpositionX = PositionX;
                testpositionY = PositionY;
            }

            if ((PositionX - 1 >= 0) && (GetCase(PositionX - 1, PositionY).GetCouleur() != ' '))
            {
                testpositionX = PositionX;
                testpositionY = PositionY;
                testpositionX--;
                while ((testpositionX >= 0) && (GetCase(testpositionX, testpositionY).GetCouleur() != ' '))
                {
                    scoreligneX++;
                    testpositionX--;
                }
                testpositionX = PositionX;
                testpositionY = PositionY;
            }

            if ((PositionX + 1 <+ 19) && (GetCase(PositionX + 1, PositionY).GetCouleur() != ' '))
            {
                testpositionX = PositionX;
                testpositionY = PositionY;
                testpositionX++;
                while ((testpositionX <= 19) && (GetCase(testpositionX, testpositionY).GetCouleur() != ' '))
                {
                    scoreligneX++;
                    testpositionX++;
                }
                testpositionX = PositionX;
                testpositionY = PositionY;
            }


            if (scoreligneX !=0) //s'il y a des pions sur cette ligne, il faut bien compter le pion qu'on pose
            {
                scoreligneX++;
            }

            if (scoreligneY != 0) //idem
            {
                scoreligneY++;
            }

            if (scoreligneY == 6)
            {
                scoreligneY = scoreligneY + 6;
            }

            if (scoreligneX == 6)
            {
                scoreligneX = scoreligneX + 6;
            }

            score = scoreligneX + scoreligneY;
            return score;
        }
    }
}
