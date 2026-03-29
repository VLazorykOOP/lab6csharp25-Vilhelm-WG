public class Worker : Kadry
{
    private int rozread;
    private int no_tsehu;

    // 1. Без параметрів
    public Worker() : base()
    {
        rozread = 1;
        no_tsehu = 1;
        Console.WriteLine("Конструктор Worker (без параметрів)");
    }

    // 2. З одним параметром (Name)
    public Worker(string Name) : base(Name)
    {
        rozread = 1;
        no_tsehu = 1;
        Console.WriteLine("Конструктор Worker (1 параметр Name)");
    }

    // 3. З двома параметрами (Name, Age)
    public Worker(string Name, int Age) : base(Name, Age)
    {
        rozread = 1;
        no_tsehu = 1;
        Console.WriteLine("Конструктор Worker (2 параметри Name, Age)");
    }

    // 4. Повний конструктор
    public Worker(string Name, string Surname, int Age, int Rozread, int No_tehu) 
        : base(Name, Surname, Age)
    {
        rozread = Rozread;
        no_tsehu = No_tehu;
        Console.WriteLine("Конструктор Worker (Повний)");
    }

    ~Worker() {
        Console.WriteLine("<-- Виклик: Деструктор ~Worker()");
    }

    public override void Show()
    {
        base.Show();
        Console.WriteLine($"Rozread: {rozread}, No_tehu: {no_tsehu}");
    }
}