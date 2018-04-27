using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WumpusGame
{
    public partial class GameControlTestForm : Form
    {

        GameControl game;
        public System.Windows.Forms.Button[] ButtonArray = new System.Windows.Forms.Button[6];

        public GameControlTestForm()
        {
            game = new GameControl();
            InitializeComponent();
            ButtonArray[0] = Door0;
            ButtonArray[1] = Door1;
            ButtonArray[2] = Door2;
            ButtonArray[3] = Door3;
            ButtonArray[4] = Door4;
            ButtonArray[5] = Door5;

        }

        private void Door0_Click(object sender, EventArgs e)
        {

        }

        private void Door1_Click(object sender, EventArgs e)
        {

        }

        private void Door2_Click(object sender, EventArgs e)
        {

        }

        private void Door3_Click(object sender, EventArgs e)
        {

        }

        private void Door4_Click(object sender, EventArgs e)
        {

        }

        private void Door5_Click(object sender, EventArgs e)
        {

        }

        private void LoadRoom1_Click(object sender, EventArgs e)
        {
            game.updateRoom(ButtonArray, 1);
        }
    }
}
