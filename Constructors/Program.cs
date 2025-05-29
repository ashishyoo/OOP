public class Person
{
    private int id;
    private string name;

    public Person() // default constructor
    {
        id = 0;
        name = "undefined";
        Console.WriteLine("Person object created..");
    }

    public Person(int id, string name) // parameterized constructor
    {
        this.id = id;
        this.name = name;
    }

    public void Introduce()
    {
        Console.WriteLine($"Hi, my name is {name} and my id is {id}");
    }
}

class Program
{
    static void Main(String[] args)
    {
        Person person1 = new Person(); // calls Person()
        person1.Introduce();
        Person person2 = new Person(1, "Yeju"); // calls Person(int id, string name)
        person2.Introduce();
    }
}