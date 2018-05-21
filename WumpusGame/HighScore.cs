using System;
using System.Collections;
using Microsoft.VisualBasic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




    class HighScore
    {
        //score turns gold arrows cave player
       
        private String[]  Record;
        private String[] results;
        public HighScore(String[] data)
        {
            results = data;
            Record = System.IO.File.ReadAllLines(Environment.CurrentDirectory+@"\HighScoreRecord.txt");
            //push comment
        }
        //checks to see if the user's score is high enough to be a high score
        //if it is determinded it is high enough to be on the high scores list it runs the method to add it
        public void addScore()
        {
            int spot = -1;
            for (int x = Record.Length-6, y = 0; y < 10;  x-=6, y++)
            {
                if(Int32.Parse(Record[x]) < Int32.Parse(results[0]))
                {
                    spot = x;  
                }
             }
            if (spot != -1)
            {
                ReplaceScore(spot);
            }
        }
        // returns current 10 top high scores 
        public static String[] GetHighScores()
        {
            string[] scores = System.IO.File.ReadAllLines(Environment.CurrentDirectory + @"\HighScoreRecord.txt");
            return scores;
        }
        // puts the users score in the correct spot on the top ten scores list 
        // shifts all scores less than the user's score down the list by 1
        // removes the lowest score so there is only 10 scores saved.
        public void ReplaceScore(int spot)
        {
            String[] newRecord = new String[Record.Length];
            for (int x = 0; x < spot; x++)
            {
                newRecord[x] = Record[x];
            }
            newRecord[ spot ] = results[0];
            newRecord[spot+1] = results[1];
            newRecord[spot+2] = results[2];
            newRecord[spot+3] = results[3];
            newRecord[spot+4] = results[4];
            newRecord[spot+5] = results[5];
            for (int x = spot+6, y = spot; x < newRecord.Length; x++, y++)
            {
                newRecord[x] = Record[y];
            }
            Record = newRecord;
        }
        // Writes the updated top 10 high scores to a file to save the scores for the next game.
        public void WriteNewScores()
        {
            System.IO.File.WriteAllLines(@"C:\Users\Public\TestFolder\record.txt", Record);
        }
    }


    

