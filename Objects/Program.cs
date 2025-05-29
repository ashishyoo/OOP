public class Person
{
    public string name;

    public void Introduce()
    {
        Console.WriteLine($"Hi, my name is {name}");
    }
}

class Program
{
    static void Main(String[] args)
    {
        Person person = new Person(); // creating Person object
        person.name = "Yeju";
        person.Introduce();
    }
}