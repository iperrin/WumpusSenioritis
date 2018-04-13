using System;

public class GameControl
{
    Player player;
    Map map;
    TriviaManagement trivia;
    String name;
    int[] data; // {turns, gold, arrows, cave}


    public GameControl(int difficulty)
	{
        player = new Player();
        map = new Map();
        data = new int[4] {0, 0, 0, difficulty};
        updateData();
        //need to update file location parameters "Environment.CurrentDirectory" or something
        trivia = new TriviaManagement("temp","temp","temp");
	}


    private void updatePlayer(int newPosition)
    {
        //updatePlayer.setPosition(newPosition);
    }

    private void move(int direction)
    {
        player.move(direction);
        updateData();
        //Update GUI birdeye view
        if (triviaQuery(3)){
            player.AddGold(1);
        }
        else{

        }
        //gui.(/*pass current rooom object);
        map.checkHazards();
    }

    private Boolean triviaQuery(int count)
    {
        int score = 0;
        for(int i = 0; i<count; i++)
        {
            //retrive question from trivia class
            //send question info to gui
        }
        if (score > count - score) return true;
        else return false;

    }

    private void updateData()
    {
        int[] update = player.getPlayerInfo();
        for(int i = 0; i<3; i++)
        {
            data[i] = update[i];
        }
    }

    private void endgame()
    {
        HighScore.addScore(name, data);
        //GUI display endgame page with button that resets game
    }
}
