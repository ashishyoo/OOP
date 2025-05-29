// Base class
public class Animal
{
    public void Eat()
    {
        Console.WriteLine("Eating food...");
    }
}

// Derived class Dog
public class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("Barking...");
    }
}

// Derived class Cat
public class Cat : Animal
{
    public void Meow()
    {
        Console.WriteLine("Meowing...");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Dog dog = new Dog();
        dog.Eat(); // Output: Eating food...
        dog.Bark(); // Output: Barking...

        Cat cat = new Cat();
        cat.Eat(); // Output: Eating food...
        cat.Meow(); // Output: Meowing...
    }
}
