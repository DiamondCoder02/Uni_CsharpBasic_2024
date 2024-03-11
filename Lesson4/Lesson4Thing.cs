namespace ListManagement
{
    internal class GetRandom(int size, int a, int b)
    {
        private readonly int size = size, a = a, b = b;

        public List<int> Generate()
        {
            Random rnd = new();
            List<int> list = []; // vagy new List<int>() vagy new()

            // lista feltöltése véletlenszámokkal (v1)
            for (int i = 0; i < size; i++) list.Add(rnd.Next(a, b));

            list.Clear(); // lista ürítése, hogy a másik verziójú

            // lista feltöltése véletlenszámokkal (v2)
            Func<int, int> rndSelect = delegate (int size)
            {
                return GenerateRandomNumber(size, a, b);
            };
            list.AddRange(Enumerable.Range(0, size).Select(rndSelect));

            list.Clear();

            // lista feltöltése véletlenszámokkal (v3)
            int rndSelect2(int size) => GenerateRandomNumber(size, a, b);
            list.AddRange(Enumerable.Range(0, size).Select(rndSelect2));

            list.Clear();

            // lista feltöltése véletlenszámokkal (v4)
            list.AddRange(Enumerable.Range(0, size).Select(delegate (int _)
            {
                return GenerateRandomNumber(this);
            }));

            list.Clear();

            // lista feltöltése véletlenszámokkal (v5)
            list.AddRange(Enumerable.Range(0, size).Select(_ => GenerateRandomNumber(this)));

            list.Clear();

            // lista feltöltése véletlenszámokkal (v6)
            list = Enumerable.Range(0, size).Select(_ => rnd.Next(a, b)).ToList();

            list.Clear();

            list = [.. Enumerable.Range(0, size).Select(_ => rnd.Next(a, b))]; // .. (double dot operator) = range operator (tartomány operátor)

            return list;
        }

        private static int GenerateRandomNumber(GetRandom instance)
        {
            Random rnd = new();
            return rnd.Next(instance.a, instance.b);
        }

        private static int GenerateRandomNumber(int size, int minValue, int maxValue)
        {
            Random rnd = new(size);
            return rnd.Next(minValue, maxValue);
        }
    }

    internal static class IntExtensions
    {
        public static bool IsEven(this int num) => num % 2 == 0 && num != 0;
    }

    internal static class IEnumerableExtensions
    {
        public static string BuildString<T>(this IEnumerable<T> self, string delim) => string.Join(delim, self);
    }

    internal static class MyForEach
    {
        public static void ForEachWithIndex<T>(this List<T> input, Action<T, int> action)
        {
            for (int i = 0; i < input.Count; i++) action(input[i], i);
        }
    }

    internal class Lesson4Thing
    {
        private static int Sum(int x, int y) => x + y;

        public static void ProgStart()
        {
            const int size = 14, minValue = 10, maxValue = 90;

            // Create and fill a list with random numbers
            GetRandom getRnd = new(size, minValue, maxValue);
            List<int> list = getRnd.Generate();

            // Display elements of list (version 1)
            Console.Write("Elements of the list (v1): ");
            for (int i = 0; i < size; i++) Console.Write("{0} ", list[i]); // Composite formatting

            // Display elements of list (version 2)
            Console.Write("\nElements of the list (v2): ");
            int loopIndex = 0;
            while (loopIndex < size) Console.Write($"{list[loopIndex++]} "); // String interpolation

            // Display elements of list (version 3)
            Console.Write("\nElements of the list (v3): ");
            foreach (int item in list) Console.Write(item + " "); // Basic Format string

            // Display elements of list (version 4)
            Console.Write("\nElements of the list (v4): ");
            foreach (int item in list)
            {
                int index = list.IndexOf(item);
                Console.Write(list.ElementAt(index) + " "); // or Console.Write(list[index] + " ");
            }

            // Display elements of list (version 5)
            Console.Write("\nElements of the list (v5): ");
            list.ForEach(x => Console.Write("{0} ", x));

            // Display elements of list (version 6)
            Console.WriteLine("\nElements of the list (v6): {0}.", string.Join(", ", list));

            // Display elements of list (version 7)
            Console.WriteLine("Elements of the list (v7): " + list.BuildString(" "));

            // Display elements of list (version 8)
            Console.Write("Elements of the list (v8): ");
            Console.WriteLine(list.Select(f => f.ToString()).Aggregate((x, y) => x + " " + y));

            // Display elements of list (v9)
            Console.Write("Elements of the list (v9): ");
            list.ForEachWithIndex((x, i) => Console.Write($"{x}{(i.Equals(list.Count - 1) ? "." : ", ")}"));


            // Find even items from the new list (version 1)
            Console.Write("\n\nEven elements of new list (v1): ");
            for (int i = 0; i < list.Count; i++)
            {
                if (list.ElementAt(i) % 2 == 0 && list.ElementAt(i) != 0)
                    Console.Write(list.ElementAt(i) + " ");
            }

            // Find even items from the new list (version 2)
            Console.Write("\nEven elements of new list (v2): ");
            list.ForEach(x => Console.Write((x.IsEven()) ? x + " " : ""));

            // Find even items from the new list (version 3)
            Console.Write("\nEven elements of new list (v3): ");
            list.FindAll(delegate (int i)
            {
                return i.IsEven();
            }).ForEach(x => Console.Write($"{x} "));

            // Find even items from the new list (version 4)
            Console.Write("\nEven elements of new list (v4): ");
            list.FindAll(item => item.IsEven()).ForEach(x => Console.Write($"{x} "));

            // Find even items from the new list (version 5)
            Console.Write("\nEven elements of new list (v5): ");
            Console.WriteLine("{0}", string.Join(" ", list.Where(x => x.IsEven())));

            // Find even items from the new list (version 6)
            Console.Write("Even elements of new list (v6): ");
            var evenNumber = from even in list where even.IsEven() select even;
            foreach (var item in evenNumber) Console.Write(item + " ");

            // Find even items from the new list (version 7)
            Console.Write("\nEven elements of new list (v7): ");
            evenNumber.ToList().ForEach(x => Console.Write($"{x} "));

            // Find even items from the new list (version 8)
            var evenNumber2 = list.Where(even => even.IsEven()).Select(even => even);
            Console.Write("\nEven elements of new list (v8): ");
            evenNumber2.ToList().ForEach(x => Console.Write($"{x} "));

            // Average of only odd elements (v1)
            double avgOdd2 = list.Where(num => !num.IsEven())
                .Aggregate(0, (result, item) => result + item, result => (double)result / list.Count(num => !num.IsEven()));
            Console.WriteLine($"\n\nAverage only for odd numbers (v1): {avgOdd2:#.##}");

            // Average of only odd elements (v2)
            double avgOdd = list.Where(num => !num.IsEven()).Average();
            Console.WriteLine($"Average only for odd numbers (v2): {avgOdd:#.##}");


            /* LINQ examples */

            // Filter with LINQ
            var evenNumbers = from num in list where num.IsEven() select num;
            Console.WriteLine($"LINQ example (find even numbers v1): {string.Join(' ', evenNumbers)}");
            Console.Write("LINQ example (find even numbers v2): ");
            list.Where(num => num % 2 == 0).ToList().ForEach(x => Console.Write($"{x} "));

            Console.WriteLine();

            // Projection
            var squares = from num in list select Math.Pow(num, 2);
            Console.WriteLine("\nSquares of numbers v1: " + string.Join(", ", squares) + ".");
            Console.Write("Squares of numbers v2: ");
            list.Select(num => Math.Pow(num, 2)).ToList().ForEachWithIndex((x, i) => Console.Write(x + (i.Equals(list.Count - 1) ? "." : ", ")));

            Func<int, int> getEvenNumbers = x => (int)Math.Pow(x, 2);
            Console.Write("\nSquares of numbers v3: " + string.Join(", ", list.Select(getEvenNumbers).ToList()) + ".");

            int getEvenNumbers2(int x) => (int)Math.Pow(x, 2);
            Console.Write("\nSquares of numbers v3: " + string.Join(", ", list.Select(getEvenNumbers2).ToList()) + ".");

            Console.WriteLine();

            // Projection to an object list
            List<Person> persons = [
                new() { Name = "John", Age = 30 },
                new() { Name = "Alice", Age = 25 },
                new() { Name = "Bob", Age = 40 }
            ];
            var names = from person in persons select person.Name;
            Console.WriteLine("\nLINQ example (display names v1): " + string.Join(", ", names));
            Console.Write("LINQ example (display names v2): " + string.Join(", ", persons.Select(p => p.Name).ToList()));

            Console.WriteLine();

            // Grouping and counting
            List<string> fruits = ["apple", "apple", "banana", "orange", "apple", "orange", "banana", "apple", "orange"];
            var fruitGroups = from fruit in fruits
                              group fruit by fruit into groupedFruits
                              orderby groupedFruits.Count()
                              select new { Fruit = groupedFruits.Key, Count = groupedFruits.Count() };
            Console.WriteLine("Fruits (v1): " + string.Join(", ", fruitGroups.Select(group => $"{group.Fruit}: {group.Count}")));

            var fruitGroups2 = fruits.GroupBy(fruit => fruit)
                        .OrderBy(groupedFruits => groupedFruits.Count())
                        .Select(groupedFruits => new { Fruit = groupedFruits.Key, Count = groupedFruits.Count() });
            Console.WriteLine("Fruits (v2): " + string.Join(", ", fruitGroups2.Select(group => $"{group.Fruit}: {group.Count}")));

            
            /* Aggregate examples */

            List<int> number = [6, 2, 4, 5]; //new() { 6, 2, 4, 5 };

            // Sum of list elements
            int sum = number.Aggregate(0, (result, item) => result + item);
            Console.WriteLine($"\nAggregate example (addition v1): sum of list 'number' = {sum}.");

            int sumf = number.Aggregate(Sum);
            Console.WriteLine($"Aggregate example (addition v2): sum of list 'number' = {sumf}.");

            // Average of list elements
            double average = number.Aggregate(0, (result, item) => result + item, result => (double)result / number.Count);
            Console.WriteLine($"Aggregate example: average of list 'number' = {average}.");

            Console.ReadKey();
            Environment.Exit(0);
        }
    }

    internal class Person
    {
        public string? Name { get; set; }
        public int Age { get; set; }
    }
}