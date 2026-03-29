public class Engineer : Kadry
{
    private string speciality;
    private int category;

    public Engineer() : base()
    {
        speciality = "Не вказано";
        category = 0;
        Console.WriteLine("Конструктор Engineer (без параметрів)");
    }

    public Engineer(string Name) : base(Name)
    {
        speciality = "Не вказано";
        category = 0;
        Console.WriteLine("Конструктор Engineer (1 параметр Name)");
    }

    public Engineer(string Name, int Age) : base(Name, Age)
    {
        speciality = "Не вказано";
        category = 0;
        Console.WriteLine("Конструктор Engineer (2 параметри Name, Age)");
    }

    public Engineer(string Name, string Surname, int Age, string Speciality, int Category) 
        : base(Name, Surname, Age)
    {
        speciality = Speciality;
        category = Category;
        Console.WriteLine("Конструктор Engineer (Повний)");
    }

    ~Engineer() {
        Console.WriteLine("<-- Виклик: Деструктор ~Engineer()");
    }

    public override void Show()
    {
        base.Show();
        Console.WriteLine($"Speciality: {speciality}, Category: {category}");
    }
}