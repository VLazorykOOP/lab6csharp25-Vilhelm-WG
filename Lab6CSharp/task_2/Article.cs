namespace Lab6CSharp.task_2;

public class Article : BaseEdition
{
    public string JournalName { get; set; }
    public int IssueNumber { get; set; }
    public int Year { get; set; }

    public Article(string title, string author, string journal, int issueNumber, int year) 
        : base(title, author)
    {
        JournalName = journal;
        IssueNumber = issueNumber;
        Year = year;
    }

    public override void Show()
    {
        Console.WriteLine($"[СТАТТЯ] \"{Title}\" | Автор: {AuthorSurname} | Журнал: {JournalName} №{IssueNumber} ({Year})");
    }
}