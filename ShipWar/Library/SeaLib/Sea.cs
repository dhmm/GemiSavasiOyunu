using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ShipWar.Library.GameSettings;
using ShipWar.Library.Common;
using ShipWar.Library.ShipLib;
using System.Diagnostics;
using System.Windows.Forms;
using ShipWar.Library.ComputerLib;
using ShipWar.Library.Statuses;

namespace ShipWar.Library.SeaLib
{
    internal class Sea
    {
        Game Game;
        Random r = new Random();
        int SeaWidth = SeaSettings.SeaWidth;
        int SeaHeight = SeaSettings.SeaHeight;

        internal Dictionary<Tuple<int,int>, SeaTile> SeaTiles;
        internal SeaTile this[int x, int y]
        {            
            set 
            {                                        
                if (!SeaTiles.Keys.Contains(Tuple.Create<int,int>(x,y)))
                {
                    SeaTiles[Tuple.Create<int, int>(x, y)] = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
            get 
            {
                if (x > SeaWidth || y > SeaHeight)
                {
                    throw new ArgumentOutOfRangeException();
                }                
                if (SeaTiles.Keys.Contains(Tuple.Create<int, int>(x, y)))
                {
                    return SeaTiles[Tuple.Create<int, int>(x, y)];
                }
                else
                {
                    Debug.WriteLine("ERROR FROM HERE x = "+x+"y = "+y);
                    throw new NullReferenceException();
                    
                }
            }
        }
        internal SeaTile this[Point point]
        {
            get
            {
                return this[point.X,point.Y];
            }
        }


        internal Sea(Game game)
        {
            SeaTiles = new Dictionary<Tuple<int, int>, SeaTile>();
            Game = game;
            CreateSea();
        }

        internal void CreateSea()
        {
            for (int x = 0; x < SeaWidth; x++)
            {
                for (int y = 0; y < SeaHeight; y++)
                {
                    this[x, y] = new SeaTile(x, y);
                }
            }
        }

        internal void AddShipToRandomPlace(Ship ship)
        {
            Point startPoint = GetRandomPoint();
            int maxCount = 1000;
            int attemp = 0;
            bool placed=false;
            while(attemp < maxCount && !placed)
            {
                startPoint = GetRandomPoint();
                if(!this[startPoint].HasShipPart())
                {
                    Point endPoint = FindEndPoint(startPoint,ship);
                    if(PointInRange(endPoint))
                    {
                        if(!HasShipTheRange(startPoint,endPoint))
                        {                            
                            AddShipToSea(ship,startPoint,endPoint);
                            placed=true;                           
                        }
                    }                    
                }
                attemp++;                
            }
            if (!placed)
            {
                MessageBox.Show("Bos yer bulunamadi");
                Application.Exit();
            }
            
        }
        internal void AddShipToSea(Ship ship,Point startPoint,Point endPoint)
        {
            Debug.WriteLine("Size ="+ship.ShipSize);
            Debug.WriteLine("From = S(" + startPoint.X + "," + startPoint.Y + ") - E(" + endPoint.X + "," + endPoint.Y + ")");


            for(int x=startPoint.X; x<=endPoint.X;x++)
            {
                for(int y=startPoint.Y;y<=endPoint.Y;y++)
                {
                    Debug.WriteLine("adding part x = "+x+", y="+y);
                    ShipPart shipPart = new ShipPart(ship,x,y);
                    this[x, y].ShipPart = shipPart;
                    ship.ShipParts.Add(shipPart);
                                          
                }
            }
        }
        internal Point GetRandomPoint()
        {
            return new Point(r.Next(0,SeaWidth),r.Next(0,SeaHeight));
        }
        internal Point FindEndPoint(Point startPoint,Ship ship)
        {
            Point endPoint = new Point(-1, -1);
            if(ship.ShipDirection == ShipDirections.HORIZONTAL)
            {
                endPoint.X = startPoint.X + ship.ShipSize-1;
                endPoint.Y = startPoint.Y;
            }
            else
            {
                endPoint.X = startPoint.X;
                endPoint.Y = startPoint.Y + ship.ShipSize-1;
            }
            return endPoint;
        }
        internal bool HasShipTheRange(Point startPoint,Point endPoint)
        {
            for(int x=startPoint.X; x<=endPoint.X;x++)
            {
                for(int y=startPoint.Y;y<=endPoint.Y;y++)
                {
                    if(this[x,y].HasShipPart())
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        internal bool PointInRange(Point point)
        {
            return point.X >=0 && point.X <SeaSettings.SeaWidth &&
                   point.Y >=0 && point.Y < SeaSettings.SeaHeight;
        }

        internal bool AttackOn(Computer computer, Point p)
        {
            SeaTile tile = this[p.X, p.Y];
            if (tile.HasShipPart() && tile.ShipPart.ShipPartStatus == ShipPartStatuses.LIVE)
            {
                tile.ShipPart.Destroy();
                tile.SeaTileControl.DestroyCover();
               
                if (tile.ShipPart.Parent.AllPartsDestroyed())
                {
                    computer.Score += 100;
                    Game.ComputerScore.Text = computer.Score.ToString();
                    computer.Ships += 1;
                    Game.ComputerScore.Text = computer.Ships.ToString();
                    if (Game.ShipsManager.AllShipsAreDead())
                    {
                        Game.WhoWin();
                    }
                }
                else
                {
                    computer.Score += 10;
                    Game.ComputerScore.Text = computer.Score.ToString();
                }
                return true;
            }
            else
            {
                tile.SeaTileControl.DestroyCover();
                return false;
            }
            
        }
    }
}
