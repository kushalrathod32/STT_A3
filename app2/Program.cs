using System;

public class SimpleCalculator
{
    private readonly double x;
    private readonly double y;

    public SimpleCalculator(double x, double y)
    {
        this.x = x;
        this.y = y;
    }

    public double Sum() => x + y;

    public double Difference() => x - y;

    public double Product() => x * y;

    public double? Quotient()
    {
        return Math.Abs(y) < 1e-9 ? null : x / y;
    }

    public string SumParity()
    {
        double total = Sum();
        bool isInteger = Math.Abs(total - Math.Round(total)) < 1e-9;

        if (!isInteger)
            return "The sum is not an integer.";

        return ((int)Math.Round(total)) % 2 == 0 ? "The sum is even." : "The sum is odd.";
    }
}

public class Program
{
    public static void Main()
    {
        double a = ReadDouble("Enter the first number:");
        double b = ReadDouble("Enter the second number:");

        var calc = new SimpleCalculator(a, b);

        Console.WriteLine($"Sum: {calc.Sum()}");
        Console.WriteLine($"Difference: {calc.Difference()}");
        Console.WriteLine($"Product: {calc.Product()}");

        var division = calc.Quotient();
        Console.WriteLine(division.HasValue ? $"Quotient: {division.Value}" : "Cannot divide by zero");

        Console.WriteLine(calc.SumParity());
    }

    private static double ReadDouble(string prompt)
    {
        Console.WriteLine(prompt);
        string? input = Console.ReadLine();
        double result;

        while (!double.TryParse(input, out result))
        {
            Console.WriteLine("Invalid input. Try again:");
            input = Console.ReadLine();
        }

        return result;
    }
}
