using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QwirkleLibrary
{
    public class Tuile
    {
        private char couleur;
        private char forme;
        private int nb_utilisation = 3;
        private string path = @Plateau.GetDirectory();


        public Tuile(char couleur, char forme, string path)
        {
            this.couleur = couleur;
            this.forme = forme;
            this.path = string.Format("{0}{1}", this.path, path);
        }

        //Methode - Geter et Seter

        public string GetPath ()
        {
            return this.path;
        }

        public char GetCouleur()
        {
            return this.couleur;
        }

        public char GetForme()
        {
            return this.forme;
        }

        public int GetNb_utilisation()
        {
            return this.nb_utilisation;
        }

        //Methode - Autre
        public void UtilisationDeTuile()
        {
            this.nb_utilisation--;
        }

    }
}
