using Lab6CSharp.task_2;
using Lab6CSharp.task_3;
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
                    // Створюємо каталог (масив BaseEdition)
                    BaseEdition[] catalog = new BaseEdition[]
                    {
                        new Book("Тіні забутих предків", "Коцюбинський", 1911, "Час"),
                        new Book("C# Documentation", "Microsoft", 2024, "Microsoft Press"),
                        new Book("Штучний інтелект у медицині", "Петренко", 2023, "Науковий вісник"),
                        new Book("Кобзар", "Шевченко", 1840, "Київська друкарня"),
                        new Book("Основи ООП", "Іваненко", 2021, "Програміст")
                    };

                    Console.WriteLine("=== ПОВНИЙ КАТАЛОГ ВИДАНЬ ===");
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
                            if (item.AuthorSurname.Contains(searchQuery, StringComparison.OrdinalIgnoreCase))
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
        
            Console.WriteLine("=== ТЕСТУВАННЯ ОБРОБКИ ПОМИЛОК ===\n");

            // Блок 1: Ловимо помилку неправильного року
            try
            {
                Console.WriteLine("Спроба створити книгу з 3000 роком...");
                Book badYearBook = new Book("Машина часу", "Уеллс", 3000, "Фантастика");
            }
            catch (InvalidEditionYearException ex)
            {
                Console.WriteLine($"[ПІЙМАЛИ КАСТОМНУ ПОМИЛКУ]: {ex.Message}");
                Console.WriteLine($"[ДЕТАЛІ]: Ви ввели рік {ex.ErrorYear}\n");
            }

            // Блок 2: Ловимо помилку порожніх даних
            try
            {
                Console.WriteLine("Спроба створити книгу без автора...");
                Book noAuthorBook = new Book("Таємна книга", "", 2020, "Анонімне");
            }
            catch (InvalidEditionDataException ex)
            {
                Console.WriteLine($"[ПІЙМАЛИ КАСТОМНУ ПОМИЛКУ]: {ex.Message}\n");
            }

            // Блок 3: Ловимо стандартний IndexOutOfRangeException
            try
            {
                Console.WriteLine("Спроба звернутися до неіснуючого елемента масиву...");
                BaseEdition[] testcatalog = new BaseEdition[2];
                testcatalog[0] = new Book("Кобзар", "Шевченко", 1840, "Київ");
                testcatalog[1] = new Book("Захар Беркут", "Франко", 1883, "Львів");

                // Звертаємося до 5-го елемента в масиві, де їх всього 2 (індекси 0 та 1)
                Console.WriteLine("Хочу побачити книгу №5:");
                catalog[5].Show(); 
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"[ПІЙМАЛИ СТАНДАРТНУ ПОМИЛКУ]: Вийшли за межі масиву!");
                Console.WriteLine($"[СИСТЕМНЕ ПОВІДОМЛЕННЯ]: {ex.Message}\n");
            }
            catch (Exception ex)
            {
                // Цей catch завжди ставиться останнім, щоб зловити будь-які інші непередбачені помилки
                Console.WriteLine($"[НЕВІДОМА ПОМИЛКА]: {ex.Message}");
            }

            Console.WriteLine("=== ПРОГРАМА УСПІШНО ЗАВЕРШИЛА РОБОТУ (без вильоту) ===");
        
    

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