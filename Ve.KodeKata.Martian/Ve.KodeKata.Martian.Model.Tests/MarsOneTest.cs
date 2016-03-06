using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ve.KodeKata.Martian.Model.Tests
{
    [TestClass]
    public class MarsOneTest
    {
        private MarsOne marsOne;
        int initialX = 0;
        int initialY = 0;

        [TestInitialize]
        public void SetUp()
        {
            Position initialPosition = new Position(initialX, initialY);
            marsOne = new MarsOne();
            marsOne.CurrentPosition = initialPosition;
        }

        [TestMethod]
        public void MoveUpMustReturnsValidResult()
        {
            marsOne.MoveUp();
            Assert.AreEqual(marsOne.CurrentPosition.CoordX, initialX);
            Assert.AreEqual(marsOne.CurrentPosition.CoordY, initialY + 1);
        }

        [TestMethod]
        public void MoveDownMustReturnsValidResult()
        {
            marsOne.MoveDown();
            Assert.AreEqual(marsOne.CurrentPosition.CoordX, initialX);
            Assert.AreEqual(marsOne.CurrentPosition.CoordY, initialY - 1);
        }

        [TestMethod]
        public void MoveRigthMustReturnsValidResult()
        {
            marsOne.MoveRigth();
            Assert.AreEqual(marsOne.CurrentPosition.CoordY, initialY);
            Assert.AreEqual(marsOne.CurrentPosition.CoordX, initialX + 1);
        }

        [TestMethod]
        public void MoveLeftMustReturnsValidResult()
        {
            marsOne.MoveLeft();
            Assert.AreEqual(marsOne.CurrentPosition.CoordY, initialY);
            Assert.AreEqual(marsOne.CurrentPosition.CoordX, initialX - 1);
        }
    }
}
