using GenericsExampleBasic;
using ListManagement;
using Uni_CsharpBasic_2024.Lesson2;
    
namespace Uni_CsharpBasic_2024
{
    internal class MainController
    {
        public static void Main(string[] args)
        {
            // https://stackoverflow.com/questions/69016697/create-a-standalone-exe-file-in-visual-studio-2019
            Console.WriteLine("Please choosse a number to start that program: ");
            Console.WriteLine("1. Lesson1   HelloWorld");
            Console.WriteLine("2. Lesson2_1 Ask 3 Number");
            Console.WriteLine("3. Lesson2_2 Random Number Gen. (Task2.cs)");
            Console.WriteLine("4. Lesson4 TeacherShit1");
            Console.WriteLine("5. Lesson5 TeacherShit2");
            string? readline = Console.ReadLine();
            switch (readline)
            {
                case "1":
                    test.Test.Lesson1();
                    break;
                case "2":
                    Lesson2.Lesson2.Lesson2_1();
                    break;
                case "3":
                    Task2.Lesson2_2();
                    break;
                case "4":
                    Lesson4Thing.ProgStart(); 
                    break;
                case "5":
                    Lesson5.ProgStart();
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
