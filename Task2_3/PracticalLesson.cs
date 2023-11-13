namespace Task2_3
{
    internal class PracticalLesson : Lesson
    {
        public string? TaskLink { get; set; }
        public string? SolutionLink { get; set; }

        public PracticalLesson(string? description, string? taskLink, string? solutionLink) : base(description)
        {
            TaskLink = taskLink;
            SolutionLink = solutionLink;
        }
    }
}
