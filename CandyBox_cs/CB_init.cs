using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uni_CsharpBasic_2024.CandyBox_cs
{
    internal class CB_init
    {
        /* 
         * Couple of basic formatting: https://learn.microsoft.com/en-us/dotnet/api/system.console.writeline?view=net-8.0
         * https://github.com/xoofx/markdig?tab=readme-ov-file
         * https://spectreconsole.net/
         * https://stackoverflow.com/questions/69016697/create-a-standalone-exe-file-in-visual-studio-2019
        */
        public static void CB_initiate()
        {
            Console.Clear();
            Console.WriteLine("\x1b[4m\x1b[38;2;255;128;0m\x1b[48;2;0;128;255mHello, World!\x1b[0m");
            Console.WriteLine("Test: ");
            Console.WriteLine("Hi, this game was originally made by aniwey at https://github.com/candybox2/candybox2.github.io");
            Console.WriteLine("The original was licensed under GPL3 license, so I though as a project I would give it a spin and do it in C# ");
            Console.WriteLine("While I probably will use some of the original ascii art, that is published under CC-BY-SA license");
            Console.WriteLine("The original Aacii art was created by Tobias Nordqvist, GodsTurf, dixsept, Dani \"Deinol\" Gómez and aniwey.");
            Console.WriteLine("Fully originally can be played at: https://candybox2.github.io/");

            Console.WriteLine("If you wanna play this version of the game, just press ENTER");

            Console.WriteLine("test1");
            Console.WriteLine("test11"+Console.ReadKey().KeyChar.ToString());
            Console.WriteLine("test12"+Console.ReadKey().KeyChar.GetType());
            Console.WriteLine("test13"+Console.ReadKey().Key.ToString());
            Console.WriteLine("test14"+Console.ReadKey().Key.GetType());

            while (Console.ReadKey().Key.ToString() != "Enter")
            {
                Console.WriteLine("Try Again");
            }

            Console.WriteLine("Yay, you escaped");

            if (Console.ReadKey().KeyChar.ToString() == "q")
            {
                Console.WriteLine("test2");
                Console.ReadKey();
                Console.WriteLine("test3");
            }
        }
    }
}
