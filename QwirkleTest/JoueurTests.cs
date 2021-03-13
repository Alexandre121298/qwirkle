using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QwirkleLibrary;

namespace QwirkleTest
{
    [TestClass]
    public class JoueurTests
    {

        [TestMethod]
        public void TestGetOrdre_Tour()
        {
            Joueur joueur1 = new Joueur("Serge",1);
            Joueur joueur2 = new Joueur("Serge",2);

            Assert.AreEqual(1, joueur1.GetOrdre_Tour());
            Assert.AreEqual(2, joueur2.GetOrdre_Tour());
        }

        [TestMethod]
        public void TestGetSetName()
        {
            Joueur joueur = new Joueur("Serge",1);

            Assert.AreEqual("Serge", joueur.GetName());
            joueur.SetName("Bill");
            Assert.AreEqual("Bill", joueur.GetName());
        }

        [TestMethod]
        public void TestGetSetScore()
        {
            Joueur joueur = new Joueur("Serge",1);
            Assert.AreEqual(0, joueur.GetScore());
            joueur.SetScore(100);
            Assert.AreEqual(100, joueur.GetScore());

        }

        [TestMethod]
        public void TestGetSetMain()
        {
            Joueur joueur = new Joueur("Serge",1);
            Tuile tuile = new Tuile('c', 'e', @"exemple");
            Tuile tuile2 = new Tuile('y', 'u', @"exemple");
            joueur.SetMain(0, tuile);
            tuile2 = joueur.GetMain(0);
            Assert.AreEqual(tuile, tuile2);
        }



        [TestMethod]
        public void TestPoserTuile()
        {
            Joueur joueur = new Joueur("Serge",1);
            Tuile tuile = new Tuile('c', 'e', @"exemple");
            joueur.SetMain(0, tuile);
            joueur.PlacerTuile(0, 0, 1);
            Assert.AreEqual(tuile, Plateau.GetCase(0, 1));
        }

        [TestMethod]
        public void TestEnleverTuileMain()
        {
            Joueur joueur = new Joueur("Serge",1);
            Tuile tuile = new Tuile('c', 'e', @"exemple");
            joueur.SetMain(0, tuile);
            joueur.EnleverTuileMain(0);
            Assert.AreEqual(null, joueur.GetMain(0));
        }

        [TestMethod]
        public void AjouterTuileMain()
        {
            Joueur joueur = new Joueur("Bill",1);
            Tuile tuile1 = new Tuile('c', 'e', @"exemple");
            Tuile tuile2 = new Tuile('e', 'c', @"exemple");
            int compteur = 0;

            Pioche.SetPioche(tuile1);
            Pioche.SetPioche(tuile2);
            joueur.AjouterTuileMain();

            for (compteur = 0; compteur <= 5; compteur++)
            {
                Assert.AreNotEqual(null, joueur.GetMain(compteur));
            }

            joueur.EnleverTuileMain(5);
            Assert.AreEqual(null, joueur.GetMain(5));

            joueur.AjouterTuileMain();
            Assert.AreEqual(null, joueur.GetMain(5));
        }

        [TestMethod]
        public void TestTuilesRestantes()
        {
            Joueur joueur = new Joueur("Serge",1);
            Tuile tuile = new Tuile('c', 'e', @"exemple");
            joueur.SetMain(0, tuile);
            Assert.AreEqual(1,joueur.TuilesRestantes());
            joueur.EnleverTuileMain(0);
            Assert.AreEqual(0, joueur.TuilesRestantes());
        }
    }
}
