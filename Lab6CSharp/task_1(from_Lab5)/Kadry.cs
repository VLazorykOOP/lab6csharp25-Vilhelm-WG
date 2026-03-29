using User.task_1_from_Lab5_;

public class Kadry : IPerson, IShowable, IComparable, ICloneable
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Age { get; set; }

    public Kadry(string name, string surname, int age)
    {
        Name = name;
        Surname = surname;
        Age = age;
    }

    // Реалізація IShowable
    public virtual void Show()
    {
        Console.Write($"{Surname} {Name}, Вік: {Age} ");
    }

    // Реалізація IComparable (сортування за прізвищем)
    public int CompareTo(object? obj)
    {
        if (obj is Kadry other)
            return string.Compare(this.Surname, other.Surname);
        throw new ArgumentException("Об'єкт не є Kadry");
    }

    // Реалізація ICloneable (створення копії)
    public object Clone()
    {
        return new Kadry(Name, Surname, Age);
    }
}