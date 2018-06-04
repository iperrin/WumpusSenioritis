﻿using System;
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


        PictureBox[] doors;
        PictureBox background;

        TextBox ScoreBoard;

        Label Turns;
        Label Coins;
        Label Arrows;
        Label Hint;
        Label Instructions;

        public graphicInterface(PictureBox[] images, Label[] texts, TextBox ScoreBoard, Label[] trivia){
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

        private void hideAll()
        {
            for(int i = 0; i<images.Length; i++)
            {
                images[i].Visible = false;
            }

            for (int i = 0; i < texts.Length; i++)
            {
                texts[i].Visible = false;
            }

            for(int i = 0; i<trivia.Length; i++)
            {
                trivia[i].Visible = false;
                trivia[i].Text = " ";
            }

            ScoreBoard.Visible = false;
        }

        private void showLoad()
        {
            background.Image = Image.FromFile(Environment.CurrentDirectory + "\\Graphics\\Load Page.png");
            background.Visible = true;
            images[1].Visible = true;
            images[3].Visible = true;
        }

        public void goMain()
        {
            hideAll();
            background.Image = Image.FromFile(Environment.CurrentDirectory + "\\Graphics\\Menu.png");
            background.Visible = true;
            for(int i = 4; i<9; i++)
            {
                images[i].Visible = true;
            }
            displayScores();
            images[3].Visible = true;
        }

        public void loadCave(int cave)
        {
            hideAll();
            background.Image = Image.FromFile(Environment.CurrentDirectory + "\\Graphics\\Cave "+cave+".png");
            background.Visible = true;
            images[2].Visible = true;
            images[3].Visible = true;
            showStats();
            images[17].Visible = true;
        }

        public void updateStats(int turns, int coins, int arrows)
        {
            this.Turns.Text = ""+turns;
            this.Coins.Text = ""+coins;
            this.Arrows.Text = "" + arrows;

        }

        public void showPurchase()
        {
            images[15].Visible = true;
            images[16].Visible = true;
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

        public void showStats()
        {
            Turns.Visible = true;
            Coins.Visible = true;
            Arrows.Visible = true;
        }

        public void showCenter(String item)
        {
            images[18].Image = Image.FromFile(Environment.CurrentDirectory + "\\graphics\\"+item);
            images[18].Visible = true;
        }

    }
}
