using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        try
        {
            int n = GetNumberFromUser();
            PrintNumbers(n);
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
    }

    static int GetNumberFromUser()
    {
        Console.Write("Enter a number (n): ");
        return Convert.ToInt32(Console.ReadLine());
    }

    static void PrintNumbers(int n)
    {
        Dictionary<int, string> outputMap = new Dictionary<int, string>()
        {
            { 3, "foo" },
            { 4, "baz" },
            { 5, "bar" },
            { 7, "jazz" },
            { 9, "huzz" },
        };

        for (int x = 1; x <= n; x++)
        {
            string output = "";

            foreach (KeyValuePair<int, string> kvp in outputMap)
            {
                if (x % kvp.Key == 0)
                {
                    output += kvp.Value;
                }
            }

            if (output == "")
            {
                output = x.ToString();
            }

            Console.Write("{0}", output);

            if (x < n)
            {
                Console.Write(", ");
            }
        }
    }
}
