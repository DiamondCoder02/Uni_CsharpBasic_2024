using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Uni_CsharpBasic_2024.CandyBox_cs.Coding
{
    // https://candybox2.github.io/
    // https://candybox2.fandom.com/wiki/Savegame_cheats#Finish_the_game
    internal class _Controller
    {
        public static void MainGame()
        {
            Console.Clear();
            TimerThread();
            while (Console.ReadKey(true).Key != ConsoleKey.Escape) { }
        }

        private static void MainTableRender()
        {
            Console.SetCursorPosition(0,0);
            Console.WriteLine("Debug mode:" + IVariables.debugMode);
            var table = new Table();
            table.Title("CBCS - CandyBox C#");
            // Add some columns
            table.AddColumn("0");
            table.AddColumn("Candies: "+IVariables.candies + "\nLollipops:" + IVariables.lollipops + "\nChocolate:" + IVariables.chocolate);
            table.AddColumn("2");
            table.Columns[0].Width(15);
            table.Columns[1].Width(70);
            table.Columns[2].Width(15);

            // Add some rows
            table.AddRow("");
            table.AddRow("");
            table.Expand();

            // Render the table to the console
            AnsiConsole.Write(table);
        }

        static void TimerThread()
        {
            System.Timers.Timer timer = new(){ Interval = 1000 };
            timer.Elapsed += Timer_elapsed;
            timer.Start();
        }

        // TODO - Lollipop Counter is broken if multiplier below 1
        static int minute = 0;
        static void Timer_elapsed(object? sender, ElapsedEventArgs e)
        {
            // TODO https://candybox2.fandom.com/wiki/The_Lollipop_farm#Trivia
            // Fibonachi
            IVariables.candies += 1 * IVariables.candyMultip;
            if (IVariables.loliMultip <= 1) { IVariables.lollipops += 1 * ((int)IVariables.loliMultip); }
            MainTableRender();
        }

    }
}
