using System;

class Player
{
    public int Arrow { get; private set; }
    public int GoldCoins { get; set; }
    public int playerTurns { get; set; }
    public bool HasShotArrow { get; private set; }

    private int CostOfArrow;
    private int ArrowsBought;   
    private int CostOfHint;

    public Player()
    {
        Reset();   
    }

    public void Reset()
    {
        CostOfArrow = 3;
        CostOfHint = 25;
        GoldCoins = 5;
        Arrow = 3;
        ArrowsBought = 0;
        playerTurns = 0;
        HasShotArrow = false;
    }

    public void shotArrow()
    {
        Arrow--;
    }

    public void incrementTurn()
    {
        playerTurns++;
    }

    public bool CanBuyArrow()
    {
        return GoldCoins >= CostOfArrow;
    }
    public void Buy()
    {
        GoldCoins -= 3;
    }
    public int NeedForBuyArrows()
    {
        return Math.Max(0, CostOfArrow - GoldCoins);
    }
    public void GiveArrows()
    {
        ArrowsBought += 2;
        Arrow += 2;
    }

    public void PushArrow()
    {
        --Arrow;
        HasShotArrow = true;
    }
    public bool CanBuyHint()
    {
        return GoldCoins >= CostOfHint;
    }
    public void BuyHint()
    {
        GoldCoins -= CostOfHint;
    }
    public int NeedForBuyHint()
    {
        return Math.Max(0, CostOfHint - GoldCoins);
    }
    public void AddCoins(int i)
    {
        GoldCoins += i;
    }

    public int[] GetData()
    {
        //returns int array [turns, gold, arrows]
        int[] output = new int[3];
        output[0] = playerTurns;
        output[1] = GoldCoins;
        output[2] = Arrow;

        return output;
    }
}