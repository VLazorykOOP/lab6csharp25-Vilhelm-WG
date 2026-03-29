public class Admin : Kadry
{
    private string position;
    private string viddil;

    public Admin() : base()
    {
        position = "Співробітник";
        viddil = "Загальний";
        Console.WriteLine("Конструктор Admin (без параметрів)");
    }

    public Admin(string Name) : base(Name)
    {
        position = "Співробітник";
        viddil = "Загальний";
        Console.WriteLine("Конструктор Admin (1 параметр Name)");
    }

    public Admin(string Name, int Age) : base(Name, Age)
    {
        position = "Співробітник";
        viddil = "Загальний";
        Console.WriteLine("Конструктор Admin (2 параметри Name, Age)");
    }

    public Admin(string Name, string Surname, int Age, string Position, string Viddil) 
        : base(Name, Surname, Age)
    {
        position = Position;
        viddil = Viddil;
        Console.WriteLine("Конструктор Admin (Повний)");
    }

    ~Admin() {
        Console.WriteLine("<-- Виклик: Деструктор ~Admin()");
    }

    public override void Show()
    {
        base.Show();
        Console.WriteLine($"Position: {position}, Viddil: {viddil}");
    }
}