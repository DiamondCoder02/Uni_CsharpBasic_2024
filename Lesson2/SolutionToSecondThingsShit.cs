namespace Uni_CsharpBasic_2024.Lesson2
{
    internal class SolutionToSecondThingsShit
    {
        private readonly double a, b, c;
        private double x, x1, x2;

        public SolutionToSecondThingsShit(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public string Calc()
        {
            double d = Math.Pow(b, 2) - 4 * a * c;
            if (d==0)
            {
                x = -b / (2 * a);
                return string.Format("The soultion: x = {0:0.00}",x);
            } else if (d>1)
            {
                x1 = (-b + Math.Sqrt(d)) / (2 * a);
                x2 = (-b - Math.Sqrt(d)) / (2 * a);
                return string.Format("The solutions are: x1 = {0:0.00}, x2 = {1:0.00} ", x1, x2);
            } else
            {
                x1 = -b / (2 * a);
                x2 = Math.Sqrt(Math.Abs(d)) / (2 * a);
                return string.Format("The solutions: x1 = {0:0.00} + {1:0.00}i, x2 = {2:0.00} - {3:0.00} ", x1, x2, x1, x2);
            }
        }
    }
}
