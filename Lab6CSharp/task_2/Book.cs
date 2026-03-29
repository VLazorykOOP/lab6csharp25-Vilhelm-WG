namespace Lab6CSharp.task_2;

public class Book : BaseEdition
{
    public int Year { get; set; }
    public string Publisher { get; set; }

    public Book(string title, string author, int year, string publisher) 
        : base(title, author)
    {
        Year = year;
        Publisher = publisher;
    }

    public override void Show()
    {
        Console.WriteLine($"[КНИГА] \"{Title}\" | Автор: {AuthorSurname} | Рік: {Year} | Видавництво: {Publisher}");
    }
}