using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class graphicInterface
{
    //Access actions. 
    private void getActions()
    {
        //Console.WriteLine(actions);
    }

    //get userScore
    private void getScore()
    {
        //Console.WriteLine(score);
    }

    //Access highScore 
    private void getHighScore()
    {
        //Console.WriteLine(highScore);
    }

    //warningMessage displayed 
    public void warningMessage()
    {
        /*
        if (//player is adjacent to wumpus)
        {
            Console.WriteLine("I smell a Wumpus!");
        }
        else if (//player is adjacent to bats)
        {
            Console.WriteLine("Bats nearby.");
        }
        else
        {
            Console.WriteLine("I feel a draft...");
        }
        */
    }

    //Displays Hint onscreen for user 
    public String Hint()
    {
        return null; 
    }

    //Displays to user the current stats of gold coins, arrows, trivia pieces 
    public String Inventory()
    {
        return null; 
    }

    //Shows possible action that user can take to move (move, shoot arrow, purchase arrow/secret) 
    public void Action()
    {

    }

    //if user encounters hallway, feed trivia piece 
    public void WalkThrough(Boolean door)
    {
        if (door)
        {
            //call Trivia method that delivers Trivia to users if door = true (user walks through door)  
        }
    }

    //displays current room user is in 
    public void Room()
    {

    }

    //shows player's turns 
    public int Turn()
    {
        return 0; 
    }
}