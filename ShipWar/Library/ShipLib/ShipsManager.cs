using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ShipWar.Library.SeaLib;
using ShipWar.Library.GameSettings;

namespace ShipWar.Library.ShipLib
{
    internal class ShipsManager
    {        
        Sea Sea;
        List<Ship> Ships;

        internal ShipsManager(Sea sea)
        {
            Sea = sea;
            Ships = new List<Ship>();
        }
        internal void CreateShips()
        {
            for (int i = 0; i < ShipsSettings.ShipsCount; i++)
            {
                Ship ship = new Ship();
                Ships.Add(ship);
            }
            AddShipsToSea();
        }
        internal void AddShipsToSea()
        {
            foreach (Ship ship in Ships)
            {
                Sea.AddShipToRandomPlace(ship);
            }
        }
        internal bool AllShipsAreDead()
        {
            foreach(Ship ship in Ships)
            {
                if(ship.IsLive())
                {
                    return false;
                }
            }
            return true;
        }
    }
}
