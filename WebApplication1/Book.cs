namespace WebApplication1;

public abstract class Book
{
    public virtual string Title { get; set; }

    public virtual Author Author { get; set; }
}

public class BookInfo: Book
{
    public override string Title { get; set; }
    public override Author Author { get; set; }
}

public class Author
{
    public string Name { get; set; }
}
