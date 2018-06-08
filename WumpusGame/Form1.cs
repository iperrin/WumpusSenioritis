using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WumpusTest
{
    public partial class Form1 : Form
    {
        private Cave _Cave;
        private int randomCave;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random r = new Random();
            randomCave = r.Next(0, 5);
            _Cave = new Cave();
            _Cave.load(randomCave);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _Cave.getDoors();
        }  
    
    }
}
