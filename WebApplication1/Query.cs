namespace WebApplication1;

public class Query
{
    public Book GetBook() =>
        new BookInfo
        {
            Title = "C# in depth.",
            Author = new Author
            {
                Name = "Jon Skeet"
            }
        };
}
