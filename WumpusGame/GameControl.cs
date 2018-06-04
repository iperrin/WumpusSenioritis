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
            graphics.showCenter("Player Icon.gif");
            if (checkEndConditions())
            {
                endGame();
            }

            turnStatus = "move";

            graphics.showPurchase();

            //graphics displays 
        }

        public void endTurn()
        {
            player.incrementTurn();
            updateStats();
            if (checkEndConditions())
            {
                endGame();
            }
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

        public void newHint()
        {
            //show some trivia
        }

        public void move(int door)
        {
            int startRoom = map.GetPlayerRoom();
            int newRoom = cave.GetDoors(startRoom)[door-1];
            newHint();
            map.SetPlayerRoom(newRoom);

            //update room

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

        }

        public void arrowMode()
        {
            turnStatus = "throwArrow";
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
            loadTrivia();
        }

        public void buyArrow()
        {
            turnStatus = "byArrow";
            loadTrivia();
        }

        private void loadTrivia()
        {
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
            if (trivia.CorrectAnswer("A"))
            {
                player.BuyArrows();
                player.GiveArrows();
                updateStats();
            }

            graphics.hideTrivia();
        }

        public void selectB()
        {
            if (trivia.CorrectAnswer("B"))
            {
                player.BuyArrows();
                player.GiveArrows();
                updateStats();
            }

            graphics.hideTrivia();
        }

        public void selectC()
        {
            if (trivia.CorrectAnswer("C"))
            {
                player.BuyArrows();
                player.GiveArrows();
                updateStats();
            }

            graphics.hideTrivia();
        }

        public void selectD()
        {
            if (trivia.CorrectAnswer("D"))
            {
                player.BuyArrows();
                player.GiveArrows();
                updateStats();
            }

            graphics.hideTrivia();
        }

    }
}