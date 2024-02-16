namespace Uni_CsharpBasic_2024.Lesson2
{
    internal class Lesson2
    {
        public static void Lesson2_1()
        {
            Console.Write("Give me 3 fucking number with spaces in between: ");
            string? readline = Console.ReadLine();
            List<string> lines = readline.Split(' ').ToList();
            if (readline.Contains(' '))
            {
                double a = Convert.ToDouble(lines.ElementAt(0));
                double b = Convert.ToDouble(lines.ElementAt(1));
                double c = Convert.ToDouble(lines.ElementAt(2));
                Console.WriteLine(new SolutionToSecondThingsShit(a, b, c).Calc());
            } else
            {
                Console.WriteLine("ERROR ◑﹏◐");
            }
        }
    }
}
