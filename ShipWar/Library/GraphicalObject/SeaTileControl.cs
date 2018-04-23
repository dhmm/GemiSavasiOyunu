using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ShipWar.Library.SeaLib;

namespace ShipWar.Library.GraphicalObject
{
    public partial class SeaTileControl : UserControl
    {
        internal SeaTile Parent {set;get;}
        internal Game Game { set; get; }

       
        public SeaTileControl()
        {
            InitializeComponent();
        }

        private void btnCover_MouseHover(object sender, EventArgs e)
        {
            btnCover.BackColor = Color.Black;
        }

        private void btnCover_MouseLeave(object sender, EventArgs e)
        {
            btnCover.BackColor = Color.Silver;
        }

        private void btnCover_MouseMove(object sender, MouseEventArgs e)
        {
            btnCover.BackColor = Color.Black;
        }

        private void btnCover_Click(object sender, EventArgs e)
        {
            this.btnCover.Dispose();
            if (Parent.HasShipPart())
            {
                Parent.ShipPart.Destroy();

                this.BackColor = Color.Red;

                if (Parent.ShipPart.Parent.AllPartsDestroyed())
                {
                    Game.Human.Score += 100;
                    Game.HumanScore.Text = Game.Human.Score.ToString();
                    Game.Human.Ships += 1;
                    Game.HumanShips.Text = Game.Human.Ships.ToString();
                    if (Game.ShipsManager.AllShipsAreDead())
                    {
                        Game.WhoWin();
                    }
                }
                else
                {
                    Game.Human.Score += 10;
                    Game.HumanScore.Text = Game.Human.Score.ToString();
                }

                
            }
            else
            {
                Game.ComputerPlay();
            }                     
        }

        internal void DestroyCover()
        {
            if (Parent.HasShipPart())
            {
                this.BackColor = Color.Red;
            }
            this.btnCover.Dispose();
        }
    }
}
