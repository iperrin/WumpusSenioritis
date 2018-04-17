using System;

class Player{
    int arrows = 3;
    int goldCoins = 0;
    int playerTurns = 0;

    public Player()
    {
        playerTurns = 0;
        goldCoins = 0;
        arrows = 0;
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

    public int[] getData()
    {
        //returns int array [turns, gold, arrows]
        int[] output = new int[3];
        return output;
    }
}