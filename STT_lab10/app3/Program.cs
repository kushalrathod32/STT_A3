using System;

public class LoopFunctionShowcase
{
    public void DisplayOneToTen()
    {
        for (int num = 1; num <= 10; num++)
        {
            Console.WriteLine(num);
        }
    }

    public void GetInputLoop()
    {
        string? userText;
        while (true)
        {
            Console.Write("Type something (type 'exit' to end): ");
            userText = Console.ReadLine();

            if (userText == null || userText.Trim().ToLower() == "exit")
                break;

            Console.WriteLine($"Input received: {userText}");
        }
    }

    public long ComputeFactorial(int n)
    {
        if (n < 0)
        {
            throw new ArgumentException("Cannot compute factorial of a negative number.");
        }

        long result = 1;
        for (int i = 2; i <= n; i++)
        {
            result *= i;
        }
        return result;
    }
}

class EntryPoint
{
    static void Main()
    {
        var handler = new LoopFunctionShowcase();

        Console.WriteLine("Numbers from 1 through 10:");
        handler.DisplayOneToTen();

        Console.WriteLine("\nInteractive input session begins (type 'exit' to continue):");
        handler.GetInputLoop();

        Console.Write("\nEnter a non-negative whole number to get its factorial: ");
        string? value = Console.ReadLine();

        if (int.TryParse(value, out int num) && num >= 0)
        {
            try
            {
                long fact = handler.ComputeFactorial(num);
                Console.WriteLine($"Factorial of {num} = {fact}");
            }
            catch (ArgumentException error)
            {
                Console.WriteLine(error.Message);
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Enter a valid non-negative integer.");
        }
    }
}

