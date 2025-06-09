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
        Person person1 = new Person(); // Output: Person object created..
        person1.Introduce(); // Output: Hi, my name is undefined and my id is 0
        Person person2 = new Person(1, "Yeju"); // Output: Hi, my name is Yeju and my id is 1
        person2.Introduce();
    }
}