public class Box<T>
{
    private T Value;

    public Box(T value)
    {
        Value = value;
    }

    public void Display()
    {
        Console.WriteLine("Box contains: " + Value);
    }
}

class Program
{
    static void Main()
    {
        Box<int> intBox = new Box<int>(100);
        intBox.Display();  // Output: Box contains: 100

        Box<string> strBox = new Box<string>("Apple");
        strBox.Display();  // Output: Box contains: Apple
    }
}
