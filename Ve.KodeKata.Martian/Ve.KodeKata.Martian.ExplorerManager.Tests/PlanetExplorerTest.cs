using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ve.KodeKata.Martian.Model;
using Ve.KodeKata.Martian.ExplorerManager;
using NSubstitute;
using System.Collections.Generic;

namespace Ve.KodeKata.Martian.ExplorerManager.Tests
{
    [TestClass]
    public class PlanetExplorerTest
    {
        private IPlanet _planet;
        private IExplorer _explorer;
        private PlanetExplorer _planetExplorer;

        [TestInitialize]
        public void SetUp()
        {
            _planet = Substitute.For<IPlanet>();
            _explorer = Substitute.For<IExplorer>();
            _planetExplorer = new PlanetExplorer(_planet, _explorer);
        }

        #region CheckPositionInsidePlanet
        [TestMethod]
        public void CheckPositionInsidePlanetWithValidPositionReturnsTrue()
        {
            
            _planet.Heigth = 1;
            _planet.Length = 1;

            Position position = new Position(0, 0);

            Assert.IsTrue(_planetExplorer.CheckPositionInsidePlanet(position));
        }

        [TestMethod]
        public void CheckPositionInsidePlanetWithInValidPositionReturnsFalse()
        {
            
            _planet.Heigth = 1;
            _planet.Length = 1;

            Position position = new Position(1, 1);

            Assert.IsFalse(_planetExplorer.CheckPositionInsidePlanet(position));
        }
        
        [TestMethod]
        public void CheckPositionInsidePlanetWithInValidXPositionReturnsFalse()
        {
            
            _planet.Heigth = 2;
            _planet.Length = 2;

            Position position = new Position(2, 1);

            Assert.IsFalse(_planetExplorer.CheckPositionInsidePlanet(position));
        }

        [TestMethod]
        public void CheckPositionInsidePlanetWithInValidYPositionReturnsFalse()
        {            
            _planet.Heigth = 2;
            _planet.Length = 2;

            Position position = new Position(1, 2);

            Assert.IsFalse(_planetExplorer.CheckPositionInsidePlanet(position));
        }
        #endregion

        #region Explore
        public void ExploreWithNullMovementsReturnsNull()
        {
            string error = "";
            List<Constants.Movements> movements = null;
            Assert.IsNull(_planetExplorer.Explore(movements, out error));
        }

        [TestMethod]
        public void ExploreWithvalidMovementsReturnsPosition()
        {
            _planet.Heigth = 2;
            _planet.Length = 2;

            _explorer.MoveUp().Returns(new Position(0, 1));
            _explorer.MoveRigth().Returns(new Position(1, 1));
            List<Constants.Movements> movements = new List<Constants.Movements>()
            {
                Constants.Movements.up,
                Constants.Movements.rigth
            };
            Position expectedPosition = new Position(1,1);
            string error;
            Position result =_planetExplorer.Explore(movements, out error);
            Assert.AreEqual(result.CoordX,expectedPosition.CoordX);
            Assert.AreEqual(result.CoordY, expectedPosition.CoordY);
        }

        [TestMethod]
        public void ExploreWithInvalidMovementsReturnsInitialPosition()
        {
            Position initialPosition = new Position(1, 0);
            _explorer.CurrentPosition = initialPosition;
            _explorer.MoveUp().Returns(new Position(1, 1));
            _explorer.MoveRigth().Returns(new Position(2, 1));

            _planet.Heigth = 2;
            _planet.Length = 2;

            List<Constants.Movements> movements = new List<Constants.Movements>()
            {
                Constants.Movements.up,
                Constants.Movements.rigth
            };

            string error;
            Position result = _planetExplorer.Explore(movements, out error);
            Assert.AreEqual(result.CoordX, initialPosition.CoordX);
            Assert.AreEqual(result.CoordY, initialPosition.CoordY);
            Assert.IsFalse(string.IsNullOrEmpty(error));
        }

        #endregion
    }
}
