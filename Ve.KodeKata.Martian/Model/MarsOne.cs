using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ve.KodeKata.Martian.Model
{
    public class MarsOne: IExplorer
    {
        public Position CurrentPosition { get; set; }

        public MarsOne()
        {
            CurrentPosition = new Position();
        }

        public Position MoveUp()
        {
            CurrentPosition.CoordY = this.CurrentPosition.CoordY + 1;
            return CurrentPosition;
        }

        public Position MoveDown()
        {
            CurrentPosition.CoordY = this.CurrentPosition.CoordY - 1;
            return CurrentPosition;
        }

        public Position MoveRigth()
        {
            CurrentPosition.CoordX = this.CurrentPosition.CoordX + 1;
            return CurrentPosition;
        }

        public Position MoveLeft()
        {
            CurrentPosition.CoordX = this.CurrentPosition.CoordX - 1;
            return CurrentPosition;
        }
    }
}
