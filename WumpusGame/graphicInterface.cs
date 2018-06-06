using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using WumpusGame;
using System.Windows.Forms;

namespace WumpusGame
{
    public class graphicInterface
    {
        


        PictureBox[] images;
        Label[] texts;
        Label[] trivia;

        //debug buttons
        Label[] debugLabels;

        PictureBox[] doors;
        PictureBox background;

        TextBox ScoreBoard;

        Label Turns;
        Label Coins;
        Label Arrows;
        Label Hint;
        Label Instructions;

        TextBox name;
        TextBox ScoreReport;

        public graphicInterface(PictureBox[] images, Label[] texts, TextBox ScoreBoard, Label[] trivia, TextBox name, TextBox ScoreReport, Label[] debug){

            debugLabels = debug;

            this.name = name;
            this.ScoreReport = ScoreReport;

            doors = new PictureBox[13];

            this.images = images;
            this.texts = texts;
            background = images[0];
            this.trivia = trivia;


            doors[0] = images[9];
            doors[1] = images[10];
            doors[2] = images[11];
            doors[3] = images[12];
            doors[4] = images[13];
            doors[5] = images[14];
            this.ScoreBoard = ScoreBoard;
            Turns = texts[0];
            Coins = texts[1];
            Arrows = texts[2];
            Hint = texts[3];
            Instructions = texts[4];
            

            setDirectory();

            hideAll();
            showLoad();

        }

        //major private methods

        private void setDirectory()
        {
            images[0].Image = Image.FromFile(Environment.CurrentDirectory + "\\graphics\\Load Page.png");
            images[1].Image = Image.FromFile(Environment.CurrentDirectory + "\\graphics\\Start Button (Load).png");
            images[2].Image = Image.FromFile(Environment.CurrentDirectory + "\\graphics\\smallMenu.png");
            images[3].Image = Image.FromFile(Environment.CurrentDirectory + "\\graphics\\smallExit.png");
            images[4].Image = Image.FromFile(Environment.CurrentDirectory + "\\graphics\\Start Button (Load).png");
            images[5].Image = Image.FromFile(Environment.CurrentDirectory + "\\graphics\\Start Button (Load).png");
            images[6].Image = Image.FromFile(Environment.CurrentDirectory + "\\graphics\\Start Button (Load).png");
            images[7].Image = Image.FromFile(Environment.CurrentDirectory + "\\graphics\\Start Button (Load).png");
            images[8].Image = Image.FromFile(Environment.CurrentDirectory + "\\graphics\\Start Button (Load).png");
            images[9].Image = Image.FromFile(Environment.CurrentDirectory + "\\graphics\\1.png");
            images[10].Image = Image.FromFile(Environment.CurrentDirectory + "\\graphics\\2.png");
            images[11].Image = Image.FromFile(Environment.CurrentDirectory + "\\graphics\\3.png");
            images[12].Image = Image.FromFile(Environment.CurrentDirectory + "\\graphics\\4.png");
            images[13].Image = Image.FromFile(Environment.CurrentDirectory + "\\graphics\\5.png");
            images[14].Image = Image.FromFile(Environment.CurrentDirectory + "\\graphics\\6.png");
            images[15].Image = Image.FromFile(Environment.CurrentDirectory + "\\graphics\\buyArrows.png");
            images[16].Image = Image.FromFile(Environment.CurrentDirectory + "\\graphics\\buySecret.png");
            images[17].Image = Image.FromFile(Environment.CurrentDirectory + "\\graphics\\shootArrow.png");
            images[18].Image = Image.FromFile(Environment.CurrentDirectory + "\\graphics\\Player Icon.gif");
            images[19].Image = Image.FromFile(Environment.CurrentDirectory + "\\graphics\\Player Icon.gif");

        }

        private void hideAll()
        {
            for (int i = 0; i < images.Length; i++)
            {
                images[i].Visible = false;
            }

            for (int i = 0; i < texts.Length; i++)
            {
                texts[i].Visible = false;
            }

            for (int i = 0; i < trivia.Length; i++)
            {
                trivia[i].Visible = false;
                trivia[i].Text = " ";
            }

            ScoreBoard.Visible = false;
            name.Visible = false;
            ScoreReport.Visible = false;

        }

        //pages

        //loading page
        public void showLoad()
        {
            hideAll();
            background.Image = Image.FromFile(Environment.CurrentDirectory + "\\Graphics\\Load Page.png");
            background.Visible = true;
            images[1].Visible = true;
            images[3].Visible = true;
        }

        //main menu
        public void goMain()
        {
            hideAll();
            background.Image = Image.FromFile(Environment.CurrentDirectory + "\\Graphics\\Menu.png");
            background.Visible = true;
            for (int i = 4; i < 9; i++)
            {
                images[i].Visible = true;
            }
            displayScores();
            images[3].Visible = true;
        }

        //startgame
        public void loadCave(int cave)
        {
            hideAll();
            background.Image = Image.FromFile(Environment.CurrentDirectory + "\\Graphics\\Cave " + cave + ".png");
            background.Visible = true;
            images[2].Visible = true;
            images[3].Visible = true;
            Turns.Visible = true;
            Coins.Visible = true;
            Arrows.Visible = true;
            images[17].Visible = true;
        }




        //hides all move related things to 
        public void hideMoveEntities()
        {
            hideTrivia();
            hideDoors();
            hideTrivia();
        }


        public void hidePurchases()
        {
            images[15].Visible = false;
            images[16].Visible = false;
        }

        public void showPurchases()
        {
            images[15].Visible = true;
            images[16].Visible = true;
        }

