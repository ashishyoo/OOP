public class Animal
{
    public virtual void Speak()
    {
        Console.WriteLine("Animal speaks");
    }
}

public class Dog : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Dog barks");
    }
}

public class Cat : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Cat meows");
    }
}

class Program
{
    static void Main()
    {
        Animal myAnimal;

        myAnimal = new Dog();
        myAnimal.Speak(); // Output: Dog barks

        myAnimal = new Cat();
        myAnimal.Speak(); // Output: Cat meows
    }
}
