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
    internal class Controller
    {
        public static void MainGame(Boolean newGame)
        {
            Console.Clear();
            if (!newGame)
            {
                Console.WriteLine("TODO - Atempting to load old save...");
            }
            TimerThread();
            while (Console.ReadKey(true).Key != ConsoleKey.Escape) { }
        }

        private static void TimerThread()
        {
            System.Timers.Timer timer = new(){ Interval = 1000 };
            timer.Elapsed += Timer_elapsed;
            timer.Start();
        }

        // TODO - Lollipop Counter is broken if multiplier below 1
        static int minute = 0;
        private static void Timer_elapsed(object? sender, ElapsedEventArgs e)
        {
            // TODO https://candybox2.fandom.com/wiki/The_Lollipop_farm#Trivia
            // Fibonachi
            IVariables.candies += 1 * IVariables.candyMultip;
            if (IVariables.loliMultip <= 1) { IVariables.lollipops += 1 * ((int)IVariables.loliMultip); }
            MenuControl.MainTableRender();
        }

    }
}
