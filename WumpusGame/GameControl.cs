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
        graphicInterface graphics;
        public string name;
        public int level;


        public GameControl(PictureBox[] images, Button[] buttons, Label[] texts, TextBox ScoreBoard)
        {
            player = new Player();
            map = new Map();
            cave = new Cave();
            trivia = new TriviaManagement();
            graphics = new graphicInterface(images, buttons, texts, ScoreBoard);
        }

        public void StartGame(int caveNumber)
        {
            Boolean run = true;
            player.Reset();
            cave.load(caveNumber);
            graphics.loadCave(caveNumber);
            trivia.Reset();
            map.Reset();
            runTurn();
        }

        public void runTurn()
        {
            if (checkEndConditions())
            {
                endGame();
            }


            //graphics displays 
        }

        public void endTurn()
        {
            player.incrementTurn();
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

        public void move(int newRoom)
        {

            //update map with new move
            //run trivia game
            //purchase prompts
            //update player
            //update view (get new room info)
            /*
            if (true) {//check wumpus position for player position
                if (!trivia.run(5))
                    endGame();
                else
                    //call map to move wumpus
            }

            if (true) {//check for hazards calls map

            }
            */
        }

        private void endGame()
        {
            //add player data to high score
            //send high score data to GUI for display
        }

        public graphicInterface getGraphicInterface()
        {
            return graphics;
        }
    }
}