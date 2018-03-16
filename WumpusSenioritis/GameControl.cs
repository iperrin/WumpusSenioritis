using System;

public class GameControl
{
    //declare map object
    //declare score object
    //declare player object

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
            if (/*run trivia*/) count++;
        }
        if (count > (num / 2)) return true;
        return false;
    }
}
