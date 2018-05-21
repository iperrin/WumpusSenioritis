using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WumpusGame;
using System.IO;
using WumpusGame.bin;

static class Program
{
    /// <summary>
    /// The main entry point for the application.
    /// </summary>

    //[STAThread]

    public static Form runningApp;

    static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new Loader());
    }

    public static void run(String input)
    {
        if (input.Equals("_FinalGame"))
        {
            runningApp = new _FinalGame();
            runningApp.ShowDialog();
        }
        else if (input.Equals("GameControlTester"))
        {
            Form game = new GameControlTestForm();
            game.ShowDialog();
        }
        else if (input.Equals("HighScoreTestForm"))
        {
            Form game = new Form1();
            game.ShowDialog();
        }
        /* require future implementation
        else if (input.Equals(""))
        {
            Form game = new ();
            game.ShowDialog();
        }
        else if (input.Equals(""))
        {
            Form game = new ();
            game.ShowDialog();
        }
        */

    }

    public static void saveFile(String data, String name)
    { 
        StreamWriter sw = new StreamWriter(Environment.CurrentDirectory+name+".txt");

        //Write a line of text
        sw.WriteLine(data);

        //Close the file
        sw.Close();
    }
}