using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Spectre.Console;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Uni_CsharpBasic_2024.CandyBox_cs.Coding
{
    internal class MenuControl
    {
        public static void MainTableRender()
        {
            bool[] unMen = IVariables.unlockedMenus;

            string topMenu =
                (unMen[0] ? "CandyBox":" - ") + " | " +
                (unMen[4] ? "Inventory":" - ") + " | " +
                (unMen[5] ? "Map":" - ") + " | " +
                (unMen[6] ? "Lollipop Farm":" - ") + " | " +
                (unMen[7] ? "Cauldron" : " - ") + " | " +
                (unMen[2] ? "Save":" - ") + " | " +
                (unMen[1] ? "Config":" - ") ;

            //string sweets = "Candies: " + IVariables.candies + "\nLollipops:" +
            //  IVariables.lollipops + "\nChocolate:" + IVariables.chocolate;
            string sweets = "Candies: " + IVariables.candies + "  --  " +
                "Chocolate:" + IVariables.chocolate +
                "\nLollipops:" + IVariables.lollipops + "  --  " +
                "painsAuChocolat" + IVariables.painsAuChocolat;

            string healthBar = IVariables.currentHealth + " / " + IVariables.maxHealth;



            Console.SetCursorPosition(0, 0);
            Console.WriteLine("Debug mode:" + IVariables.debugMode);
            var table = new Table();
            table.Title("CBCS - CandyBox C#");
            // Add some columns
            table.AddColumn("B");
            table.AddColumn("V");// 
            table.AddColumn("C");
            table.Columns[0].Width(15);
            table.Columns[1].Width(70);
            table.Columns[2].Width(15);


            // Add some rows
            table.AddRow("a", "c", "g");
            table.AddRow("v", "", "LOL");
            table.Expand();

            // Render the table to the console
            AnsiConsole.Write(table);
        }
    }
}
