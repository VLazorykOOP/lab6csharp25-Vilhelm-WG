public class Admin : Kadry
{
    public string Department { get; set; }

    public Admin(string name, string surname, int age, string dept) 
        : base(name, surname, age)
    {
        Department = dept;
    }

    public override void Show()
    {
        base.Show();
        Console.WriteLine($"| Посада: Адміністрація, Відділ: {Department}");
    }
}