using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShipWar.Library.Common
{
    internal abstract class Player
    {
        internal int Score {set;get;}
        internal int Ships { set; get; }
        internal Player()
        {
            Score = 0;
        }

    }
}
