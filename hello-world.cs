using System;

namespace HelloWorld
{
    class HelloWorld
    {
        static int Main()
        {
            // This line prints the famous "Hello World"
            Console.WriteLine("Hello World!");

            return 0;
        }
    }

    class MainClass
    {
        static string Usage()
        {
            return "\nPlease enter a numeric argument.\nUsage: Factorial <num>";
        }

        static bool isOutOfRange(long result)
        {
            if (result == -1)
                return true;
            else
                return false;

        }

        static long Factorial(int n)
        {
            if ((n < 0) || (n > 20))
            {
                return -1;
            }
            // Calculate the factorial iteratively rather than recursively.
            long tempResult = 1;
            for (int i = 1; i <= n; i++)
            {
                tempResult *= i;
            }
            return tempResult;
        }

        static int Main(string[] args)
        {
            int num = 0;

            try
            {
                num = int.Parse(args[0]);
            }
            catch (Exception ex)
            {
                if (ex is IndexOutOfRangeException)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine(Usage());
                    return 1;
                }
                else if (ex is FormatException)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine(Usage());
                    return 1;
                }
                else
                {
                    throw new ApplicationException("An error occurred - ", ex);
                }
            }

            long result = Factorial(num);

            if (isOutOfRange(result))
                Console.WriteLine("Input must be >= 0 and <= 20.");
            else
                Console.WriteLine($"The Factorial of {num} is {result}.");

            return 0;
        }
    }

}