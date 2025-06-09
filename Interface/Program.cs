// Interface with Draw method
public interface IShape
{
    void Draw();
}

// Circle implements IShape
public class Circle : IShape
{
    public void Draw()
    {
        Console.WriteLine("Drawing a Circle.");
    }
}

// Rectangle implements IShape
public class Rectangle : IShape
{
    public void Draw()
    {
        Console.WriteLine("Drawing a Rectangle.");
    }
}

// Triangle implements IShape
public class Triangle : IShape
{
    public void Draw()
    {
        Console.WriteLine("Drawing a Triangle.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        IShape shape;

        shape = new Circle();
        shape.Draw();  // Output: Drawing a Circle.

        shape = new Rectangle();
        shape.Draw();  // Output: Drawing a Rectangle.

        shape = new Triangle();
        shape.Draw();  // Output: Drawing a Triangle.
    }
}
