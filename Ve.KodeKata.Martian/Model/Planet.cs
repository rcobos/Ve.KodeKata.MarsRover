using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ve.KodeKata.Martian.Model
{
    public class Planet : IPlanet
    {
        public int Length { get; set; }
        public int Heigth { get; set; }

        public Planet()
        {
        }
    }
}
