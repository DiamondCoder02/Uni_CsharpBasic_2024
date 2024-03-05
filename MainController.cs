using test;
using Uni_CsharpBasic_2024.CandyBox_cs;
using Uni_CsharpBasic_2024.Lesson2;

namespace Uni_CsharpBasic_2024
{
    internal class MainController
    {
        public static void Main(string[] args)
        {
            // https://stackoverflow.com/questions/69016697/create-a-standalone-exe-file-in-visual-studio-2019
            Console.WriteLine("Please choosse a number to start that program: ");
            Console.WriteLine("0. CandyBox remade in console and C#");
            Console.WriteLine("1. Lesson1   HelloWorld");
            Console.WriteLine("2. Lesson2_1 Ask 3 Number");
            Console.WriteLine("3. Lesson2_2 Random Number Gen. (Task2.cs)");
            // string? readline = Console.ReadLine();
            string readline = "0"; // TODO, Fuck me
            switch (readline)
            {
                case "0":
                    CB_init.CB_initiate();
                    break;
                case "1":
                    Test.Lesson1();
                    break;
                case "2":
                    Lesson2.Lesson2.Lesson2_1();
                    break;
                case "3":
                    Task2.Lesson2_2();
                    break;
                case "69":
                    Console.WriteLine("https://f95zone.to/");
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }
        }
    }
}
