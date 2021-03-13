using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QwirkleLibrary;

namespace QwirkleTest
{
    [TestClass]
    public class PlateauTests
    {
        //validation placemment

        [TestMethod]
        public void TestGetetdirectory()
        {
            Assert.AreNotEqual(null, Plateau.GetDirectory());
        }

        [TestMethod]
        public void TestGetetSetterFinDePartie()
        {
            Assert.AreEqual(false,Plateau.GetFinDePartie());
            Plateau.SetFinDePartie(true);
            Assert.AreEqual(true, Plateau.GetFinDePartie());
        }

        [TestMethod]
        public void TestGetPose_Finie()
        {
            Assert.AreEqual(false, Plateau.GetPose_Finie());
            Plateau.SetPose_Finie(true);
            Assert.AreEqual(true, Plateau.GetPose_Finie());

        }


        [TestMethod]
        public void TestCouleurEtFormeValidation()
        {
            Plateau.Init();
            Tuile tuile1 = new Tuile('c', 'e', @"exemple");
            Tuile tuile2 = new Tuile('c', 'r', @"exemple");
            Tuile tuile3 = new Tuile('r', 'e', @"exemple");
            Tuile tuile4 = new Tuile('r', 'r', @"exemple");

            Plateau.SetCase(1, 2, tuile2);
            Assert.AreEqual(true, Plateau.ValiderPlacement(1, 1, tuile1)); //bonne couleur
            Plateau.SetCase(1, 2, tuile3);
            Assert.AreEqual(true, Plateau.ValiderPlacement(1, 1, tuile1)); //bonne forme
            Plateau.SetCase(1, 2, tuile4);
            Assert.AreEqual(false, Plateau.ValiderPlacement(1, 1, tuile1)); //mauvaise forme et couleur
        }

        [TestMethod]
        public void TestMultidirectionnelValidation()
        {
            Plateau.Init();
            //meme couleur
            Tuile tuile1 = new Tuile('c', 'a', @"exemple"); //celle qu'on teste
            Tuile tuile2 = new Tuile('c', 'e', @"exemple");
            Tuile tuile3 = new Tuile('c', 'i', @"exemple");
            Tuile tuile4 = new Tuile('c', 'o', @"exemple");
            Tuile tuile5 = new Tuile('c', 'u', @"exemple");
            Tuile tuile6 = new Tuile('c', 'y', @"exemple");

            //meme forme
            Tuile tuile7 = new Tuile('a', 'a', @"exemple");
            Tuile tuile8 = new Tuile('e', 'a', @"exemple");
            Tuile tuile9 = new Tuile('i', 'a', @"exemple");
            Tuile tuile10 = new Tuile('o', 'a', @"exemple");
            Tuile tuile11 = new Tuile('u', 'a', @"exemple");
            Tuile tuile12 = new Tuile('y', 'a', @"exemple");

            //coordY
            Plateau.SetCase(10, 9, tuile2);
            Plateau.SetCase(10, 11, tuile3);
            Plateau.SetCase(10, 12, tuile4);
            Plateau.SetCase(10, 13, tuile5);
            Plateau.SetCase(10, 14, tuile6);

            //coordX
            Plateau.SetCase(9, 10, tuile7);
            Plateau.SetCase(11, 10, tuile8);
            Plateau.SetCase(12, 10, tuile9);
            Plateau.SetCase(13, 10, tuile10);
            Plateau.SetCase(14, 10, tuile11);

            Assert.AreEqual(true, Plateau.ValiderPlacement(10, 10,tuile1));

            Assert.AreEqual(false, Plateau.ValiderPlacement(10, 10, tuile2)); //mauvaise forme ou couleur

            Plateau.SetCase(15, 10, tuile12); //si + de 7 tuiles sur une ligne
            Assert.AreEqual(false, Plateau.ValiderPlacement(10, 10, tuile1));

        }

        [TestMethod]
        public void TestErreursDiverses()
        {
            Plateau.Init();
            Tuile tuile1 = new Tuile('c', 'e', @"exemple");
            Tuile tuile2 = new Tuile('c', 'r', @"exemple");
            Tuile tuile3 = new Tuile('r', 'e', @"exemple");
            Tuile tuile4 = new Tuile('r', 'r', @"exemple");

            Plateau.SetCase(1, 2, tuile2);
            Assert.AreEqual(false, Plateau.ValiderPlacement(1, 2, tuile1)); //emplacement deja utilisé
            Assert.AreEqual(false, Plateau.ValiderPlacement(19, 19, tuile1)); //case avec aucune tuiles autour
        }


        //calculscore


        [TestMethod]
        public void TestSiMultidirectionnelScore()
        {
            Plateau.Init();
            Tuile tuile1 = new Tuile('c', 'a', @"exemple");
            Tuile tuile2 = new Tuile('c', 'e', @"exemple");
            Tuile tuile3 = new Tuile('c', 'i', @"exemple");
            Tuile tuile4 = new Tuile('c', 'o', @"exemple");
            Tuile tuile5 = new Tuile('c', 'u', @"exemple");
            Tuile tuile6 = new Tuile('c', 'y', @"exemple");
            Tuile tuile7 = new Tuile('c', 'a', @"exemple");
            Tuile tuile8 = new Tuile('c', 'e', @"exemple");
            Tuile tuile9 = new Tuile('c', 'i', @"exemple");
            Tuile tuile10 = new Tuile('c', 'o', @"exemple");
            Tuile tuile11 = new Tuile('c', 'u', @"exemple");

            //coordY
            Plateau.SetCase(10, 9, tuile2);
            Plateau.SetCase(10, 10, tuile1); //celle qu'on teste
            Plateau.SetCase(10, 11, tuile3);
            Plateau.SetCase(10, 12, tuile4);
            Plateau.SetCase(10, 13, tuile5);
            Plateau.SetCase(10, 14, tuile6);

            //coordX
            Plateau.SetCase(9, 10, tuile7);
            Plateau.SetCase(11, 10, tuile8);
            Plateau.SetCase(12, 10, tuile9);
            Plateau.SetCase(13, 10, tuile10);
            Plateau.SetCase(14, 10, tuile11);
            Assert.AreEqual(24, Plateau.CalculScore(10, 10));

        }

    }
}
