namespace Task5_2
{
    internal class Catalog
    {
        private Dictionary<string, Book> _catalog = new Dictionary<string, Book>();

        private string UnformatIsbn(string isbn)
        {
            return isbn.Replace("-", "");
        }

        public void AddBook(Book book, string isbn)
        {
            _catalog[UnformatIsbn(isbn)] = book;
        }

        public Book GetBook(string isbn)
        {
            if (_catalog.TryGetValue(UnformatIsbn(isbn), out var book))
                return book;
            else
                throw new Exception("Book not found");
        }

        public IEnumerable<(string Isbn, string Title)> GetTitlesAlphabetically()
        {
            return _catalog.OrderBy(b => b.Value.Title).Select(pair => (Isbn: pair.Key, pair.Value.Title));
        }

        public IEnumerable<(string Isbn, Book book)> GetBooksByAuthor(string author)
        {
            return _catalog.Where(b => b.Value.Authors.Contains(author)).OrderBy(b => b.Value.PublicationDate).Select(pair => (Isbn: pair.Key, pair.Value));
        }

        public IEnumerable<(string Author, int BookCount)> GetAuthorsBookCount()
        {
            return _catalog.Values.SelectMany(b => b.Authors).GroupBy(author => author).Select(pair => (Author: pair.Key, BookCount: pair.Count()));
        }
    }
}
