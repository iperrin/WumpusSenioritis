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
        Sound sounds;

        //constructor runs constructors of class objects and passes all the form variables to the graphics interface
        public GameControl(PictureBox[] images, Label[] texts, TextBox ScoreBoard, Label[] triviaLabels, TextBox name, TextBox ScoreReport, Label[] debug)
        {
            player = new Player();
            sounds = new Sound();
            map = new Map();
            cave = new Cave();
            trivia = new TriviaManagement();
            graphics = new graphicInterface(images, texts, ScoreBoard, triviaLabels, name, ScoreReport, debug);
        }

        //starts the game and loads classes and graphics
        public void StartGame(int caveNumber)
        {
            wumpusAlive = true;
            sounds = new Sound();

            //creates output array for game data and saves cave file
            output = new int[5];
            output[4] = caveNumber;

            player = new Player();
            cave.load(caveNumber);
            graphics.loadCave(caveNumber);
            trivia.Reset();
            map.Reset();
            graphics.loadDoors(cave.GetDoors(map.GetPlayerRoom()));
            graphics.update("");
            graphics.update("");
            turnStatus = "";
            updateStats();
            runTurn();
            debug();
        }

        //start turn method sets up graphics and gives basic instructions, also checks end conditions and overlaps with hazards and/or wumpus
        public void runTurn()
        {
            graphics.startMove();
            if(!turnStatus.Equals("buySecret"))
                graphics.hint("");
            if (turnStatus == "move")
                graphics.hint(getTriviaFact());
            graphics.update("Click direction to move, fire an arrow, or make a purchase!");
            graphics.showCenter("Player Icon.gif");
            graphics.loadDoors(cave.GetDoors(map.currentRoom));
            turnStatus = "move";
            debug();
            if (checkEndConditions())
            {
                endGame();
            }

            if (map.GetPlayerRoom() == map.GetWumpusLocation())
            {
                fightWumpus();
                return;
            }

            if (map.GetPlayerRoom() == map.getPit1Location() || map.GetPlayerRoom() == map.getPit2Location())
            {
                fellInPit();
                return;
            }

            if (map.GetPlayerRoom() == map.getBat1Location() || map.GetPlayerRoom() == map.getBat2Location())
            {
                foundBat();
                return;
            }

            nearbyHazards();

        }

        //selects a random secret and then sends to graphics for viewing
        public String giveSecret()
        {
            Random rand = new Random();
            int test = rand.Next(0,6);

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
                if (trivia.IsWrongAnswersEmpty())
                {
                    return giveSecret();
                }
                return (trivia.GetSecret());
            }
            debug();
        }

        //updates statistics at the end of turn and initiates the next turn
        public void endTurn()
        {
            player.incrementTurn();
            updateStats();
            runTurn();
            debug();
        }
       
        //checks whether the game is over or not
        public Boolean checkEndConditions()
        {
            debug();
            if (player.playerTurns >= 100) return true;
            if (player.GoldCoins < 1) return true;
            if (player.Arrow < 1) return true;
            if (!wumpusAlive) return true;
            return false;
        }

        //interfaces with the trivia class to get questions
        public String getTriviaQuestion()
        {
            return trivia.GetNextQuestion();
        }

        //interfaces with the trivia class to get questions
        public String getTriviaFact()
        {
            return trivia.GetNextFact();
        }

        //updates system and finds new door when player moves
        public void move(int door)
        {
            sounds.playOnMove();
            debug();
            int startRoom = map.GetPlayerRoom();
            int newRoom = cave.GetDoors(startRoom)[door-1];
            graphics.showCenter("Player Icon.gif");
            map.SetPlayerRoom(newRoom);
            graphics.loadDoors(cave.GetDoors(newRoom));
            player.GoldCoins++;
            endTurn();
        }

        //gets player info and updates graphics
        public void updateStats()
        {
            graphics.updateStats(player.playerTurns, player.GoldCoins, player.Arrow);
            
            debug();
        }

        //finds location of arrow throw and checks for wumpus impact, then acts accordingly
        public void arrowThrow(int arrowDirection)
        {
            sounds.playOnShoot();
            debug();
            if (cave.GetDoors(map.GetPlayerRoom())[arrowDirection - 1] == map.GetWumpusLocation())
            {
                wumpusAlive = false;
                endTurn();
                return;
            }
            else
            {
                Random temp = new Random();
                if(temp.Next(0,2) == 0)
                {
                    map.SetWumpusLocation(cave.getRandomDoor(map.GetWumpusLocation()));
                    sounds.playOnWumpusMove();
                }
                    
                graphics.hint("Oh no! You Missed, better luck next time");
            }

            graphics.update("You missed");
            player.shotArrow();
            endTurn();
            debug();
        }

        //sets UI and turn status when the player decides to throw an arrow
        public void arrowMode()
        {
            turnStatus = "throwArrow";
            graphics.update("Choose a direction to throw the arrow!");
            graphics.arrowMode();
            graphics.loadDoors(cave.GetDoors(map.GetPlayerRoom()));
            debug();
        }

        //calculates score and goes to main menu
        public void endGame()
        {
            debug();

            //score turns gold arrows cave player
            graphics.goMain();
            output[1] = player.playerTurns;
            output[2] = player.GoldCoins;
            output[3] = player.Arrow;

            if (wumpusAlive)
            {
                output[0] = 0;
                sounds.playOnWin();
            }
            else
            {
                output[0] = 100 - output[1] + output[2] + (10 * output[3]);
                sounds.playOnWin();
            }
            graphics.showScoreReport(output);
            debug();
        }

        //adds score to the highscore object and upates leaderboard appropriately
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

        //either throws arrow or moves depending on turnStatus if direction 1 is pressed
        public void direction1()
        {
            if (turnStatus.Equals("throwArrow"))
                arrowThrow(1);
            else 
                move(1);
            debug();
        }

        //either throws arrow or moves depending on turnStatus if direction 2 is pressed
        public void direction2()
        {
            if (turnStatus.Equals("throwArrow"))
                arrowThrow(2);
            else 
                move(2);
            debug();
        }

        //either throws arrow or moves depending on turnStatus if direction 3 is pressed
        public void direction3()
        {
            if (turnStatus.Equals("throwArrow"))
                arrowThrow(3);
            else 
                move(3);
            debug();
        }

        //either throws arrow or moves depending on turnStatus if direction 4 is pressed
        public void direction4()
        {
            if (turnStatus.Equals("throwArrow"))
                arrowThrow(4);
            else 
                move(4);
            debug();
        }

        //either throws arrow or moves depending on turnStatus if direction 5 is pressed
        public void direction5()
        {
            if (turnStatus.Equals("throwArrow"))
                arrowThrow(5);
            else 
                move(5);
            debug();
        }

        //either throws arrow or moves depending on turnStatus if direction 6 is pressed
        public void direction6()
        {
            if (turnStatus.Equals("throwArrow"))
                arrowThrow(6);
            else 
                move(6);
            debug();
        }

        //sets interface and turn status if buySecret is chosen
        public void buySecret()
        {
            turnStatus = "buySecret";
            graphics.update("Get 2/3 trivia right to get a secret");
            triviaScore = 0;
            triviaAsked = 0;
            triviaNumQs = 3;
            updateStats();
            loadTrivia();
            debug();
        }

        //sets interface and turn status if buyArriw us chosen
        public void buyArrow()
        {
            turnStatus = "buyArrow";
            graphics.hint("get 2/3 right to get some arrows");
            triviaScore = 0;
            triviaAsked = 0;
            triviaNumQs = 3;
            updateStats();
            loadTrivia();
            debug();
        }

        //sets interface and turn status if a wumpus encounter happens
        public void fightWumpus()
        {
            turnStatus = "fightWumpus";
            triviaScore = 0;
            triviaAsked = 0;
            triviaNumQs = 5;
            updateStats();
            loadTrivia();
            graphics.showCenter("Wumpus.png");
            graphics.update("Oh no, you woke the wumpus! Get 3/5 Questions right to escape!");
            debug();
        }

        //sets interface and turn status if player falls in a pit
        public void fellInPit()
        {
            turnStatus = "pit";
            triviaScore = 0;
            triviaAsked = 0;
            triviaNumQs = 3;
            graphics.update("Oh no, you fell in a bottomless pit! The only way out is to 2/3 trivia questions right!");
            updateStats();
            loadTrivia();
            graphics.showCenter("Pit.png");
            debug();
        }

        //randomly moves player around if he finds a bat and resets the bat location
        public void foundBat()
        {

            Random temp = new Random();
            if (map.getBat1Location() == map.GetPlayerRoom())
            {
                map.setBat1Location(temp.Next(1, 31));
            }
            else
            {
                map.setBat2Location(temp.Next(1, 31));
            }
            map.SetPlayerRoom(temp.Next(1, 31));

            graphics.hint("Looks like a bat just picked you up and dropped you off in a random room!");
            updateStats();
            loadTrivia();
            debug();
            endTurn();
        }

        //runs appropriate response to trivia win when called
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
                Random temp = new Random();
                int wumpusStart = map.GetWumpusLocation();

                while(map.GetWumpusLocation() == wumpusStart)
                    map.SetWumpusLocation(cave.goToNewRoom(temp.Next(2, 5), map.GetWumpusLocation()));

                graphics.hint("You survived the Wumpus encounter! He ran away, but happy hunting!");
                sounds.playOnWumpusMove();
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

        //rus approriate response to trivia when the player has lost
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

        //accesses trivia objct and loads next question into the UI
        public void loadTrivia()
        {
            graphics.TriviaMode();
            sounds.playOnTriviaQuestion();
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

        //trivia response called by UI
        public void selectA()
        {
            triviaResponse("A");
        }

        //trivia response called by UI
        public void selectB()
        {
            triviaResponse("B");
        }

        //trivia response called by UI
        public void selectC()
        {
            triviaResponse("C");
        }

        //trivia response called by UI
        public void selectD()
        {
            triviaResponse("D");
        }

        //checks answer, removes coin from player, and ends turn if appropriate with a win or loss depending on score
        public void triviaResponse(String answer)
        {
            player.Buy();
            if (trivia.CorrectAnswer(answer))
            {
                triviaScore++;
                triviaAsked++;
            }else
                triviaAsked++;

            if((triviaNumQs == 3 && triviaScore > 1) || (triviaNumQs == 5 && triviaScore>2))
            {
                winTrivia();
                return;
            }else if(triviaAsked >= triviaNumQs)
            {
                lostTrivia();
                return;
            }else
                loadTrivia();
            if (turnStatus.Equals("pit"))
                graphics.showCenter("Pit.png");
            if (turnStatus.Equals("fightWumpus"))
                graphics.showCenter("Wumpus.png");
        }

        //method used for reporting location to GUI if debug objects turned on
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
        
        //checks for nearby hazards and tells player
        public void nearbyHazards()
        {
            for(int i = 0; i<6; i++)
            {
                if (map.GetWumpusLocation() == cave.GetDoors(map.GetPlayerRoom())[i])
                {
                    graphics.appendHint("I smell a Wumpus!");

                }

                if (map.getBat1Location() == cave.GetDoors(map.GetPlayerRoom())[i] || map.getBat2Location() == cave.GetDoors(map.GetPlayerRoom())[i])
                {
                    graphics.appendHint("Bats Nearby");
                    sounds.playOnBatNearby();
                }

                if (map.getPit1Location() == cave.GetDoors(map.GetPlayerRoom())[i] || map.getPit2Location() == cave.GetDoors(map.GetPlayerRoom())[i])
                {
                    graphics.appendHint("I feel a draft");
                    sounds.playOnPitNearby();
                }
            }
        }
    }
}