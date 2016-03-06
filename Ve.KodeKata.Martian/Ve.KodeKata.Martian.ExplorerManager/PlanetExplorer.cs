using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ve.KodeKata.Martian.Model;

namespace Ve.KodeKata.Martian.ExplorerManager
{
    public class PlanetExplorer : IExplorerManager
    {
        private IPlanet _planet;
        private IExplorer _explorer;
        

        public PlanetExplorer(IPlanet planet, IExplorer explorer)
        {
            _planet = planet;
            _explorer = explorer;
        }

        public bool CheckPositionInsidePlanet(Position position)
        {            
            bool validX = position.CoordX < _planet.Length;
            bool validY = position.CoordY < _planet.Heigth;

            return (validX && validY);
        }

        public Position Explore(List<Constants.Movements> movements, out string error)
        {
            Position targetPosition = null;
            Position sourcePosition = _explorer.CurrentPosition;
            error = "";
            if (movements != null)
            {
                foreach (var movement in movements)
                {             
                    switch (movement)
                    {
                        case Constants.Movements.up:
                            targetPosition = _explorer.MoveUp();
                            break;
                        case Constants.Movements.down:
                            targetPosition = _explorer.MoveDown();
                            break;
                        case Constants.Movements.rigth:
                            targetPosition = _explorer.MoveRigth();
                            break;
                        case Constants.Movements.left:
                            targetPosition = _explorer.MoveLeft();
                            break;
                        default:
                            break;
                    }
                    if (!CheckPositionInsidePlanet(targetPosition))
                    {                           
                        error = string.Format(Constants.WRONG_MOVEMENT, movement.ToString(),targetPosition.ToString());
                        targetPosition = sourcePosition;
                        _explorer.CurrentPosition = sourcePosition;
                        break;
                    }
                }
            }
            return targetPosition;
        }
    }
}
