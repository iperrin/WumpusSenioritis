using System;

public class ProgramManager
{

    private GameControl currentGame;
    private struct info
    {
        public string name;
        public int score;
        public int turns;
        public int gold;
        public int arrows;
        public int cave;
    }

	public ProgramManager()
	{
        
	}

    public void runGame(int difficulty)
    {
        currentGame = new GameControl(difficulty);
        //HighScore.addScore();

        ProgramManager.info.cave = 5;

    }

}
