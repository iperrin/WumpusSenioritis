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
        int[] output;
        Boolean wumpusAlive;


        public GameControl(PictureBox[] images, Label[] texts, TextBox ScoreBoard, Label[] triviaLabels, TextBox name, TextBox ScoreReport, Label[] debug)
        {
            player = new Player();
            map = new Map();
            cave = new Cave();
            trivia = new TriviaManagement();
            graphics = new graphicInterface(images, texts, ScoreBoard, triviaLabels, name, ScoreReport, debug);
            updateStats();
        }

        public void StartGame(int caveNumber)
        {
            wumpusAlive = true;
            graphics.hideScoreReport();
            output = new int[5];
            output[4] = caveNumber;
            player.Reset();
            cave.load(caveNumber);
            graphics.loadCave(caveNumber);
            trivia.Reset();
            map.Reset();
            graphics.loadDoors(cave.GetDoors(map.GetPlayerRoom()));
            runTurn();
            debug();
            graphics.hint("this is a test");
        }

        public void runTurn()
        {
            graphics.update("Click direction to move, fire an arrow, or make a purchase!");
            graphics.showCenter("Player Icon.gif");

            graphics.loadDoors(cave.GetDoors(map.currentRoom));
            graphics.showPurchases();

            

            turnStatus = "move";

            graphics.showPurchases();

            graphics.showArrowButton();
            debug();
            if (checkEndConditions())
            {
                endGame();
            }
        }

        public void giveSecret()
        {
            Random rand = new Random();
            int test = rand.Next(6);

            if(test == 0)
            {
                if (rand.Next(2) == 1)
                    graphics.update("There is a bat in room ");//get bat1 location from map
                else
                    graphics.update("There is a bat in room ");//get bat1 location from map
            }
            else if(test == 1)
            {
                if (rand.Next(2) == 1)
                    graphics.update("There is a pit in room ");//get pit1 location from map
                else
                    graphics.update("There is a pit in room ");//get pit2 location from map
            }
            else if(test == 2)
            {
                int distance = -1;
                for(int i = 0; i<6; i++)
                {
                    if (cave.GetDoors(map.GetPlayerRoom())[i] == map.GetWumpusLocation()) distance = 1;
                    for (int j = 0; j < 6; j++)
                    {
                        if (cave.GetDoors(cave.GetDoors(map.GetPlayerRoom())[i])[j] == map.GetWumpusLocation()) distance = 2;
                    }
                }
                if (distance == -1)
                    graphics.update("Wumpus is more than 2 rooms from you!");
                else
                {
                    graphics.update("Wumpus is within 2 rooms from you!");
                }


            }else if(test == 3)
            {
                graphics.update("Wumpus is in room number " + map.GetWumpusLocation());
            }else if(test == 4)
            {
                graphics.update("You are in room number " + map.GetPlayerRoom());

            }
            else
            {
                graphics.update(trivia.GetSecret());
            }
            debug();
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
            debug();
        }
       

        public Boolean checkEndConditions()
        {
            debug();
            if (player.playerTurns >= 100) return true;
            if (player.GoldCoins < 1) return true;
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
            debug();
            graphics.hidePurchases();
            int startRoom = map.GetPlayerRoom();
            int newRoom = cave.GetDoors(startRoom)[door-1];
            map.SetPlayerRoom(newRoom);
            graphics.loadDoors(cave.GetDoors(newRoom));
            
            if(map.GetPlayerRoom() == map.GetWumpusLocation())
            {
                fightWumpus();

            }

            //check hazards in room

            //check nearby hazards
            debug();
            player.GoldCoins++;
            endTurn();
        }

        public void updateStats()
        {
            graphics.updateStats(player.playerTurns, player.GoldCoins, player.Arrow);
            
            debug();
        }

        public void arrowThrow(int arrowDirection)
        {
            debug();
            if (cave.GetDoors(map.GetPlayerRoom())[arrowDirection - 1] == map.GetWumpusLocation())
            {
                Random temp = new Random();
                if(temp.Next(2) == 1)
                {
                    wumpusAlive = false;
                    endTurn();
                    endGame();
                }
                else
                {
                    int newRoom = 0;
                    while(newRoom == 0)
                    {
                        newRoom = cave.GetDoors(map.GetWumpusLocation())[temp.Next(6)];
                    }
                    map.SetWumpusLocation(newRoom);
                }
            }

            graphics.update("You missed");
            player.shotArrow();
            endTurn();
            debug();
        }

        public void arrowMode()
        {
            turnStatus = "throwArrow";
            graphics.update("Choose a direction to throw the arrow!");
            graphics.hidePurchases();
            debug();
        }

        public void endGame()
        {
            debug();
            //score turns gold arrows cave player
            graphics.goMain();
            output[1] = player.playerTurns;
            output[2] = player.GoldCoins;
            output[3] = player.Arrow;

            if (wumpusAlive)
                output[0] = 0;
            else
                output[0] = 100 - output[1] + output[2] + (10 * output[3]);
            graphics.showScoreReport(output);
            debug();
        }

        public void addScore(String name)
        {
            
            String[] scoreData = new String[6];
            scoreData[5] = name;
            for (int i = 0; i < scoreData.Length-1; i++)
                scoreData[i] = ""+output[i];
            HighScore tempScoring = new HighScore(scoreData);
            tempScoring.addScore();
            graphics.goMain();

        }

        public void direction1()
        {
            if (turnStatus.Equals("throwArrow"))
                arrowThrow(1);
            else if (turnStatus.Equals("move"))
                move(1);
            debug();
        } 

        public void direction2()
        {
            if (turnStatus.Equals("throwArrow"))
                arrowThrow(2);
            else if (turnStatus.Equals("move"))
                move(2);
            debug();
        }

        public void direction3()
        {
            if (turnStatus.Equals("throwArrow"))
                arrowThrow(3);
            else if (turnStatus.Equals("move"))
                move(3);
            debug();
        }

        public void direction4()
        {
            if (turnStatus.Equals("throwArrow"))
                arrowThrow(4);
            else if (turnStatus.Equals("move"))
                move(4);
            debug();
        }

        public void direction5()
        {
            if (turnStatus.Equals("throwArrow"))
                arrowThrow(5);
            else if (turnStatus.Equals("move"))
                move(5);
            debug();
        }

        public void direction6()
        {
            if (turnStatus.Equals("throwArrow"))
                arrowThrow(6);
            else if (turnStatus.Equals("move"))
                move(6);
            debug();
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
            debug();
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
            debug();
        }

        public void fightWumpus()
        {
            turnStatus = "fightWumpus";
            triviaScore = 0;
            triviaAsked = 0;
            triviaNumQs = 5;
            updateStats();
            loadTrivia();
            debug();
        }

        public void fellInPit()
        {
            turnStatus = "pit";
            triviaScore = 0;
            triviaAsked = 0;
            triviaNumQs = 3;
            updateStats();
            loadTrivia();
            debug();
        }

        public void foundBat()
        {
            
            Random rand = new Random();
            map.SetPlayerRoom(1 + rand.Next(30));

            //set new bat location

            debug();
        }

        public void winTrivia()
        {
            debug();
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
            debug();
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
            debug();
        }

        private void loadTrivia()
        {
            graphics.hideDoors();
            graphics.hidePurchases();
            graphics.hideArrowButton();
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
            }else if(triviaAsked >= triviaNumQs)
            {
                lostTrivia();
            }else
                loadTrivia();
        }

        public void debug()
        {
            String[] data = new String[6];

            data[0] = "" + map.GetPlayerRoom();
            data[1] = "" + map.GetWumpusLocation();
            data[2] = "" + map.;
            data[3] = "";
            data[4] = "";
            data[5] = "";

            graphics.debug(data);
        }

    }
}