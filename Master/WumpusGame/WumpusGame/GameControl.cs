using System;

public class GameControl
{
    Player player;
    Map map;
    TriviaManagement trivia;
    HighScore.PlayerInfo data;
    Cave cave;
    public string name;
    public int level;


    public GameControl()
	{
        player = new Player();
        map = new Map();
        cave = new Cave();
       // trivia = new TriviaManagement();
       
	}

    public void StartGame(int caveNumber)
    {
        player.Reset();
        cave.load(caveNumber);
        trivia.Reset();
        map.Reset();
    }

    private void move(int newRoom)
    {
        //update map with new move
        //run trivia game
        //purchase prompts
        //update player
        //update view (get new room info)
        if (true) {//check wumpus position for player position
            if (!trivia.run(5))
                endGame();
            else
                //call map to move wumpus
        }

        if (true) {//check for hazards calls map

        }
    }

    private void updateRoom(int room)
    {
        graphicInterface.displayDoors(cave.GetDoors(5));
    }

    private void endGame()
    {
        //add player data to high score
        //send high score data to GUI for display
    }
}
