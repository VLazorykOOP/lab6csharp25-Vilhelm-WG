namespace Lab6CSharp.task_2;

public class ElectronicResource : BaseEdition
{
    public string Link { get; set; }
    public string Annotation { get; set; }

    public ElectronicResource(string title, string author, string link, string annotation) 
        : base(title, author)
    {
        Link = link;
        Annotation = annotation;
    }

    public override void Show()
    {
        Console.WriteLine($"[Е-РЕСУРС] \"{Title}\" | Автор: {AuthorSurname}\n   -> Посилання: {Link}\n   -> Анотація: {Annotation}");
    }
}