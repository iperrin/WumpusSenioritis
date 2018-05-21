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
            //game = new GameControl();
            InitializeComponent();
            ButtonArray[0] = Door0;
            ButtonArray[1] = Door1;
            ButtonArray[2] = Door2;
            ButtonArray[3] = Door3;
            ButtonArray[4] = Door4;
            ButtonArray[5] = Door5;
           // game.updateRoom(ButtonArray, 1);
            RoomNumber.Text = "Current Room: 1";
        }

        private void Door0_Click(object sender, EventArgs e)
        {
            RoomNumber.Text = "Current Room: "+ Int32.Parse(Door0.Text);
          //  game.updateRoom(ButtonArray, Int32.Parse(Door0.Text));
        }

        private void Door1_Click(object sender, EventArgs e)
        {
            RoomNumber.Text = "Current Room: " + Int32.Parse(Door1.Text);
           // game.updateRoom(ButtonArray, Int32.Parse(Door1.Text));
        }

        private void Door2_Click(object sender, EventArgs e)
        {
            RoomNumber.Text = "Current Room: " + Int32.Parse(Door2.Text);
          //  game.updateRoom(ButtonArray, Int32.Parse(Door2.Text));
        }

        private void Door3_Click(object sender, EventArgs e)
        {
            RoomNumber.Text = "Current Room: " + Int32.Parse(Door3.Text);
           // game.updateRoom(ButtonArray, Int32.Parse(Door3.Text));
        }

        private void Door4_Click(object sender, EventArgs e)
        {
            RoomNumber.Text = "Current Room: " + Int32.Parse(Door4.Text);
          //  game.updateRoom(ButtonArray, Int32.Parse(Door4.Text));
        }

        private void Door5_Click(object sender, EventArgs e)
        {
            RoomNumber.Text = "Current Room: " + Int32.Parse(Door5.Text);
          //  game.updateRoom(ButtonArray, Int32.Parse(Door5.Text));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void GetQuestion_Click(object sender, EventArgs e)
        {
            Question.Text = game.getTriviaQuestion();
        }

        private void Question_Click(object sender, EventArgs e)
        {

        }

        private void Fact_Click(object sender, EventArgs e)
        {

        }

        private void GetFact_Click(object sender, EventArgs e)
        {
            Fact.Text = game.getTriviaFact();
        }
    }
}
