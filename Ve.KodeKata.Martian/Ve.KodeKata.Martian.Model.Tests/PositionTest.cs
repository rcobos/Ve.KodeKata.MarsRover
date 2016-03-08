using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ve.KodeKata.Martian.Model.Tests
{
    [TestClass]
    public class PositionTest
    {
        Position defaultPosition = new Position(1, 1);

        [TestMethod]
        public void GetXFromDefaultPositionMustReturnExpectedResult()
        {
            Assert.AreEqual(defaultPosition.CoordX, 1);
        }

        [TestMethod]
        public void GetYFromDefaultPositionMustReturnExpectedResult()
        {
            Assert.AreEqual(defaultPosition.CoordX, 1);
        }

        [TestMethod]
        public void SetXFromDefaultPositionMustReturnExpectedResult()
        {
            Position position = new Position(1, 1);
            position.CoordX = 2;
            Assert.AreEqual(position.CoordX, 2);
        }

        [TestMethod]
        public void SetYFromDefaultPositionMustReturnExpectedResult()
        {
            Position position = new Position(1, 1);
            position.CoordY = 2;
            Assert.AreEqual(position.CoordY, 2);
        }

    }
}