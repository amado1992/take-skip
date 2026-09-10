using System;
using System.Reflection;
using System.Security.AccessControl;
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

            if (method != null)
            {
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


            var program = new Program();
            var values = program.GetValuesEnum(Season.Spring);
            Console.WriteLine($"Values enum {values}");

            Array resultValues = Enum.GetValues(Season.Spring.GetType());
            Console.WriteLine($"Value x en index x enum {resultValues.GetValue(2)}"); // Autumn

            var array = Enum.GetValues(typeof(Season));
            Console.WriteLine($"Get value in position 0 enum {array.GetValue(0)}");

            var index = Array.IndexOf(array, Season.Spring);
            Console.WriteLine($"Get index the value Season.Spring enum {index}");

            foreach (var value in array)
            {
                Console.WriteLine($"Array of value enum {value}");

                if ((Season)value == Season.Spring) 
                {
                }
            }

                int valueRef = 5; // Required initialize
            program.IncrementRef(ref valueRef);
            Console.WriteLine("Ref " + valueRef); // 6

            program.IncrementOut(out int valueOut);
            Console.WriteLine("Out " + valueOut); // 6
        }

        /// <summary>
        /// Ref read ad write
        /// </summary>
        /// <param name="number"></param>
        void IncrementRef(ref int number)
        {
            number++; // Read and write
        }

        /// <summary>
        /// Out only out
        /// </summary>
        /// <param name="number"></param>
        void IncrementOut(out int number)
        {
            number = 10;
        }

        // Enum
        public int GetValuesEnum(Enum value)
        {
            Console.WriteLine($"Value type enum {value.GetType()}");
            
            Array values = Enum.GetValues(value.GetType());
            return Array.IndexOf(values, value);
        }

    }
}
