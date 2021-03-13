using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QwirkleLibrary
{
    public class Joueur
    {
        private string name;
        private int score=0;
        private Tuile[] Main = new Tuile[6];
        private int ordre_tour;


        public Joueur(string name,int ordre_tour)
        {
            this.name = name;
            this.ordre_tour = ordre_tour;
        }

        //Méthodes - Geter et Seter

        public int GetOrdre_Tour()
        {
            return this.ordre_tour;
        }

        public int GetScore()
        {
            return this.score;
        }

        public void SetScore(int score)
        {
            this.score = score;
        }

        public string GetName()
        {
            return this.name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public void SetMain(int position,Tuile tuile)
        {
            this.Main[position] = tuile;
        }

        public Tuile GetMain(int position)
        {
            return this.Main[position];
        }

        //Methode - Autres
        public void EnleverTuileMain(int position_tuile)
        {
            this.Main[position_tuile] = null;
        }

        public void AjouterTuileMain()
        {
            for (int compteur=0; compteur<6; compteur++)
            {
                if (this.Main[compteur] is null)
                {
                    Pioche.PiocherCarte(this, compteur);
                }
            }
        }

        public void PlacerTuile(int nb_tuile_en_main, int placementX, int placementY)
        {
            Plateau.SetCase(placementX, placementY, this.GetMain(nb_tuile_en_main));
            this.EnleverTuileMain(nb_tuile_en_main);
        }

        public int TuilesRestantes()
        {
            int nb = 0;
            for (int compteur = 0;compteur<6;compteur++)
            {
                if (this.GetMain(compteur) != null)
                {
                    nb++;
                }
            }

            return nb;
        }


    }
}