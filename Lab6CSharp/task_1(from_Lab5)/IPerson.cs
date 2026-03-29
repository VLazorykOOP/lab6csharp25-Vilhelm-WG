namespace User.task_1_from_Lab5_;

// Наш власний інтерфейс для персональних даних
public interface IPerson
{
    string Name { get; set; }
    string Surname { get; set; }
    int Age { get; set; }
}