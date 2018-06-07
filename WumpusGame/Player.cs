using System;

class Player
{
    //the information that the player has
    public int Arrow { get; private set; }
    public int GoldCoins { get; set; }
    public int playerTurns { get; set; }
    public bool HasShotArrow { get; private set; }

    private int CostOfArrow;
    private int ArrowsBought;   
    private int CostOfHint;
    
    //sets player starting values to those indicated in Reset();
    public Player()
    {
        Reset();   
    }
    
    //sets the starting value of the player information to the following
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
    
    //reduces arrow numbers
    public void shotArrow()
    {
        Arrow--;
    }
    
    
    //adds to turn every movement
    public void incrementTurn()
    {
        playerTurns++;
    }
    
    //checks if you can buy an arrow by looking at player's gold value
    public bool CanBuyArrow()
    {
        return GoldCoins >= CostOfArrow;
    }
    
    //reduces gold by 1 when purchasing secret or arrows
    public void Buy()
    {
        GoldCoins--;
    }
    
    //checks if arrows are needed
    public int NeedForBuyArrows()
    {
        return Math.Max(0, CostOfArrow - GoldCoins);
    }
    
    //Adds arrows to the total pool
    public void GiveArrows()
    {
        ArrowsBought += 2;
        Arrow += 2;
    }
    
    //Information after shooting arrow
    public void PushArrow()
    {
        --Arrow;
        HasShotArrow = true;
    }
    
    //checks if player can buy a hint by looking at cost
    public bool CanBuyHint()
    {
        return GoldCoins >= CostOfHint;
    }
    
    //Reduces gold to buy a hint
    public void BuyHint()
    {
        GoldCoins -= CostOfHint;
    }
    
    //checks if player needs a hint
    public int NeedForBuyHint()
    {
        return Math.Max(0, CostOfHint - GoldCoins);
    }
    
    //adds gold to the players inventory
    public void AddCoins(int i)
    {
        GoldCoins += i;
    }
    
    //returns the inventory of the player that is displayed on the front screen
    //returns individual outputs which was originally in array form
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
