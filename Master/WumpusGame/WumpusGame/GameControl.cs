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

    private void getPlayerData(int newPosition)
    {
        
    }

    private void move(int newRoom)
    {
        //update map with new move
        //run trivia game
        //purchase prompts
        //update player
        //update view (get new room info)
        //check for wumpus
        //check for hazards
        
    }

    private void endGame()
    {
        //add player data to high score
        //send high score data to GUI for display
    }
}
