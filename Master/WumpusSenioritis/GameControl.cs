using System;

public class GameControl
{
    //declare map object
    //declare score object
    //declare player object
    //declare wumpus object

    public GameControl(int difficulty)
	{
        //call constructors for all respective classes
	}

    public void RunGame()
    {

    }

    private Boolean Trivia(int num)
    {
        int count = 0;
        for(int i = 0; i<num; i++)
        {
            if (/*trivia.run trivia()*/) count++;
        }
        if (count > (num / 2)) return true;
        return false;
    }

    private void updatePlayer(int newPosition)
    {
        updatePlayer.setPosition(newPosition);
    }

    private void move()
    {
        score.move();
        score.trivia(Trivia(3));
        wumpus.move();
        gui.(/*pass current rooom object*/);
    }
}
