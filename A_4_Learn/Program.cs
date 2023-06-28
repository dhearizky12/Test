using System;
using System.Collections.Generic;

class MyClass
{
    private Dictionary<int, string> outputMap;

    public MyClass()
    {
        outputMap = new Dictionary<int, string>();
    }

    public void AddRule(int input, string output)
    {
        outputMap[input] = output;
    }

    public void PrintNumbers(int n)
    {
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

class Program
{
    static void Main()
    {
        try
        {
            int n = GetNumberFromUser();
            MyClass myClass = new MyClass();
            ConfigureRules(myClass);
            myClass.PrintNumbers(n);
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

    static void ConfigureRules(MyClass myClass)
    {
        myClass.AddRule(3, "foo");
        myClass.AddRule(4, "baz");
        myClass.AddRule(5, "bar");
        myClass.AddRule(7, "jazz");
        myClass.AddRule(9, "huzz");
    }
}
