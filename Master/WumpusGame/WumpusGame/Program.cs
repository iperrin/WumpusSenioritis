using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WumpusGame;
using System.IO;

static class Program
{
    /// <summary>
    /// The main entry point for the application.
    /// </summary>

    [STAThread]


    static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new GameControlTestForm());
        GameControl management = new GameControl();
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