using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uni_CsharpBasic_2024.Lesson2
{
    internal class Task2
    {
        private readonly int size, a, b;
        public Task2(int size, int a, int b)
        {
            this.size = size;
            this.a = a;
            this.b = b;
        }

        public List<int> Generate()
        {
            Random random = new();
            // V1
            // List<int> listing = new(size);
            // for (int i = 0; i < size; i++) { listing.Add(random.Next());}

            // V2
            // List<int> listing = new();
            // listing.AddRange(Enumerable.Range(0, size).Select(GenerateRandomNumber));

            // V3
            /* List<int> listing = new();
            Func<int, int> rndSelect = delegate (int index)
            {
                return GenerateRandomNumber(index, a, b);
            };
            listing.AddRange(Enumerable.Range(0, size).Select(rndSelect));
            */

            // V4
            List<int> listing = Enumerable.Range(0, size).Select(_ => random.Next(a,b)).ToList();

            return listing;
        }

        private static int GenerateRandomNumber(int _)
        {
            int a = 1, b = 100;
            Random rnd = new();
            return rnd.Next(a, b);
        }

        private static int GenerateRandomNumber(int index, int a, int b)
        {
            Random rnd = new();
            return rnd.Next(a, b);
        }
    }
}
