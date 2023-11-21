namespace Task2_3
{
    internal class Training : TrainingElements
    {
        public Lesson[]? LecturesAndPractical { get; set; }

        public Training(string? description, Lesson[] lecturesAndPracticals) : base(description)
        {
            LecturesAndPractical = lecturesAndPracticals;
        }

        public void Add(Lesson lecutureOrPractical)
        {
            var currentSize = 0;
            if (LecturesAndPractical != null)
            {
                currentSize = LecturesAndPractical.Length;
            }
            var newSize = currentSize + 1;
            var tempArray = new Lesson[newSize];

            if (currentSize > 0)
            {
                for (int index = 0; index < currentSize; index++)
                {
                    tempArray[index] = LecturesAndPractical[index];
                }
            }

            tempArray[newSize - 1] = lecutureOrPractical;

            LecturesAndPractical = tempArray;
        }

        public bool IsPractical()
        {
            if (LecturesAndPractical == null)
                return false;

            foreach (var element in LecturesAndPractical)
            {
                if(element is Lecture) return false;
            }

            return true;
        }

        public Training Clone()
        {
            var clonedTraining = new Training(Description, null);
            foreach (var element in LecturesAndPractical)
            {
                clonedTraining.Add(element.Clone());
            }

            return clonedTraining;
        }
    }
}
