using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ve.KodeKata.Martian.Model
{
    public interface IPlanet
    {
        int Length { get; set; }
        int Heigth { get; set; }

        void Initialize(int length, int heigth);
    }
}
