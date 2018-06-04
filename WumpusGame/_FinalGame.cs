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
using System.Media;

namespace WumpusGame
{
    public partial class _FinalGame : Form
    {

        GameControl SystemGameControl;
        public _FinalGame()
        {

            InitializeComponent();

            PictureBox[] images = new PictureBox[19];
            Label[] outputTexts = new Label[5];
            Label[] trivia = new Label[5];

            trivia[0] = Question;
            trivia[1] = A;
            trivia[2] = B;
            trivia[3] = C;
            trivia[4] = D;

            //sets texts
            outputTexts[0] = Turns;
            outputTexts[1] = Coins;
            outputTexts[2] = Arrows;
            outputTexts[3] = Hint;
            outputTexts[4] = Update;

            //sets images
            images[0] = background;
            images[1] = start;
            images[2] = MainMenu;
            images[3] = exit;
            images[4] = cave1;
            images[5] = cave2;
            images[6] = cave3;
            images[7] = cave4;
            images[8] = cave5;
            images[9] = door1;
            images[10] = door2;
            images[11] = door3;
            images[12] = door4;
            images[13] = door5;
            images[14] = door6;
            images[15] = buyArrows;
            images[16] = buySecrets;
            images[17] = shootArrow;
            images[18] = hazard;

            ScoreBoard.Visible = false;

            for(int i = 0; i<trivia.Length; i++)
            {
                background.Controls.Add(trivia[i]);
                trivia[i].Visible = false;
                trivia[i].BackColor = Color.Transparent;
            }

            //sets images initial state
            for (int i = 0; i<images.Length; i++)
            {
                images[i].SizeMode = PictureBoxSizeMode.StretchImage;
                images[i].Visible = false;
            }

            for(int i = 1; i<images.Length; i++)
            {
                images[0].Controls.Add(images[i]);
                images[i].BackColor = Color.Transparent;
            }

            for(int i = 0; i<3; i++)
            {
                outputTexts[i].BackColor = Color.Transparent;
                background.Controls.Add(outputTexts[i]);
            }
            
            //sets labels initial view
            for(int i = 0; i<outputTexts.Length; i++)
            {
                outputTexts[i].Visible = false;
            }

            SystemGameControl = new GameControl(images, outputTexts, ScoreBoard, trivia);
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            SystemGameControl.graphics.goMain();
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
            SystemGameControl.graphics.goMain();
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

        private void MainMenu_Click_1(object sender, EventArgs e)
        {
            SystemGameControl.graphics.goMain();
        }

        private void start_Click(object sender, EventArgs e)
        {
            SystemGameControl.graphics.goMain();
        }

        private void exit_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void cave1_Click_1(object sender, EventArgs e)
        {
            SystemGameControl.StartGame(1);
        }

        private void cave2_Click_1(object sender, EventArgs e)
        {
            SystemGameControl.StartGame(2);
        }

        private void cave3_Click_1(object sender, EventArgs e)
        {
            SystemGameControl.StartGame(3);
        }

        private void cave4_Click_1(object sender, EventArgs e)
        {
            SystemGameControl.StartGame(4);
        }

        private void cave5_Click_1(object sender, EventArgs e)
        {
            SystemGameControl.StartGame(5);
        }

        private void buyArrows_Click(object sender, EventArgs e)
        {
            SystemGameControl.buyArrow();
        }

        private void buySecrets_Click(object sender, EventArgs e)
        {
            SystemGameControl.buySecret();
        }

        private void door2_Click_1(object sender, EventArgs e)
        {
            SystemGameControl.direction2();
        }

        private void door3_Click_1(object sender, EventArgs e)
        {
            SystemGameControl.direction3();
        }

        private void door4_Click_1(object sender, EventArgs e)
        {
            SystemGameControl.direction4();
        }

        private void background_Click(object sender, EventArgs e)
        {

        }

        private void door1_Click_1(object sender, EventArgs e)
        {
            SystemGameControl.direction1();
        }

        private void door6_Click(object sender, EventArgs e)
        {
            SystemGameControl.direction6();
        }

        private void door5_Click_1(object sender, EventArgs e)
        {
            SystemGameControl.direction5();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void A_Click(object sender, EventArgs e)
        {
            SystemGameControl.selectA();
        }

        private void B_Click(object sender, EventArgs e)
        {
            SystemGameControl.selectB();
        }

        private void C_Click(object sender, EventArgs e)
        {
            SystemGameControl.selectC();
        }

        private void D_Click(object sender, EventArgs e)
        {
            SystemGameControl.selectD();
        }
    }
}
