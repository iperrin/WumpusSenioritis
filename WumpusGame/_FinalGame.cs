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

namespace WumpusGame
{
    public partial class _FinalGame : Form
    {

        GameControl SystemGameControl;
        public _FinalGame()
        {
            InitializeComponent();
            PictureBox[] images = new PictureBox[1];
            Button[] buttons = new Button[13];
            Label[] outputTexts = new Label[3];

            //sets texts
            outputTexts[0] = Turns;
            outputTexts[1] = Coins;
            outputTexts[2] = Arrows;

            //sets images
            images[0] = background;

            //sets buttons
            buttons[0] = StartButton;
            buttons[1] = cave1;
            buttons[2] = cave2;
            buttons[3] = cave3;
            buttons[4] = cave4;
            buttons[5] = cave5;
            buttons[6] = MainMenu;
            buttons[7] = Door0;
            buttons[8] = Door1;
            buttons[9] = Door2;
            buttons[10] = Door3;
            buttons[11] = Door4;
            buttons[12] = Door5;

            ScoreBoard.Visible = false;

            //sets images initial state
            for (int i = 0; i<images.Length; i++)
            {
                images[i].SizeMode = PictureBoxSizeMode.StretchImage;
                images[i].Visible = false;
            }
            
            //sets buttons initial view
            for (int i = 0; i<buttons.Length; i++)
            {
                buttons[i].Visible = false;
            }

            //sets labels initial view
            for(int i = 0; i<outputTexts.Length; i++)
            {
                outputTexts[i].Visible = false;
            }

            SystemGameControl = new GameControl(images, buttons, outputTexts, ScoreBoard);
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            SystemGameControl.getGraphicInterface().goMain();
        }

        private void cave1_Click(object sender, EventArgs e)
        {
            SystemGameControl.StartGame(1);
        }

        private void cave2_Click(object sender, EventArgs e)
        {
            SystemGameControl.StartGame(2);
        }

        private void cave3_Click(object sender, EventArgs e)
        {
            SystemGameControl.StartGame(3);
        }

        private void cave4_Click(object sender, EventArgs e)
        {
            SystemGameControl.StartGame(4);
        }

        private void cave5_Click(object sender, EventArgs e)
        {
            SystemGameControl.StartGame(5);
        }

        private void MainMenu_Click(object sender, EventArgs e)
        {
            SystemGameControl.getGraphicInterface().goMain();
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void _FinalGame_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
