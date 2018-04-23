using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ShipWar.Library.Common;
using ShipWar.Library.Statuses;
using ShipWar.Library.ShipLib;
using ShipWar.Library.GraphicalObject;

namespace ShipWar.Library.SeaLib
{
    internal class SeaTile
    {
        internal Point Point;
        internal ShipPart ShipPart;
        int TileStatus {set;get;}
        internal SeaTileControl SeaTileControl { set; get; }

        internal SeaTile(int x, int y)
        {
            Point = new Point(x,y);
            ShipPart = null;
            TileStatus = SeaTileStatuses.NotOpened;
        }
        internal void AddShipPart(ShipPart shipPart)
        {
            ShipPart = shipPart;
        }
        internal bool HasShipPart()
        {
            return ShipPart != null;
        }
        internal void Open()
        {
            if (HasShipPart())
            {
                ShipPart.Destroy();
            }
            else
            {
                TileStatus = SeaTileStatuses.Opened;                
            }
        }
       
    }
}
