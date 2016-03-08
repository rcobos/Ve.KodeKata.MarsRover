using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ve.KodeKata.Martian.Model.Tests
{
    [TestClass]
    public class PlanetTest
    {
        int DefaultHeigth = 1;
        int DefaultLength = 1;
        Planet DefaultPlanet;


        [TestInitialize]
        public void SetUp()
        {
            DefaultPlanet = new Planet();
            DefaultPlanet.Heigth = DefaultHeigth;
            DefaultPlanet.Length = DefaultLength;
        }

        [TestMethod]
        public void GetLengthMustReturnExpectedResult()
        {
            Assert.AreEqual(DefaultPlanet.Length, DefaultLength);
        }

        [TestMethod]
        public void GetHeigthtMustReturnExpectedResult()
        {
            Assert.AreEqual(DefaultPlanet.Heigth, DefaultHeigth);
        }

        [TestMethod]
        public void SetLengthMustReturnExpectedResult()
        {
            int newValue = 2;
            DefaultPlanet.Length = newValue;
            Assert.AreEqual(DefaultPlanet.Length, newValue);
        }

        [TestMethod]
        public void SetHeigthtMustReturnExpectedResult()
        {
            int newValue = 2;
            DefaultPlanet.Heigth = newValue;
            Assert.AreEqual(DefaultPlanet.Heigth, newValue);
        }
    }
}
