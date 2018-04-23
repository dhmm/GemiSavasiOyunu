using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ShipWar.Library.GameSettings;
using ShipWar.Library.Statuses;
using System.Diagnostics;

namespace ShipWar.Library.ShipLib
{
    internal class Ship
    {
        static Random r=new Random();
        internal int ShipSize { set; get; }
        internal int ShipDirection { set; get; }
        internal List<ShipPart> ShipParts;
        int ShipStatus;

        internal Ship()
        {            
            ShipSize = r.Next(ShipsSettings.MinShipSize, ShipsSettings.MaxShipSize);
            ShipDirection = r.Next(ShipDirections.HORIZONTAL, ShipDirections.VERTICAL+1);
            Debug.WriteLine("direction = "+ShipDirection.ToString());
            ShipStatus = ShipStatuses.LIVE;
            ShipParts = new List<ShipPart>();
        }
        internal bool IsLive()
        {
            return ShipStatus == ShipStatuses.LIVE;
        }
        internal bool IsDead()
        {
            return ShipStatus == ShipStatuses.DEAD;
        }
        internal void PartDestroyed()
        {
            if (AllPartsDestroyed())
            {
                ShipStatus = ShipStatuses.DEAD;
            }
        }
        internal bool AllPartsDestroyed()
        {
            foreach (ShipPart shipPart in ShipParts)
            {
                if (shipPart.ShipPartStatus != ShipPartStatuses.DEAD)
                {
                    return false;
                }
            }
            return true;
        }
        
    }
}
