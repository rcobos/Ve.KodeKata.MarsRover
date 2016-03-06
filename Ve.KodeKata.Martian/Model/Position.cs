using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ve.KodeKata.Martian.Model
{
    public class Position
    {

        public int CoordX { get; set; }
        public int CoordY { get; set; }

        public Position(int coordX, int coordY)
        {
            this.CoordX = coordX;
            this.CoordY = coordY;
        }

        public Position()
        {
            this.CoordX = 0;
            this.CoordY = 0;
        }

        public override string ToString()
        {            
            return string.Format(Constants.POSITION_FORMAT, CoordX, CoordY);
        }
    }
}
