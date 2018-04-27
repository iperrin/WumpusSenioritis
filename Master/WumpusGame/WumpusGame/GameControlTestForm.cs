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

        public GameControlTestForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {      
            game = new GameControl(Convert.ToInt16(textBox1.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String temp = game.data[3];
            label1.Text = temp;
        }

        private void button3_Click(object sender, EventArgs e)
        {

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
    }
}
