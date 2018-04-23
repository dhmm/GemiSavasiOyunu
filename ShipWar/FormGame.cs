using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ShipWar.Library;

namespace ShipWar
{
    public partial class FormGame : Form
    {
        Game game = null;

        public FormGame()
        {            
            InitializeComponent();
        }

        private void mnuNewGame_Click(object sender, EventArgs e)
        {            
            game.Start();
            
        }

        private void FormGame_Load(object sender, EventArgs e)
        {
            game = new Game(pnlSea,lblComputerScore,lblPlayerScore,lblComputerShipsCount,lblPlayerShipsCount);
        }
    }
}
