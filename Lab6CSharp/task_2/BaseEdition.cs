using Lab6CSharp.task_3;

public abstract class BaseEdition
{
    public string Title { get; set; }
    public string AuthorSurname { get; set; }

    public BaseEdition(string title, string authorSurname)
    {
        // Викидаємо наш перший кастомний виняток
        if (string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(authorSurname))
        {
            throw new InvalidEditionDataException("Назва видання та прізвище автора не можуть бути порожніми!");
        }
        Title = title;
        AuthorSurname = authorSurname;
    }
    public abstract void Show();
}

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