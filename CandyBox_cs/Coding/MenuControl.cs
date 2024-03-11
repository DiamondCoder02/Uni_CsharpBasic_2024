﻿using Spectre.Console;
using Uni_CsharpBasic_2024.CandyBox_cs.Coding.Locations;
using Uni_CsharpBasic_2024.CandyBox_cs.Coding.Other;

namespace Uni_CsharpBasic_2024.CandyBox_cs.Coding
{
    internal class MenuControl
    {
        public static ConsoleKey pressedKeyForControl;
        public static void MainTableRender()
        {
            keyPressDetectionAndLocationChange();
            string[] test;
            switch (IVariables.currentLocation)
            {
                case "Clicker": test = Clicker.Pclicker(); break;
                // case "Village": test = Village.Pvillage(); break;
                default: test = ["ERROR", "ERROR", "ERROR"]; IVariables.currentLocation = "Clicker"; break;
            }

            string[] defMenu = defaultMenu();

            Console.SetCursorPosition(0, 0);

            var table = new Table();
            table.Title("CBCS - CandyBox C#");

            table.AddColumn((IVariables.debugMode ? "DebugMode: ON" : ""));
            // 40 dashes 
            table.AddColumn(defMenu[0] + "\n----------------------------------------\n" + defMenu[1] + "\n----------------------------------------\n" + defMenu[2]);
            table.AddColumn("NotSureWhat\nToWriteHere... \nHi :3");

            table.Columns[0].Width(15);
            table.Columns[1].Width(70);
            table.Columns[2].Width(15);

            table.AddRow(
                "Controls:\n----------\n" +
                defMenu[3] + "\n----------\n" +
                test[0],
                test[1],
                ""
            );
            table.Expand();
            // Render the table to the console
            AnsiConsole.Write(table);
            pressedKeyForControl = ConsoleKey.None;
        }

        private static void keyPressDetectionAndLocationChange()
        {
            bool[] unMen = IVariables.unlockedMenus;

            switch (pressedKeyForControl)
            {
                case ConsoleKey.D1: IVariables.currentLocation = "Clicker"; break;
                case ConsoleKey.D2: IVariables.currentLocation = "Inventory"; break;
                case ConsoleKey.D3: { IVariables.currentLocation = (IVariables.foundControls[1][0] ? "Map" : "Village"); break; }
                case ConsoleKey.D4: IVariables.currentLocation = "LollipopFarm"; break;
                case ConsoleKey.D5: IVariables.currentLocation = "Cauldron"; break;
                case ConsoleKey.D6: IVariables.currentLocation = "Save"; break;
                case ConsoleKey.D7: IVariables.currentLocation = "Config"; break;
            }

        }

        private static string[] defaultMenu()
        {
            bool[] unMen = IVariables.unlockedMenus;

            string topMenu =
                (unMen[0] ? "CandyBox" : " - ") + " | " +
                (unMen[4] ? "Inventory" : " - ") + " | " +
                (unMen[5] ? "Map" : " - ") + " | " +
                (unMen[6] ? "Lollipop Farm" : " - ") + " | " +
                (unMen[7] ? "Cauldron" : " - ") + " | " +
                (unMen[2] ? "Save" : " - ") + " | " +
                (unMen[1] ? "Config" : " - ");

            string sweets = (IVariables.candies >= 0 ? "Candies: " + IVariables.candies + "  ||  " : "") +
                (IVariables.chocolate >= 0 ? "Chocolate: " + IVariables.chocolate + "  ||  \n" : "") +
                (IVariables.lollipops >= 0 ? "Lollipops: " + IVariables.lollipops + "  ||  " : "") +
                (IVariables.painsAuChocolat >= 0 ? "painsAuChocolat: " + IVariables.painsAuChocolat : "");

            string healthBar = (IVariables.unlockedMenus[3] ? "Health: " + IVariables.currentHealth + " / " + IVariables.maxHealth : "");

            // Add some rows
            string basicControls =
                (unMen[0] ? "1 - CandyBox" : "? - ???") + "\n" +
                (unMen[4] ? "2 - Inventory" : "? - ???") + "\n" +
                (unMen[5] ? "3 - Map" : "? - ???") + "\n" +
                (unMen[6] ? "4 - Lollipop Farm" : "? - ???") + "\n" +
                (unMen[7] ? "5 - Cauldron" : "? - ???") + "\n" +
                (unMen[2] ? "6 - Save" : "? - ???") + "\n" +
                (unMen[1] ? "7 - Config" : "? - ???");

            return [topMenu, sweets, healthBar, basicControls];
        }
    }
}
