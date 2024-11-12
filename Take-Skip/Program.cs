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

        }
    }
}
