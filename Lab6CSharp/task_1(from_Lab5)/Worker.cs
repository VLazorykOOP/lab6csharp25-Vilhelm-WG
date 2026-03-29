public class Worker : Kadry
{
    public int Rank { get; set; }

    public Worker(string name, string surname, int age, int rank) 
        : base(name, surname, age)
    {
        Rank = rank;
    }

    public override void Show()
    {
        base.Show();
        Console.WriteLine($"| Посада: Робітник, Розряд: {Rank}");
    }
}