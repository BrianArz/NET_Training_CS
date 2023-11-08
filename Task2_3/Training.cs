namespace Task2_3
{
    internal class Training
    {
        public string? Description { get; set; }
        public Lecture[] Lectures { get; set; }
        public PracticalLesson[] PracticalLessons { get; set;}

        public Training(string? description, Lecture[] lectures, PracticalLesson[] practicalLessons)        {
            Description = description;
            Lectures = lectures;
            PracticalLessons = practicalLessons;
        }

    }
}
