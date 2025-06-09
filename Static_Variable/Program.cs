public class Counter
{
    public static int TotalCount = 0; // Shared across all objects

    public Counter()
    {
        TotalCount++;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Counter c1 = new Counter();
        Counter c2 = new Counter();
        Counter c3 = new Counter();

        Console.WriteLine($"Total objects created: {Counter.TotalCount}"); // Output: Total objects created: 3
    }
}
