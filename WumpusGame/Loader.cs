using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WumpusGame;
using WumpusGame.bin;

namespace WumpusGame.bin
{
    public partial class Loader : Form
    {
        public Loader()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.run("_FinalGame");
        }

        private void GameControlTester_Click(object sender, EventArgs e)
        {
            Program.run("GameControlTester");
        }

        private void TriviaTester_Click(object sender, EventArgs e)
        {
            Program.run("TriviaForm");
        }

        private void CaveTester_Click(object sender, EventArgs e)
        {
            Program.run("Cave Teseter");
        }

        private void mapTester_Click(object sender, EventArgs e)
        {
            
        }

        private void PlayerTester_Click(object sender, EventArgs e)
        {
            Program.run("HighScoreTestForm");
        }
    }
}
