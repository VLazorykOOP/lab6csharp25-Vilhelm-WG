namespace Lab6CSharp.task_2;

// 2. Базовий абстрактний клас для уникнення дублювання коду
public abstract class BaseEdition : IEdition
{
    public string Title { get; set; }
    public string AuthorSurname { get; set; }

    public BaseEdition(string title, string authorSurname)
    {
        Title = title;
        AuthorSurname = authorSurname;
    }

    // Абстрактний метод, який кожен нащадок реалізує по-своєму
    public abstract void Show();

    // Реалізація пошуку за прізвищем автора
    public bool IsSearched(string surname)
    {
        // StringComparison.OrdinalIgnoreCase ігнорує регістр (великі/малі літери)
        return string.Equals(AuthorSurname, surname, StringComparison.OrdinalIgnoreCase);
    }

    // Реалізація методу з інтерфейсу IComparable<IEdition> (.NET)
    // Сортуватимемо видання за прізвищем автора за алфавітом
    public int CompareTo(IEdition? other)
    {
        if (other == null) return 1;
        return string.Compare(this.AuthorSurname, other.AuthorSurname, StringComparison.OrdinalIgnoreCase);
    }
}