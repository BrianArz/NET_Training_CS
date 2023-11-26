namespace Task5_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Test constructor
                var catalog = new Catalog();
                catalog.AddBook(new Book("Book 1", new DateOnly(2019, 1, 1), new List<string>() { "Author 1" }), "123-4-56-789012-1");
                catalog.AddBook(new Book("Book 2", new DateOnly(2022, 1, 1), new List<string>() { "Author 1", "Author 2" }), "1234567890122");
                catalog.AddBook(new Book("Book 3", new DateOnly(2018, 1, 1), new List<string>() { "Author 1", "Author 3" }), "123-4-56-789012-3");
                catalog.AddBook(new Book("Book 4", new DateOnly(2018, 1, 1), new List<string>() { "Author 1", "Author 3" }), "123-4-56-789012-4");
                catalog.AddBook(new Book("Book 5", null, new List<string>() { "Author 1" }), "123-4-56-789012-5");

                // Test get book
                Console.WriteLine($"\nBook with isbn 123-4-56-789012-1: {catalog.GetBook("1234567890121")}");
                Console.WriteLine($"\nBook with isbn 1234567890122: {catalog.GetBook("123-4-56-789012-2")}");

                // Test GetTitlesAlphabetically
                Console.WriteLine("\nCatalog books ordered by title name:");
                foreach (var (isbn, title) in catalog.GetTitlesAlphabetically())
                {
                    Console.WriteLine($"ISBN: {isbn}, Title: {title}");
                }

                // Test GetBooksByAuthor
                Console.WriteLine("\nBooks by Author 1:");
                foreach (var registry in catalog.GetBooksByAuthor("Author 1"))
                {
                    Console.WriteLine($"Book: {registry.book.Title}, Publication Date: {registry.book.PublicationDate?.ToShortDateString()}");
                }

                // Test Authors Book Count
                Console.WriteLine("\nAll authors book count: ");
                foreach (var registry in catalog.GetAuthorsBookCount())
                {
                    Console.WriteLine($"{registry.Author} has {registry.BookCount} book(s) in the catalog.");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}