using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number (n): ");
        int n;
        try
        {
            n = Convert.ToInt32(Console.ReadLine());
            FoobarPrinter foobarPrinter = new FoobarPrinter(n);
            foobarPrinter.PrintNumbers();
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
    }
}

class FoobarPrinter
{
    private int n;

    public FoobarPrinter(int number)
    {
        n = number;
    }

    public void PrintNumbers()
    {
        for (int x = 1; x <= n; x++)
        {
            if (x % 3 == 0 && x % 5 == 0)
                Console.Write("foobar");
            else if (x % 3 == 0)
                Console.Write("foo");
            else if (x % 5 == 0)
                Console.Write("bar");
            else
                Console.Write(x);

            if (x < n)
                Console.Write(", ");
        }
        Console.WriteLine(); // New line after printing all numbers
    }
}
