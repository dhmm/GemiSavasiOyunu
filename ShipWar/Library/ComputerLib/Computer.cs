using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ShipWar.Library.Common;
using ShipWar.Library.GameSettings;
using System.Windows.Forms;
using ShipWar.Library.SeaLib;
using ShipWar.Library.Statuses;


namespace ShipWar.Library.ComputerLib
{
    internal class Computer : Player
    {
        Random r = new Random();
        List<Point> UsedPoints;
        Sea Sea;

        

        internal Computer(Sea sea)
        {
            UsedPoints = new List<Point>();
            Sea = sea;
        }
        internal void Play()
        {
            AttackRandomPoint();
        }
        internal void AttackRandomPoint()
        {
            bool attackSuccesfull = false;
            do
            {
                Point p = GetRandomPoint();
                attackSuccesfull = Sea.AttackOn(this,p);                
            } while (attackSuccesfull);
        }
        internal Point GetRandomPoint()
        {
            int maxCount = 1000;
            int attemp = 0;
            bool finded = false;
            while (attemp < maxCount && !finded)
            {
                Point p = new Point(r.Next(0, SeaSettings.SeaWidth), r.Next(0, SeaSettings.SeaHeight));
                
                if (!UsedPoints.Contains(p))
                {
                    if (Sea[p.X, p.Y].ShipPart == null)
                    {
                        finded = true;
                        UsedPoints.Add(p);
                        return p;
                    }
                    else
                    {

                        if (Sea[p.X, p.Y].ShipPart.ShipPartStatus != ShipPartStatuses.DEAD)
                        {
                            finded = true;
                            return p;
                        }
                        else
                        {
                            UsedPoints.Add(p);
                        }
                    }
                }
            }
            if (!finded)
            {
                MessageBox.Show("Vurulacak yer bulunamadi");
                Application.Exit();
            }
            return null;
        }        
    }
}
