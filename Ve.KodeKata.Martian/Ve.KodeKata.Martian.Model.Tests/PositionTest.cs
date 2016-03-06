using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ve.KodeKata.Martian.Model.Tests
{
    [TestClass]
    public class PositionTest
    {
        Position defaultPosition = new Position(1, 1);

        [TestMethod]
        public void GetXFromDefaultPositionMustReturnExpedtedResult()
        {
            Assert.AreEqual(defaultPosition.CoordX, 1);
        }

        [TestMethod]
        public void GetYFromDefaultPositionMustReturnExpedtedResult()
        {
            Assert.AreEqual(defaultPosition.CoordX, 1);
        }

        [TestMethod]
        public void SetXFromDefaultPositionMustReturnExpedtedResult()
        {
            Position position = new Position(1, 1);
            position.CoordX = 2;
            Assert.AreEqual(position.CoordX, 2);
        }

        [TestMethod]
        public void SetYFromDefaultPositionMustReturnExpedtedResult()
        {
            Position position = new Position(1, 1);
            position.CoordY = 2;
            Assert.AreEqual(position.CoordY, 2);
        }

    }
}