public static class Calculator
{
    public static int Add(int a, int b)
    {
        return a + b;
    }

    public static int Multiply(int a, int b)
    {
        return a * b;
    }
}

class Program
{
    static void Main(string[] args)
    {
        int sum = Calculator.Add(10, 5);
        int product = Calculator.Multiply(4, 6);

        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Product: {product}");
    }
}
