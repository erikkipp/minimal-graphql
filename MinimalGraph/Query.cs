using HotChocolate.Authorization;

namespace MinimalGraph;

public sealed class Query
{
    [Authorize]
    public Book GetBook() =>
        new Book
        {
            Title = "C# in depth.",
            Author = new Author
            {
                Name = "Jon Skeet"
            }
        };
}
