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

