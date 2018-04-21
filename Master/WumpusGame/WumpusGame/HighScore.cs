using System;
using System.Collections;
using Microsoft.VisualBasic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Wumpus_Test
{
    class HighScore
    {
        //score turns gold arrows cave player
       
        private String[]  Record;
        private String[] results;
        public HighScore(String[] data)
        {
            results = data;
            Record = System.IO.File.ReadAllLines(@"C:\Users\Public\TestFolder\record.txt");
        }
     
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
        public String[] GetHighScores()
        {
            string[] scores = System.IO.File.ReadAllLines(@"C:\Users\Public\TestFolder\record.txt");
            return scores;
        }
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
        public void WriteNewScores()
        {
            System.IO.File.WriteAllLines(@"C:\Users\Public\TestFolder\record.txt", Record);
        }
    }


    }
