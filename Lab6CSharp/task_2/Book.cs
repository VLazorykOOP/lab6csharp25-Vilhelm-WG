using Lab6CSharp.task_3;

public class Book : BaseEdition
{
    public int Year { get; set; }
    public string Publisher { get; set; }

    public Book(string title, string author, int year, string publisher) : base(title, author)
    {
        // Викидаємо наш другий кастомний виняток
        int currentYear = DateTime.Now.Year;
        if (year < 1440 || year > currentYear)
        {
            throw new InvalidEditionYearException($"Некоректний рік видання. Рік має бути між 1440 та {currentYear}.", year);
        }
            
        Year = year;
        Publisher = publisher;
    }

    public override void Show()
    {
        Console.WriteLine($"[КНИГА] \"{Title}\" | Автор: {AuthorSurname} | Рік: {Year} | Видавництво: {Publisher}");
    }
}