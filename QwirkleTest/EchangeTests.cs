using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QwirkleLibrary;

namespace QwirkleTest
{
    [TestClass]
    public class EchangeTests
    {
        [TestMethod]
        public void TestAddRemove()
        {
            Tuile tuile = new Tuile('c', 'e', @"exemple");

            Echange.SetSwap(tuile);
            Assert.AreEqual(1,Echange.GetNumeCase());

            Echange.ValiderSwap();
            Assert.AreEqual(0,Echange.GetNumeCase());
        }

        [TestMethod]
        public void TestGetCase()
        {
            Tuile tuile = new Tuile('c', 'e', @"exemple");

            Echange.SetSwap(tuile);
            Assert.AreEqual(tuile, Echange.GetSwap(0));
        }



    }
}
