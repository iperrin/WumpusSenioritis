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
        }

        //starts the game
        public void StartGame(int caveNumber)
        {
            wumpusAlive = true;

            //creates output array for game data and saves cave file
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
        }

        public void runTurn()
        {
            graphics.startMove();
            graphics.update("Click direction to move, fire an arrow, or make a purchase!");
            graphics.showCenter("Player Icon.gif");
            graphics.loadDoors(cave.GetDoors(map.currentRoom));
            turnStatus = "move";
            debug();

            //check for wumpus overlap
            //check for hazards

            if (checkEndConditions())
            {
                endGame();
            }
        }

        public String giveSecret()
        {
            Random rand = new Random();
            int test = rand.Next(6);

            if(test == 0)
            {
                if (rand.Next(2) == 1)
                    return ("There is a bat in room " + map.getBat1Location());
                else
                    return ("There is a bat in room " + map.getBat2Location());
            }
            else if(test == 1)
            {
                if (rand.Next(2) == 1)
                    return ("There is a pit in room " + map.getPit1Location());
                else
                    return ("There is a pit in room " + map.getPit2Location());
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
                    return ("Wumpus is more than 2 rooms from you!");
                else
                {
                    return ("Wumpus is within 2 rooms from you!");
                }


            }else if(test == 3)
            {
                return ("Wumpus is in room number " + map.GetWumpusLocation());
            }else if(test == 4)
            {
                return ("You are in room number " + map.GetPlayerRoom());

            }
            else
            {
                return (trivia.GetSecret());
            }
            debug();
        }

        public void endTurn()
        {
            player.incrementTurn();
            updateStats();
            runTurn();
            debug();
        }
       
        public Boolean checkEndConditions()
        {
            debug();
            if (player.playerTurns >= 100) return true;
            if (player.GoldCoins < 1) return true;
            if (player.Arrow < 1) return true;
            if (!wumpusAlive) return true;
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
            int startRoom = map.GetPlayerRoom();
            int newRoom = cave.GetDoors(startRoom)[door-1];
            map.SetPlayerRoom(newRoom);
            graphics.loadDoors(cave.GetDoors(newRoom));
            player.GoldCoins++;
            graphics.hint(getTriviaFact());
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
                wumpusAlive = false;
                endTurn();
                return;
            }
            else
            {
                //wumpus might run into an adjacent room
                graphics.hint("Oh no! You Missed, better luck next time");
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
            graphics.arrowMode();
            graphics.loadDoors(cave.GetDoors(map.GetPlayerRoom()));
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
            else 
                move(1);
            debug();
        } 

        public void direction2()
        {
            if (turnStatus.Equals("throwArrow"))
                arrowThrow(2);
            else 
                move(2);
            debug();
        }

        public void direction3()
        {
            if (turnStatus.Equals("throwArrow"))
                arrowThrow(3);
            else 
                move(3);
            debug();
        }

        public void direction4()
        {
            if (turnStatus.Equals("throwArrow"))
                arrowThrow(4);
            else 
                move(4);
            debug();
        }

        public void direction5()
        {
            if (turnStatus.Equals("throwArrow"))
                arrowThrow(5);
            else 
                move(5);
            debug();
        }

        public void direction6()
        {
            if (turnStatus.Equals("throwArrow"))
                arrowThrow(6);
            else 
                move(6);
            debug();
        }

        public void buySecret()
        {
            turnStatus = "buySecret";
            graphics.update("Get 2/3 trivia right to get a secret");
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
            graphics.hint("get 2/3 right to get some arrows");
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
                graphics.hint("Good job, did you know  " + giveSecret());
                
            }
            if (turnStatus.Equals("buyArrow"))
            {
                player.GiveArrows();
                graphics.hint("Good job, here are some arrows");
                
            }
            if (turnStatus.Equals("fightWumpus"))
            {
                //wumpus runs away
                graphics.hint("You survived the Wumpus encounter! He ran away, but happy hunting!");
            }
            if (turnStatus.Equals("pit"))
            {
                map.SetPlayerRoom(1);
                graphics.hint("You survived the pit! Wecome back to the start!");
                
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
                graphics.hint("Sorry, better luck next time");
                endTurn();
            }
            else
            {
                endGame();
            }
            debug();
        }

        public void loadTrivia()
        {
            graphics.TriviaMode();
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
            data[2] = "" + map.getBat1Location();
            data[3] = "" + map.getBat2Location();
            data[4] = "" + map.getPit1Location();
            data[5] = "" + map.getPit2Location();

            graphics.debug(data);
        }

    }
}