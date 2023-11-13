namespace Task2_3
{
    internal abstract class TrainingElements
    {
        public string? Description { get; set; }

        protected TrainingElements(string description)
        {
            Description = description;
        }
    }
}
