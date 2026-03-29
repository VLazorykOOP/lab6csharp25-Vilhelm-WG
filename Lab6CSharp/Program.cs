using Lab6CSharp.task_2;
using User.task_1_from_Lab5_;

internal class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("Lab 5 - меню");
            Console.WriteLine("4 - Task 4");
            Console.WriteLine("3 - Task 3");
            Console.WriteLine("2 - Task 2");
            Console.WriteLine("1 - Task 1");
            Console.WriteLine("0 - Вихід");
            Console.Write("Ваш вибір: ");

            string? choice = Console.ReadLine();

            Console.WriteLine();

            switch (choice)
            {
                case "3":
                    break;

                case "2":
                {
                    // Створюємо каталог (масив інтерфейсів)
                    IEdition[] catalog = new IEdition[]
                    {
                        new Book("Тіні забутих предків", "Коцюбинський", 1911, "Час"),
                        new ElectronicResource("C# Documentation", "Microsoft", "learn.microsoft.com",
                            "Офіційний посібник"),
                        new Article("Штучний інтелект у медицині", "Петренко", "Науковий вісник", 12, 2023),
                        new Book("Кобзар", "Шевченко", 1840, "Київська друкарня"),
                        new Article("Основи ООП", "Шевченко", "Програміст", 5, 2021)
                    };

                    Console.WriteLine("=== ПОВНИЙ КАТАЛОГ ВИДАНЬ ===");
                    foreach (var item in catalog)
                    {
                        item.Show();
                    }

                    // Демонстрація роботи IComparable (стандартного .NET інтерфейсу)
                    Console.WriteLine("\n=== КАТАЛОГ ПІСЛЯ СОРТУВАННЯ ЗА АВТОРОМ ===");
                    Array.Sort(catalog);
                    foreach (var item in catalog)
                    {
                        item.Show();
                    }

                    // Організація пошуку
                    Console.Write("\nВведіть прізвище автора для пошуку: ");
                    string? searchQuery = Console.ReadLine();

                    if (!string.IsNullOrWhiteSpace(searchQuery))
                    {
                        Console.WriteLine($"\n--- Результати пошуку для '{searchQuery}': ---");
                        bool isFound = false;

                        foreach (var item in catalog)
                        {
                            if (item.IsSearched(searchQuery))
                            {
                                item.Show();
                                isFound = true;
                            }
                        }

                        if (!isFound)
                        {
                            Console.WriteLine("На жаль, видань цього автора не знайдено.");
                        }
                    }
                }

                    break;

                case "1":
                {
                    // Масив інтерфейсів IShowable - поліморфізм у дії
                    IShowable[] staff = new IShowable[]
                    {
                        new Engineer("Олег", "Петренко", 30, "Програміст"),
                        new Worker("Іван", "Бойко", 45, 5),
                        new Admin("Марія", "Коваль", 38, "HR"),
                        new Worker("Андрій", "Авраменко", 22, 2)
                    };

                    Console.WriteLine("--- Співробітники до сортування ---");
                    foreach (var person in staff) person.Show();

                    // Сортування (потрібно привести до масиву Kadry, бо IComparable там)
                    var sortedStaff = staff.Cast<Kadry>().ToArray();
                    Array.Sort(sortedStaff);

                    Console.WriteLine("\n--- Після сортування за прізвищем (IComparable) ---");
                    foreach (var person in sortedStaff) person.Show();

                    // Приклад клонування
                    Kadry original = new Kadry("Віктор", "Гайсюк", 20);
                    Kadry copy = (Kadry)original.Clone();
                    copy.Name = "Клон Віктора";

                    Console.WriteLine("\n--- Демонстрація ICloneable ---");
                    original.Show(); Console.WriteLine();
                    copy.Show(); Console.WriteLine();
                }
                    break;

                case "0":
                    return;

                default:
                    Console.WriteLine("Невірний вибір. Спробуйте ще раз.");
                    break;
            }
        }
    }
}