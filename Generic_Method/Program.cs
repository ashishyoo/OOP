public class Utility
{
    // Generic method
    public void PrintItem<T>(T item)
    {
        Console.WriteLine("Item: " + item);
    }
}

class Program
{
    static void Main()
    {
        Utility util = new Utility();
        util.PrintItem<int>(10);         // Output: Item: 10
        util.PrintItem<string>("Hello"); // Output: Item: Hello
        util.PrintItem<double>(3.14);    // Output: Item: 3.14
    }
}
