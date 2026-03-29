public class Kadry
{
    protected string name;
    protected string surname;
    protected int age;

    public Kadry()
    {
        name = "Їмʼя не вказано";
        surname = "Прізвище не вказано";
        age = 0;
        Console.WriteLine("\nКонструктор Kadry (без параметрів)");
    }

    public Kadry(string Name)
    {
        name = Name;
        surname = "Прізвище не вказано";
        age = 0;
        Console.WriteLine("\nКонструктор Kadry (1 параметр Name)");
    }

    public Kadry(string Name, int Age)
    {
        name = Name;
        age = Age;
        surname = "";
        Console.WriteLine("\nКонструктор Kadry (2 параметр Age)");
    }
    
    public Kadry(string Name, string Surname, int Age)
    {
        name = Name;
        surname = Surname;
        age = Age;
    }
    
    ~Kadry() {
        Console.WriteLine($"<-- Виклик: Деструктор ~Kadry()\n");
    }

    public virtual void Show()
    {
        Console.WriteLine($"Name: {name}, Surname: {surname}, Age: {age}");
    }
}