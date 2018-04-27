using System;

namespace WumpusGame
{
    public class GameControl
    {
        Player player;
        Map map;
        TriviaManagement trivia;
        Cave cave;
        public string name;
        public int level;


        public GameControl()
        {
            player = new Player();
            map = new Map();
            cave = new Cave(1);
            trivia = new TriviaManagement();

        }

        public void StartGame(int caveNumber)
        {
            player.Reset();
            cave.load(caveNumber);
            trivia.Reset();
            //map.Reset();
        }

        public String getTriviaQuestion()
        {
            return trivia.GetNextQuestion();
        }

        public String getTriviaFact()
        {
            return trivia.GetNextFact();
        }

        private void move(int newRoom)
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

        public void updateRoom(System.Windows.Forms.Button[] ButtonArray,int room)
        {
            graphicInterface.displayDoors(ButtonArray,cave.GetDoors(room));
        }

        private void endGame()
        {
            //add player data to high score
            //send high score data to GUI for display
        }
    }
}