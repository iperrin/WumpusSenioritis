using System;

namespace WumpusTest
{
    class Player{
        int arrows = 3;
        int goldCoins = 0;
        int playerTurns = 0;

        public Player(int arrows, int goldCoins, int playerTurns)
        {
            this.arrows = arrows;
            this.goldCoins = goldCoins;
            this.playerTurns = playerTurns;
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
    }
}
