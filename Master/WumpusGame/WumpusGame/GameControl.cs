using System;

public class GameControl
{
    Player player;
    Map map;
    TriviaManagement trivia;
    HighScore.PlayerInfo data;
    Cave cave;
    public string name;
    public int turns;
    public int gold;
    public int arrows;
    public int level;


    public GameControl()
	{
        player = new Player();
        map = new Map();
        cave = new Cave();
       // trivia = new TriviaManagement();
       
	}

    public String testMethod()
    {
        return level.ToString();
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
        int[] inputArray = new int[3];
        inputArray = player.getData();
        turns = inputArray[0];
        gold = inputArray[1];
        arrows = inputArray[2];
    }

    private void move()
    {
        //score.move();
        //score.trivia(Trivia(3));
        //wumpus.move();
        //gui.(/*pass current rooom object);
    }
}
