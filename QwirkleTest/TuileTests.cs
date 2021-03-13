using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QwirkleLibrary;
using System.IO;

namespace QwirkleTest
{
    [TestClass]
    public class TuileTests
    {
        [TestMethod]
        public void TestTuileGetters()
        {
            Tuile tuile = new Tuile('c','e',@"exemple");
            Assert.AreEqual('c',tuile.GetCouleur());
            Assert.AreEqual('e', tuile.GetForme());
            Assert.AreEqual(3, tuile.GetNb_utilisation());
            Assert.AreEqual(string.Format("{0}exemple", Directory.GetCurrentDirectory()), tuile.GetPath());
        }

        [TestMethod]
        public void TestTuileDecrementation()
        {
            Tuile tuile = new Tuile('c', 'e', @"exemple");
            tuile.UtilisationDeTuile();
            Assert.AreEqual(2,tuile.GetNb_utilisation());
        }
    }
}
