using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ve.KodeKata.Martian.Model;

namespace Ve.KodeKata.Martian.ExplorerManager
{
    public interface IExplorerManager
    {
        IPlanet _planet {get; set;}
        IExplorer _explorer{get; set;}

        bool CheckPositionInsidePlanet(Position position);

        Position Explore(List<Constants.Movements> movements, out string error);


    }
}
