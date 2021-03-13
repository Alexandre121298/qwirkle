using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QwirkleLibrary
{
    public static class Pioche
    {
        public static List<Tuile> pioche= new List<Tuile>();
        public static int nb_tuiles = pioche.Count;
        public static Random aleatoire = new Random();

        //Methode - Seter
        public static void SetPioche(Tuile tuile)
        {
            pioche.Add(tuile);
        }

        //Methode - Autre

        public static void Init()
        {
            pioche.Clear();
            Tuile CarreBleu = new Tuile('B', 'C',@"\ImagesTuiles\CarreBleu.jpg"); //carrés
            pioche.Add(CarreBleu);
            Tuile CarreJaune = new Tuile('J', 'C', @"\ImagesTuiles\CarreJaune.jpg");
            pioche.Add(CarreJaune);
            Tuile CarreOrange = new Tuile('O', 'C', @"\ImagesTuiles\CarreOrange.jpg");
            pioche.Add(CarreOrange);
            Tuile CarreRouge = new Tuile('R', 'C', @"\ImagesTuiles\CarreRouge.jpg");
            pioche.Add(CarreRouge);
            Tuile CarreVert = new Tuile('V', 'C', @"\ImagesTuiles\CarreVert.jpg");
            pioche.Add(CarreVert);
            Tuile CarreViolet = new Tuile('v', 'C', @"\ImagesTuiles\CarreViolet.jpg");
            pioche.Add(CarreViolet);

            Tuile CroixBleue = new Tuile('B', 'c', @"\ImagesTuiles\CroixBleue.jpg"); //croix
            pioche.Add(CroixBleue);
            Tuile CroixJaune = new Tuile('J', 'c', @"\ImagesTuiles\CroixJaune.jpg");
            pioche.Add(CroixJaune);
            Tuile CroixOrange = new Tuile('O', 'c', @"\ImagesTuiles\CroixOrange.jpg");
            pioche.Add(CroixOrange);
            Tuile CroixRouge = new Tuile('R', 'c', @"\ImagesTuiles\CroixRouge.jpg");
            pioche.Add(CroixRouge);
            Tuile CroixVerte = new Tuile('V', 'c', @"\ImagesTuiles\CroixVerte.jpg");
            pioche.Add(CroixVerte);
            Tuile CroixViolet = new Tuile('v', 'c', @"\ImagesTuiles\CroixViolet.jpg");
            pioche.Add(CroixViolet);

            Tuile EtoileBleue = new Tuile('B', 'E', @"\ImagesTuiles\EtoileBleue.jpg"); //etoile
            pioche.Add(EtoileBleue);
            Tuile EtoileJaune = new Tuile('J', 'E', @"\ImagesTuiles\EtoileJaune.jpg");
            pioche.Add(EtoileJaune);
            Tuile EtoileOrange = new Tuile('O', 'E', @"\ImagesTuiles\EtoileOrange.jpg");
            pioche.Add(EtoileOrange);
            Tuile EtoileRouge = new Tuile('R', 'E', @"\ImagesTuiles\EtoileRouge.jpg");
            pioche.Add(EtoileRouge);
            Tuile EtoileVerte = new Tuile('V', 'E', @"\ImagesTuiles\EtoileVerte.jpg");
            pioche.Add(EtoileVerte);
            Tuile EtoileViolet = new Tuile('v', 'E', @"\ImagesTuiles\EtoileViolet.jpg");
            pioche.Add(EtoileViolet);

            Tuile LosangeBleu = new Tuile('B', 'L', @"\ImagesTuiles\LosangeBleu.jpg"); //losange
            pioche.Add(LosangeBleu);
            Tuile LosangeJaune = new Tuile('J', 'L', @"\ImagesTuiles\LosangeJaune.jpg");
            pioche.Add(LosangeJaune);
            Tuile LosangeOrange = new Tuile('O', 'L', @"\ImagesTuiles\LosangeOrange.jpg");
            pioche.Add(LosangeOrange);
            Tuile LosangeRouge = new Tuile('R', 'L', @"\ImagesTuiles\LosangeRouge.jpg");
            pioche.Add(LosangeRouge);
            Tuile LosangeVert = new Tuile('V', 'L', @"\ImagesTuiles\LosangeVert.jpg");
            pioche.Add(LosangeVert);
            Tuile LosangeViolet = new Tuile('v', 'L', @"\ImagesTuiles\LosangeViolet.jpg");
            pioche.Add(LosangeViolet);

            Tuile RondBleu = new Tuile('B', 'R', @"\ImagesTuiles\RondBleu.jpg"); //rond
            pioche.Add(RondBleu);
            Tuile RondJaune = new Tuile('J', 'R', @"\ImagesTuiles\RondJaune.jpg");
            pioche.Add(RondJaune);
            Tuile RondOrange = new Tuile('O', 'R', @"\ImagesTuiles\RondOrange.jpg");
            pioche.Add(RondOrange);
            Tuile RondRouge = new Tuile('R', 'R', @"\ImagesTuiles\RondRouge.jpg");
            pioche.Add(RondRouge);
            Tuile RondVert = new Tuile('V', 'R', @"\ImagesTuiles\RondVert.jpg");
            pioche.Add(RondVert);
            Tuile RondViolet = new Tuile('v', 'R', @"\ImagesTuiles\RondViolet.jpg");
            pioche.Add(RondViolet);

            Tuile TrefleBleu = new Tuile('B', 'T', @"\ImagesTuiles\TrefleBleu.jpg"); //trefle
            pioche.Add(TrefleBleu);
            Tuile TrefleJaune = new Tuile('J', 'T', @"\ImagesTuiles\TrefleJaune.jpg");
            pioche.Add(TrefleJaune);
            Tuile TrefleOrange = new Tuile('O', 'T', @"\ImagesTuiles\TrefleOrange.jpg");
            pioche.Add(TrefleOrange);
            Tuile TrefleRouge = new Tuile('R', 'T', @"\ImagesTuiles\TrefleRouge.jpg");
            pioche.Add(TrefleRouge);
            Tuile TrefleVert = new Tuile('V', 'T', @"\ImagesTuiles\TrefleVert.jpg");
            pioche.Add(TrefleVert);
            Tuile TrefleViolet = new Tuile('v', 'T', @"\ImagesTuiles\TrefleViolet.jpg");
            pioche.Add(TrefleViolet);
        }

        public static void TabulaRasa()
        {
            pioche.Clear();
        }

        public static void CarteEpuisee(int place)
        {
            pioche.RemoveAt(place);
        }

        public static void PiocherCarte(Joueur joueur, int position_tuile)
        {
            if (pioche.Count > 0)
            {

                nb_tuiles = pioche.Count;
                int alea_nb = aleatoire.Next(nb_tuiles);
                Tuile tuile = pioche.ElementAt(alea_nb);

                joueur.SetMain(position_tuile, tuile);

                pioche.ElementAt(alea_nb).UtilisationDeTuile();
                if ((pioche.ElementAt(alea_nb)).GetNb_utilisation() == 0)
                {
                    CarteEpuisee(alea_nb);
                }
            }
        }

    }
}
