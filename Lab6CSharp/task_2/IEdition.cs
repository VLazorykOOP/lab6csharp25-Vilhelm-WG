namespace Lab6CSharp.task_2;

public interface IEdition : IComparable<IEdition>
{
    string Title { get; set; }
    string AuthorSurname { get; set; }
        
    void Show();
    bool IsSearched(string surname);
}