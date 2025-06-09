public class Calculator
{
    // Add two integers
    public int Add(int a, int b)
    {
        return a + b;
    }

    // Add three integers
    public int Add(int a, int b, int c)
    {
        return a + b + c;
    }

    // Add two doubles
    public double Add(double a, double b)
    {
        return a + b;
    }
}

class Program
{
    static void Main()
    {
        Calculator calc = new Calculator();

        Console.WriteLine(calc.Add(2, 3)); // Output: 5
        Console.WriteLine(calc.Add(2, 3, 4)); // Output: 9
        Console.WriteLine(calc.Add(2.5, 3.2)); // Output: 5.7
    }
}
