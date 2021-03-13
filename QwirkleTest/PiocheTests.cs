using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QwirkleLibrary;

namespace QwirkleTest
{
    [TestClass]
    public class PiocheTests
    {

        [TestMethod]
        public void TestInit()
        {
            int compteur=0;
            Pioche.Init();
            foreach (Tuile tuile in Pioche.pioche)
            {
                compteur++;
            }
            Assert.AreEqual(36, compteur);
        }

        [TestMethod]
        public void TestSetPioche()
        {
            Tuile tuile = new Tuile('c', 'e', @"exemple");
            int compteur = Pioche.pioche.Count;
            Pioche.SetPioche(tuile);
            Assert.AreEqual(compteur+1,Pioche.pioche.Count);
            Pioche.CarteEpuisee(0);
            Assert.AreEqual(compteur, Pioche.pioche.Count);
        }

        [TestMethod]
        public void PiocherCarte_Et_TabulaRasa()
        {
            Joueur joueur = new Joueur("Bill",1);
            Tuile tuile1 = new Tuile('c', 'e', @"exemple");
            Tuile tuile2 = new Tuile('e', 'c', @"exemple");
            int compteur = 0;

            Pioche.SetPioche(tuile1);
            Pioche.SetPioche(tuile2);
            joueur.AjouterTuileMain();
            Pioche.TabulaRasa();

            Assert.AreEqual(compteur,Pioche.pioche.Count);
        }

    }
}
