namespace Task5_2
{
    internal class Book
    {
        public string Title { get; }
        public DateOnly? PublicationDate { get; }
        public List<string>? Authors { get; }
        
        public Book(string title, DateOnly? publicationDate, List<string>? authors)
        {
            if (string.IsNullOrEmpty(title)) throw new ArgumentException("Title can not be null");

            Title = title;
            PublicationDate = publicationDate;
            Authors = authors != null ? authors.Distinct().ToList() : new List<string>();
        }

        public override string ToString()
        {
            string authorsString = string.Join(", ", Authors);
            return $"Title: {Title}, Publication Date: {PublicationDate}, Authors: {authorsString}";
        }
    }
}
