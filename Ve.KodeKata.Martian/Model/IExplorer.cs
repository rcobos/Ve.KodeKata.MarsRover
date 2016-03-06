using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ve.KodeKata.Martian.Model
{
    public interface IExplorer
    {
        Position CurrentPosition { get; set; }

        Position MoveUp();
        Position MoveDown();
        Position MoveRigth();
        Position MoveLeft();
    }
}
