using System;

public class GameControl
{
    Player player;
    Map map;
    TriviaManagement trivia;
    int level;


    public GameControl(int difficulty)
	{
        player = new Player();
        map = new Map();
        level = difficulty;

       // trivia = new TriviaManagement();

	}

    public String testMethod()
    {
        return level.ToString();
    }

    public void RunGame()
    {

    }

    private void updatePlayer(int newPosition)
    {
        //updatePlayer.setPosition(newPosition);
    }

    private void move()
    {
        //score.move();
        //score.trivia(Trivia(3));
        //wumpus.move();
        //gui.(/*pass current rooom object);
    }
}
