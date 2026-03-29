namespace Lab6CSharp.task_3;

// 1. Власний виняток для порожніх даних
public class InvalidEditionDataException : Exception
{
    public InvalidEditionDataException(string message) : base(message) { }
}