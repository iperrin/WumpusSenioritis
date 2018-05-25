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

        Button[] buttonArray;
        PictureBox[] imageArray;

        Button[] doors;
        PictureBox background;
        Button startButton;
        Button cave1;
        Button cave2;
        Button cave3;
        Button cave4;
        Button cave5;
        Button MainMenu;
        Label Turns;
        Label Coins;
        Label Arrows;

        TextBox ScoreBoard;

        public graphicInterface(PictureBox[] images, Button[] buttons, Label[] texts, TextBox ScoreBoard){
            doors = new Button[6];
            buttonArray = buttons;
            imageArray = images;
            background = images[0];
            startButton = buttons[0];
            cave1 = buttons[1];
            cave2 = buttons[2];
            cave3 = buttons[3];
            cave4 = buttons[4];
            cave5 = buttons[5];
            doors[0] = buttons[7];
            doors[1] = buttons[8];
            doors[2] = buttons[9];
            doors[3] = buttons[10];
            doors[4] = buttons[11];
            doors[5] = buttons[12];
            MainMenu = buttons[6];
            this.ScoreBoard = ScoreBoard;
            Turns = texts[0];
            Coins = texts[1];
            Arrows = texts[2];
            hideAll();
            showLoad();
            
        }

        private void hideAll()
        {
            for(int i = 0; i<buttonArray.Length; i++)
            {
                buttonArray[i].Visible = false;
            }

            for (int i = 0; i < imageArray.Length; i++)
            {
                imageArray[i].Visible = false;
            }

            Turns.Visible = false;
            Coins.Visible = false;
            Arrows.Visible = false;
            ScoreBoard.Visible = false;
        }

        private void showLoad()
        {
            background.Image = Image.FromFile(Environment.CurrentDirectory + "\\Graphics\\Load Page.png");
            background.Visible = true;
            startButton.Visible = true;
        }

        public void goMain()
        {
            hideAll();
            background.Image = Image.FromFile(Environment.CurrentDirectory + "\\Graphics\\Menu.png");
            background.Visible = true;
            for(int i = 1; i<6; i++)
            {
                buttonArray[i].Visible = true;
            }
            displayScores();
        }

        public void loadCave(int cave)
        {
            hideAll();
            background.Image = Image.FromFile(Environment.CurrentDirectory + "\\Graphics\\Cave "+cave+".png");
            background.Visible = true;
            MainMenu.Visible = true;
            showStats();
        }
        
        //receives secret 
        public void Secret(String secret) {
		Console.WriteLine("Here's a secret for you: " + secret); 
		}

	public void pitWarning {
		Console.WriteLine("There's a pit in this room. Watch yourself!"); 
		}

	public void batWarning {
		Console.WriteLine("There are bats in this room. You have been moved to a new room!"); 
		}
		
	public void wumpusWarning {
		Console.WriteLine("You've entered a room with the wumpus. Battle commences."); 
		} 

	public void notEnoughMoney {
		Console.WriteLine("Not enough money for purchase."); 
		} 
	    
	public String ChooseAction {
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

        //shows player's turns 
        public int Turn()
        {
            return 0;
        }

        public void loadDoors(int[] caveDoors)
        {
            for (int i = 0; i < 6; i++)
                if (caveDoors[i] > 0)
                {
                    doors[i].Visible = true;
                }
                else
                {
                    doors[i].Visible = false;
                }
                    
        }

        public void hideDoors()
        {
            for(int i = 0; i<6; i++)
            {
                doors[i].Visible = false;
            }
        }

        public void showStats()
        {
            Turns.Visible = true;
            Coins.Visible = true;
            Arrows.Visible = true;
        }

    }
}
