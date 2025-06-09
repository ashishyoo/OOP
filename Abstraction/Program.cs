// Abstract base class
public abstract class Animal
{
    // Abstract method
    public abstract void MakeSound();

    // Regular method
    public void Eat()
    {
        Console.WriteLine("Animal is eating...");
    }
}

// Derived class
public class Dog : Animal
{
    // Must implement abstract method
    public override void MakeSound()
    {
        Console.WriteLine("Dog barks.");
    }
}

// Another derived class
public class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Cat meows.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Animal dog = new Dog();
        dog.MakeSound();  // Output: Dog barks.
        dog.Eat();        // Output: Animal is eating...

        Animal cat = new Cat();
        cat.MakeSound();  // Output: Cat meows.
        cat.Eat();        // Output: Animal is eating...
    }
}
