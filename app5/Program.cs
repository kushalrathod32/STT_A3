using System;

public class Calculator
{
    private double number1;
    private double number2;

    public Calculator(double num1, double num2)
    {
        number1 = num1;
        number2 = num2;
    }

    public double Add() => number1 + number2;

    public double Subtract() => number1 - number2;

    public double Multiply() => number1 * number2;

    public double? Divide()
    {
        return number2 == 0
            ? HandleDivideByZero()
            : number1 / number2;
    }

    private double? HandleDivideByZero()
    {
        try
        {
            throw new DivideByZeroException();
        }
        catch (DivideByZeroException)
        {
            return null;
        }
    }

    public string CheckSumEvenOdd()
    {
        double sum = Add();
        bool isInteger = Math.Abs(sum - Math.Round(sum)) < 1e-9;

        if (!isInteger)
            return "The sum is not an integer.";

        int intSum = (int)Math.Round(sum);
        return intSum % 2 == 0 ? "The sum is even." : "The sum is odd.";
    }
}

class Program
{
    static void Main(string[] args)
    {
        double num1, num2;

        if (!ReadNumber("Enter the first number:", out num1))
        {
            Console.WriteLine("Invalid input for first number.");
            return;
        }

        if (!ReadNumber("Enter the second number:", out num2))
        {
            Console.WriteLine("Invalid input for second number.");
            return;
        }

        Calculator calc = new Calculator(num1, num2);

        DisplayResult("Sum", calc.Add());
        DisplayResult("Difference", calc.Subtract());
        DisplayResult("Product", calc.Multiply());

        double? result = calc.Divide();
        Console.WriteLine(result.HasValue ? $"Quotient: {result.Value}" : "Cannot divide by zero");

        Console.WriteLine(calc.CheckSumEvenOdd());
    }

    private static bool ReadNumber(string prompt, out double result)
    {
        Console.WriteLine(prompt);
        string? input = Console.ReadLine();
        return double.TryParse(input, out result);
    }

    private static void DisplayResult(string label, double value)
    {
        Console.WriteLine($"{label}: {value}");
    }
}
