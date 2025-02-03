using System.Globalization;
using MathTools;

class Calculator
{
    static void Main() 
    {
        Console.WriteLine("Введите два числа через пробел: ");
        string input = Console.ReadLine();
        string[] parts = input.Split(' ');

        double a = double.Parse(parts[0], CultureInfo.InvariantCulture);
        double b = double.Parse(parts[1], CultureInfo.InvariantCulture);

        Console.WriteLine($"\nResault of Add: {MathOperation.Addition(a, b)}");
        Console.WriteLine($"Resault of Min: {MathOperation.Minus(a, b)} ");
        Console.WriteLine($"Resault of Mult: {MathOperation.Multi(a, b)} ");
        Console.WriteLine($"Result of Div: {MathOperation.Devide(a, b)}");
        Console.WriteLine($"Result of Max: {MathOperation.Max(a, b)}");
        Console.WriteLine($"Minimum number of a and b: {MathOperation.Min(a, b)}");
        Console.WriteLine($"Abs a: {MathOperation.Abs(a)}");
        Console.WriteLine(" ");
        Console.WriteLine(" ");
        Console.WriteLine(" ");
        Console.WriteLine("\n\n\n\tThis app was created by TommyWindows.");
    }
}