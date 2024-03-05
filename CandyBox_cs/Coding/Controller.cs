using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uni_CsharpBasic_2024.CandyBox_cs.Coding
{
    // https://candybox2.github.io/
    // https://candybox2.fandom.com/wiki/Savegame_cheats#Finish_the_game
    internal class Controller
    {
        public static bool debugMode;
        public static int candies;
        
        public static bool[] unlockedMenus = [
            false, // 1. BoughtManuBar -> It get's some style and reveals that you will unlock more later
            false, // 2. Config
            false, // 3. Save? 
            false, // 4. HealthBar
            false, // 6. Inventory
            false, // 5. Map
            false, // 7. LollipopFarm
            false // 8. Cauldron
            ];
        public static void controller()
        {
            MainTableRender();
            MainGame();
        }

        private static void MainGame()
        {
            while (Console.ReadKey(false).Key != ConsoleKey.Escape)
            {
                MainTableRender();

            }
        }

        private static void MainTableRender()
        {
            Console.Clear();
            Console.WriteLine("Debug mode:" + debugMode);
            var table = new Table();
            table.Title("CBCS - CandyBox C#");
            // Add some columns
            table.AddColumn("0");
            table.AddColumn("1");
            table.AddColumn("2");
            table.Columns[0].Width(15);
            table.Columns[1].Width(70);
            table.Columns[2].Width(15);

            // Add some rows
            table.AddRow("");
            table.Expand();

            // Render the table to the console
            AnsiConsole.Write(table);
        }
    }
}
