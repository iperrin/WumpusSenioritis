using System;

class Player
{
    int arrows;
    int goldCoins;
    int playerTurns;

    public Player()
    {
        int arrows = 3;
        int goldCoins = 0;
        int playerTurns = 0;
    }

    public void Reset()
    {
        //rests all values
    }

    public void Move(int direction)
    {

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

    public int[] GetData()
    {
        //returns int array [turns, gold, arrows]
        int[] output = new int[3];
        output[0] = playerTurns;
        output[1] = goldCoins;
        output[2] = arrows;

        return output;
    }
}
