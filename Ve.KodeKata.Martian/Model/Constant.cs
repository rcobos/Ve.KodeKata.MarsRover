using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ve.KodeKata.Martian.Model
{
    public static class Constants
    {
        public enum Movements
        {
            up, down, rigth, left
        }

        public const string WRONG_MOVEMENT = "Wrong movement:{0} Target position:{1}";
        public const string POSITION_FORMAT = "({0},{1})";

        public const int DEFAULT_HEIGTH = 2;
        public const int DEFAULT_LENGTH = 2;

        public const int DEFAULT_POSITION_X = 0;
        public const int DEFAULT_POSITION_Y = 0;
        
    }
}
