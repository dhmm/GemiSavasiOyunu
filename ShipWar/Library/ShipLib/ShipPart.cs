using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ShipWar.Library.Common;
using ShipWar.Library.Statuses;


namespace ShipWar.Library.ShipLib
{
    internal class ShipPart
    {
        internal Ship Parent { set; get; }        
        internal Point Point { set; get; }


        internal int ShipPartStatus;

        internal ShipPart(Ship parent, int x,int y)
        {
            Parent = parent;
            Point = new Point(x, y);
            ShipPartStatus = ShipPartStatuses.LIVE;

        }
        internal void Destroy()
        {
            ShipPartStatus = ShipPartStatuses.DEAD;
            Parent.PartDestroyed();
        }

        
    }
}
