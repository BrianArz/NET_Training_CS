namespace Task2_3
{
    internal class Lecture
    {
        public string? Description { get; set; }
        public string? Topic { get; set; }

        public Lecture(string? description, string? topic)
        {
            Description = description;
            Topic = topic;
        }
    }
}
