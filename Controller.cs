using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uni_CsharpBasic_2024
{
    internal class Controller
    {
        private static int id;
        public static void Main(string[] args)
        {
            Console.WriteLine("Please choosse a number to start that program: ");
            Console.WriteLine("1. Lesson1   HelloWorld");
            Console.WriteLine("2. Lesson2_1 Ask 3 Number");
            Console.WriteLine("3. Lesson2_2 Random Number Gen.");

            string? readline = Console.ReadLine();
            switch (readline)
            {
                case "1":
                    
                    break;
                case "2":
                    
                    break;
                case "3":
                    
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }
        }
    }
}
