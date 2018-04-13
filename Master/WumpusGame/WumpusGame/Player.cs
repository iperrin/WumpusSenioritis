using System;

public class Player{
    int arrows;
    int goldCoins;
    int playerTurns;

    public Player()
    {
        arrows = 0;
        goldCoins = 0;
        playerTurns = 0;
    }

    public void move(int direction)
    {
           //changes that occur after change 
    }

    public void AddArrows(int addition)
    {
        arrows += addition;
    }

    public void ShootArrows(int subtraction)
    {
        arrows -= subtraction;
    }

    public void AddGold(int addition)
    {
        goldCoins += addition;
    }

    public void UseGold(int subtraction)
    {
        goldCoins -= subtraction;
    }

    public void AddTurns(int addition)
    {
        playerTurns += addition;
    }

    public int[] getPlayerInfo()
    {
        int[] output = {playerTurns, goldCoins, arrows};
        return output;
    }
}