        public void update(String input)
        {
            Instructions.Text = input;
            Instructions.Visible = true;
        }

        
        public void hideScoreReport()
        {
            images[19].Visible = false;
            name.Visible = false;
            ScoreReport.Visible = false;
        }

        public void showScoreReport(int[] input)
        {
            //score turns gold arrows cave player

            name.Visible = true;
            name.Text = "Name";
            images[19].Visible = true;
            ScoreReport.Visible = true;
            ScoreReport.Text = "Score: " + input[0] + "\r\nTurns: " + input[1] + "\r\nGold: " + input[2] + "\r\nArrows: " + input[3] + "\r\nCave: " + input[4];
        }

        public void hint(String input)
        {
            Hint.Text = input;
            Hint.Visible = true;
        }

        public void hideArrowButton()
        {
            images[17].Visible = false;
        }

        public void showArrowButton()
        {
            images[17].Visible = true;
        }

        

        

        

        public void updateStats(int turns, int coins, int arrows)
        {
            this.Turns.Text = ""+turns;
            this.Coins.Text = ""+coins;
            this.Arrows.Text = "" + arrows;

        }

        public void loadTrivia(String[] input)
        {
            for(int i = 0; i<trivia.Length; i++)
            {
                trivia[i].Text = input[i];
                trivia[i].Visible = true;
            }
        }

        public void hideTrivia()
        {
            for(int i = 0; i < trivia.Length; i++)
            {
                trivia[i].Visible = false;
            }
        }

        public void displayScores()
        {
            String[] scores = HighScore.GetHighScores();

            ScoreBoard.Text = "SCORE    TURNS      GOLD      ARROWS      CAVE       PLAYER\r\n";
            int count = 0;

            for (int c = 0; c < 10; c++) {
                for (int i = 0; i < 6; i++)
                {
                    ScoreBoard.Text += (scores[count]+"           ");
                    count++;
                }
                ScoreBoard.Text += "\r\n";
            }
            ScoreBoard.Visible = true;

        }
        
        public void loadDoors(int[] caveDoors)
        {
            for (int i = 0; i < 6; i++)
                if (caveDoors[i] > 0)
                {
                    doors[i].Visible = true;
                    doors[i].Enabled = true;
                }
                else
                {
                    doors[i].Visible = false;
                    doors[i].Enabled = false;
                }
                    
        }

        public void hideDoors()
        {
            for(int i = 0; i<6; i++)
            {
                doors[i].Visible = false;
            }
        }

        

        public void showCenter(String item)
        {
            images[18].Image = Image.FromFile(Environment.CurrentDirectory + "\\graphics\\"+item);
            images[18].Visible = true;
        }

        public void debug(String[] data)
        {
            //update player

            if(data[0] == null)
            {
                debugLabels[0].Text = "null";
            }
            else
            {
                debugLabels[0].Text = data[0];
            }

            //update wumpus

            if (data[1] == null)
            {
                debugLabels[1].Text = "null";
            }
            else
            {
                debugLabels[1].Text = data[1];
            }

            //update bat 1

            if (data[2] == null)
            {
                debugLabels[2].Text = "null";
            }
            else
            {
                debugLabels[2].Text = data[2];
            }

            //update bat 2

            if (data[3] == null)
            {
                debugLabels[3].Text = "null";
            }
            else
            {
                debugLabels[3].Text = data[3];
            }

            //update pit 1

            if (data[4] == null)
            {
                debugLabels[4].Text = "null";
            }
            else
            {
                debugLabels[4].Text = data[4];
            }

            //update pit 2

            if (data[5] == null)
            {
                debugLabels[5].Text = "null";
            }
            else
            {
                debugLabels[5].Text = data[5];
            }

        }

        /*
        //receives secret 
        public void Secret(String secret) {
		Console.WriteLine("Here's a secret for you: " + secret); 
		}

	public void pitWarning (){
		Console.WriteLine("There's a pit in this room. Watch yourself!"); 
		}

	public void batWarning() {
		Console.WriteLine("There are bats in this room. You have been moved to a new room!"); 
		}
		
	public void wumpusWarning (){
		Console.WriteLine("You've entered a room with the wumpus. Battle commences."); 
		} 

	public void notEnoughMoney (){
		Console.WriteLine("Not enough money for purchase."); 
		} 
	    
	public String ChooseAction() {
            String[] action = {"move", "shoot", "purchase arrow", "purchase secret" }; 
            Console.WriteLine("Which action will you choose?"); 
            Console.WriteLine("A. Move"); 
            Console.WriteLine("B. Shoot arrow"); 
            Console.WriteLine("C. Purchase arrow"); 
            Console.WriteLine("D. Purchase secret"); 

            String choice = Console.ReadLine(); 
            
            while (choice == null) {
                choice = Console.ReadLine(); 
            }
            if(choice.Equals("A") || choice.Equals ("a")) 
                return action[0]; 
            
            else if(choice.Equals("B") || choice.Equals ("b"))
                return action[1];  

            else if(choice.Equals("B") || choice.Equals ("b"))
                return action[1];  

            else if(choice.Equals("C") || choice.Equals ("c"))
                return action[2]; 

            else if(choice.Equals("D") || choice.Equals ("d"))
                return action[3]; 

            else 
                return ChooseAction();   
        }

        //Displays to user the current stats of gold coins, arrows, trivia pieces 
        public String Inventory()
        {
            return null;
        }

        //Shows possible action that user can take to move (move, shoot arrow, purchase arrow/secret) 
        public void Action()
        {

        }

        //if user encounters hallway, feed trivia piece 
        public void WalkThrough(Boolean door)
        {
            if (door)
            {
                //call Trivia method that delivers Trivia to users if door = true (user walks through door)  
            }
        }

        //displays current room user is in 
        public void Room()
        {

        }
        */

    }
}
