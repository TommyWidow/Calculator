using System;
using System.Collections.Generic;
using System.Globalization;
using input;
using MathTools;

class Calculator
{
    static void Main()
    {
        Input input = new Input();
        string string1 = "Enter two numbers separated by a space: ";

        input.InputString(string1);
        Console.WriteLine();

        double a = 0, b = 0;
        bool validInput = false;

        while (!validInput)
        {
            try
            {
                string inputs = Console.ReadLine();
                string[] parts = inputs.Split(' ');

                if (parts.Length != 2)
                {
                    throw new FormatException("You need to enter two numbers.");
                }

                a = double.Parse(parts[0], CultureInfo.InvariantCulture);
                b = double.Parse(parts[1], CultureInfo.InvariantCulture);

                validInput = true;
            }
            catch (FormatException)
            {
                Console.WriteLine($"Input error\n");
                Console.WriteLine("Try again.");
            }
        }

        var (absA, absB) = MathOperation.Abs(a, b);

        List<string> results = new List<string>
        {
            $"\nResult of Add: {MathOperation.Addition(a, b)}",
            $"Result of Min: {MathOperation.Minus(a, b)}",
            $"Result of Mult: {MathOperation.Multi(a, b)}",
            $"Result of Div: {MathOperation.Devide(a, b)}",
            $"Result of Max: {MathOperation.Max(a, b)}",
            $"Minimum number of a and b: {MathOperation.Min(a, b)}",
            $"Abs a: {absA}, Abs b: {absB}",
            "\n\n\n\tThis app was created by TommyWindows."
        };

        foreach (string result in results)
        {
            input.InputString(result);
            Console.WriteLine();
        }
    }
}
