using System;

namespace TakeSkip
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] grades = { 59, 82, 70, 56, 92, 98, 85 };

            foreach (int grade in grades.Take(3))
            {
                Console.WriteLine("TAKE: " + grade);
            }

            foreach (int grade in grades.Skip(3))
            {
                Console.WriteLine("SKIP: " + grade);
            }

            string example = "Hello, World!";
            // Call the extension method as if it were an instance method.
            string reversed = example.Reverse();
            Console.WriteLine(reversed); // Output: !dlroW ,olleH

        }
    }
}
