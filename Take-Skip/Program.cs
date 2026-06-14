using System;
using System.Reflection;
using Take_Skip;

namespace TakeSkip
{
    class Program
    {
        enum Season
        {
            Spring,
            Summer,
            Autumn,
            Winter
        }

        enum HttpStatus : int
        {
            OK = 200,
            NotFound = 404,
            InternalServerError = 500
        }

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

            // Extension Methods
            string example = "Hello, World!";
            // Call the extension method as if it were an instance method.
            string reversed = example.Reverse();
            Console.WriteLine(reversed); // Output: !dlroW ,olleH

            // Reflection in .NET
            Type type = typeof(MyClass);
            object? instance = Activator.CreateInstance(type);
            MethodInfo? method = type.GetMethod("Sum");

            if (method != null) {
                var parameters = new object[] { 5, 3 };
                var result = method.Invoke(instance, parameters);
                Console.WriteLine(result); // 8
            }

            // Enum
            Console.WriteLine(Season.Spring); // result: Spring
            Console.WriteLine(HttpStatus.InternalServerError); // result: InternalServerError

            // Parse a string to an enum value:
            var parsed = Enum.Parse<Season>("Winter");
            Console.WriteLine(parsed); // Winter

            Console.WriteLine($"{Season.Spring} = {(int)Season.Spring}");
            Console.WriteLine($"{HttpStatus.InternalServerError} = {(int)HttpStatus.InternalServerError}");
        }
    }
}
