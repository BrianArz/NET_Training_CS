namespace Task2_3
{
    internal class Training
    {
        public string? Description { get; set; }
        public object[]? LecturesAndLessons { get; set; }

        public Training()
        {
        }

        public Training(string? description, object[] lecturesAndLessons)        {
            Description = description;
            LecturesAndLessons = lecturesAndLessons;
        }

        public void Add(object lecutureOrLesson)
        {
            var currentSize = 0;
            if (LecturesAndLessons != null)
            {
                currentSize = LecturesAndLessons.Length;
            }
            var newSize = currentSize + 1;
            var tempArray = new object[newSize];

            if (currentSize > 0)
            {
                for (int index = 0; index < currentSize; index++)
                {
                    tempArray[index] = LecturesAndLessons[index];
                }
            }

            tempArray[newSize - 1] = lecutureOrLesson;

            LecturesAndLessons = tempArray;
        }
    }
}
