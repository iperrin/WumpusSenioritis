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
    public class GameControl
    {
        int triviaScore;
        int triviaAsked;
        int triviaNumQs;

        Player player;
        Map map;
        TriviaManagement trivia;
        Cave cave;
        public graphicInterface graphics;
        public string name;
        public int level;
        String turnStatus;


        public GameControl(PictureBox[] images, Label[] texts, TextBox ScoreBoard, Label[] triviaLabels)
        {
            player = new Player();
            map = new Map();
            cave = new Cave();
            trivia = new TriviaManagement();
            graphics = new graphicInterface(images, texts, ScoreBoard, triviaLabels);
            updateStats();
        }

        public void StartGame(int caveNumber)
        {
            Boolean run = true;
            player.Reset();
            cave.load(caveNumber);
            graphics.loadCave(caveNumber);
            trivia.Reset();
            map.Reset();
            graphics.loadDoors(cave.GetDoors(map.GetPlayerRoom()));
            runTurn();
        }

        public void runTurn()
        {
            graphics.update("Click Arrow to move, fire an arrow, or make a purchase!");
            graphics.showCenter("Player Icon.gif");

            giveSecret();

            if (checkEndConditions())
            {
                endGame();
            }

            turnStatus = "move";

            graphics.showPurchase();

            //graphics displays 
        }

        public void giveSecret()
        {
            Random rand = new Random();
            int test = rand.Next(6);

            if(test == 0)
            {
                //bat room number
            }else if(test == 1)
            {
                //pit room number
            }else if(test == 2)
            {
                //is wumpus withing 2 rooms?
            }else if(test == 3)
            {
                //room # of wumpus
            }else if(test == 4)
            {
                //current room number
            }
            else
            {
                //trivia secret
            }

        }

        public void endTurn()
        {
            player.incrementTurn();
            updateStats();
            if (checkEndConditions())
            {
                endGame();
            }
            runTurn();
        }

        public Boolean checkEndConditions()
        {
            if(player.playerTurns >= 100) return true;
            if (player.Arrow < 1) return true;
            return false;
        }

        public String getTriviaQuestion()
        {
            return trivia.GetNextQuestion();
        }

        public String getTriviaFact()
        {
            return trivia.GetNextFact();
        }


        public void move(int door)
        {
            graphics.hidePurchases();
            int startRoom = map.GetPlayerRoom();
            int newRoom = cave.GetDoors(startRoom)[door-1];
            map.SetPlayerRoom(newRoom);
            graphics.loadDoors(cave.GetDoors(newRoom));
            
            //check wumpus

            //check hazards in room

            //check nearby hazards
            player.GoldCoins++;
            endTurn();
        }

        public void updateStats()
        {
            graphics.updateStats(player.playerTurns, player.GoldCoins, player.Arrow);
            graphics.showStats();
        }

        public void arrowThrow(int arrowDirection)
        {
            //check wumpus impact
            player.shotArrow();
            endTurn();
        }

        public void arrowMode()
        {
            turnStatus = "throwArrow";
            graphics.update("Choose a direction to throw the arrow!");
            graphics.hidePurchases();
        }

        private void endGame()
        {
            //add player data to high score
            //send high score data to GUI for display
        }

        public void direction1()
        {
            if (turnStatus.Equals("throwArrow"))
                arrowThrow(1);
            else if (turnStatus.Equals("move"))
                move(1);
                
        } 

        public void direction2()
        {
            if (turnStatus.Equals("throwArrow"))
                arrowThrow(2);
            else if (turnStatus.Equals("move"))
                move(2);

        }

        public void direction3()
        {
            if (turnStatus.Equals("throwArrow"))
                arrowThrow(3);
            else if (turnStatus.Equals("move"))
                move(3);

        }

        public void direction4()
        {
            if (turnStatus.Equals("throwArrow"))
                arrowThrow(4);
            else if (turnStatus.Equals("move"))
                move(4);

        }

        public void direction5()
        {
            if (turnStatus.Equals("throwArrow"))
                arrowThrow(5);
            else if (turnStatus.Equals("move"))
                move(5);
        }

        public void direction6()
        {
            if (turnStatus.Equals("throwArrow"))
                arrowThrow(6);
            else if (turnStatus.Equals("move"))
                move(6);
        }

        public void buySecret()
        {
            turnStatus = "buySecret";
            triviaScore = 0;
            triviaAsked = 0;
            triviaNumQs = 3;
            player.Buy();
            updateStats();
            loadTrivia();
        }

        public void buyArrow()
        {
            turnStatus = "buyArrow";
            triviaScore = 0;
            triviaAsked = 0;
            triviaNumQs = 3;
            player.Buy();
            updateStats();
            loadTrivia();
        }

        public void fightWumpus()
        {
            turnStatus = "fightWumpus";
            triviaScore = 0;
            triviaAsked = 0;
            triviaNumQs = 5;
            updateStats();
            loadTrivia();
        }

        public void fellInPit()
        {
            turnStatus = "pit";
            triviaScore = 0;
            triviaAsked = 0;
            triviaNumQs = 3;
            updateStats();
            loadTrivia();
        }

        public void foundBat()
        {
            turnStatus = "bat";
            triviaScore = 0;
            triviaAsked = 0;
            triviaNumQs = 3;
            updateStats();
            loadTrivia();
        }

        public void winTrivia()
        {
            if (turnStatus.Equals("buySecret"))
            {
                giveSecret();
                
            }
            if (turnStatus.Equals("buyArrow"))
            {
                player.GiveArrows();
                
            }
            if (turnStatus.Equals("fightWumpus"))
            {
                //wumpus runs away
                
            }
            if (turnStatus.Equals("pit"))
            {
                map.SetPlayerRoom(1);
                
            }
            if (turnStatus.Equals("bat"))
            {
                Random rand = new Random();
                map.SetPlayerRoom(1 + rand.Next(30));
                
            }
            graphics.hideTrivia();
            endTurn();
        }

        public void lostTrivia()
        {
            graphics.hideTrivia();
            if (turnStatus.Equals("buySecret") || turnStatus.Equals("buyArrow"))
            {
                endTurn();
            }
            else
            {
                endGame();
            }
        }

        private void loadTrivia()
        {
            graphics.hideDoors();
            graphics.hidePurchases();
            updateStats();
            String temp = trivia.GetNextQuestion();
            String[] inputs = new String[5];

            for(int i = 0; i<4; i++)
            {
                inputs[i] = temp.Substring(0, temp.IndexOf(" ("));
                temp = temp.Substring(inputs[i].Length+2);
            }

            inputs[4] = temp;

            graphics.loadTrivia(inputs);
        }

        public void selectA()
        {
            triviaResponse("A");
        }

        public void selectB()
        {
            triviaResponse("B");
        }

        public void selectC()
        {
            triviaResponse("C");
        }

        public void selectD()
        {
            triviaResponse("D");
        }

        public void triviaResponse(String answer)
        {
            if (trivia.CorrectAnswer(answer))
            {
                triviaScore++;
                triviaAsked++;
            }else
                triviaAsked++;

            if((triviaNumQs == 3 && triviaScore > 1) || (triviaNumQs == 5 && triviaScore>2))
            {
                winTrivia();
            }

            if(triviaAsked == triviaNumQs)
            {
                lostTrivia();
            }

            if(triviaAsked<triviaNumQs)
                loadTrivia();
        }

    }
}