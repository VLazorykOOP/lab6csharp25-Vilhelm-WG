namespace Lab6CSharp.task_3;

public class InvalidEditionYearException : Exception
{
    public int ErrorYear { get; } // Запам'ятовуємо неправильний рік

    public InvalidEditionYearException(string message, int year) : base(message)
    {
        ErrorYear = year;
    } 
}