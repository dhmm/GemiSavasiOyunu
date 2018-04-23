using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ShipWar.Library.Statuses;
using ShipWar.Library.HumanLib;
using ShipWar.Library.ComputerLib;
using ShipWar.Library.ShipLib;
using ShipWar.Library.SeaLib;
using ShipWar.Library.Common;
using ShipWar.Library.GraphicalObject;

namespace ShipWar.Library
{
    public class Game
    {
        Random r = new Random();
        int GameStatus ;
        Computer Computer;
        internal Human Human;               
        Sea Sea;
        internal ShipsManager ShipsManager;

        Panel Panel;
        internal Label ComputerScore;
        internal Label ComputerShips;

        internal Label HumanScore;
        internal Label HumanShips;
        
        

        public Game(Panel panel, Label computerScore,Label humanScore,
                    Label computerShips,Label humanShips)
        {
            GameStatus = GameStatuses.FINISHED;
            ComputerScore = computerScore;
            ComputerShips = computerShips;
            HumanScore = humanScore;
            HumanShips = humanShips;                      
            Panel = panel;
            Init();            
        }
        private void Init()
        {            
            Sea = new Sea(this);
            ShipsManager = new ShipsManager(Sea);
            Computer = new Computer(Sea);
            Human = new Human();
            Panel.Controls.Clear();
            ShipsManager.CreateShips();            
            AddTilesToPanel();
        }
        public bool IsStarted()
        {
            return GameStatus == GameStatuses.STARTED;
        }
        public bool IsTerminated()
        {
            return GameStatus == GameStatuses.TERMINATED;
        }
        public bool IsFinished()
        {
            return GameStatus == GameStatuses.FINISHED;
        }
        public void Start()
        {
            if (IsStarted())
            {
                if (MessageBox.Show("Oyun yeniden baslatilsin mi ?","Yeniden baslatma",MessageBoxButtons.YesNo,MessageBoxIcon.Information) == DialogResult.No)
                {
                    return;
                }
                Terminate();
            }            
            GameStatus = GameStatuses.STARTED;
            Init();
            int who = WhoStarts();
            if (who == 0)
            {
                Computer.Play();
            }
            else
            {
                MessageBox.Show("Oyuna siz basliyorsunuz bol sans !");
            }
       
        }        
        public void Terminate()
        {
            GameStatus = GameStatuses.TERMINATED;
        }
        public void Finish()
        {
            GameStatus = GameStatuses.FINISHED;
        }
        public int WhoStarts()
        {            
            return r.Next(0, 2);            
        }
        public void ComputerPlay()
        {            
            Computer.Play();            
        }
        public void AddTilesToPanel()
        {
            foreach(SeaTile seaTile in Sea.SeaTiles.Values)
            {
                SeaTileControl control = new SeaTileControl();
                control.Left = seaTile.Point.X *50;
                control.Top = seaTile.Point.Y * 50;                
                control.Parent = seaTile;
                control.Game = this;
                seaTile.SeaTileControl = control;

                
                Panel.Controls.Add(control);
            }
        }

        internal void WhoWin()
        {
            if (this.Human.Score > this.Computer.Score)
            {
                MessageBox.Show("Tebrikler kazandiniz");
            }
            else if (this.Human.Score < this.Computer.Score)
            {
                MessageBox.Show("PC kazandi");
            }
            else
            {
                MessageBox.Show("Berabere kaldiniz");
            }
        }
    }
}
