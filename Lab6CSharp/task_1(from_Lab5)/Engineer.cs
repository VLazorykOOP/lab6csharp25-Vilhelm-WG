public class Engineer : Kadry
{
    public string Speciality { get; set; }

    public Engineer(string name, string surname, int age, string spec) 
        : base(name, surname, age)
    {
        Speciality = spec;
    }

    public override void Show()
    {
        base.Show();
        Console.WriteLine($"| Посада: Інженер, Спеціальність: {Speciality}");
    }
}