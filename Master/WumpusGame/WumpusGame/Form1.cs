using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wumpus_Test
{
    public partial class Form1 : Form
    {
        private HighScore _HighScore;
        private Form1 _Form;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String[] data = System.IO.File.ReadAllLines(@"C:\Users\Public\TestFolder\read.txt"); 
            _HighScore = new HighScore(data);
            


        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.IO.File.WriteAllLines(@"C:\Users\Public\TestFolder\lines.txt", _HighScore.GetHighScores());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _HighScore.addScore();
            _HighScore.WriteNewScores();
            
        }
    }
}
