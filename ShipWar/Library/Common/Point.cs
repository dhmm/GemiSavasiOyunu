using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShipWar.Library.Common
{
    internal class Point
    {
        internal int X { set; get; }
        internal int Y { set; get; }

        internal Point(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
