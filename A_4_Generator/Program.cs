using FooBarGenerator;
class Program
{
    static void Main()
    {
        try
        {
            int n = GetNumberFromUser();
            GenerateNumbers(n);
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

    static void GenerateNumbers(int n)
    {
        Generator generator = new Generator();
        generator.AddRule(3, "foo");
        generator.AddRule(4, "bar");
        generator.AddRule(5, "bar");
        generator.AddRule(7, "jazz");
        generator.AddRule(9, "huzz");

        generator.GenerateNumbers(n);
    }
}