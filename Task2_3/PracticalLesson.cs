namespace Task2_3
{
    internal class PracticalLesson
    {
        public string? Description { get; set; }
        public string? TaskLink { get; set; }
        public string? SolutionLink { get; set; }

        public PracticalLesson(string? description, string? taskLink, string? solutionLink)
        {
            Description = description;
            TaskLink = taskLink;
            SolutionLink = solutionLink;
        }
    }
}
