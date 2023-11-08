namespace Task2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Lecture One
            var methodsLecture = new Lecture(null, "Methods in C#");

            //Lecture Two
            var indetifiersLecture = new Lecture("Identifiers Lecture Description", "Identifiers in C#");

            //Lecture Three
            var classesLecture = new Lecture("Classes Lecture Description", null);

            //Lesson One
            var methodsLesson = new PracticalLesson(null, "cs.com/methods-task", "cs.com/methods-solution");

            //Lesson Two
            var identifiersLesson = new PracticalLesson("Identifiers Lesson Description", "cs.com/identifiers-task", "cs.com/identifiers-solution");

            //Lesson Three
            var classesLesson = new PracticalLesson("Classes Lesson Description", null, "cs.com/classes-solution");

            //Object
            var methodsObject = new object[] {methodsLecture, methodsLesson};

            var training = new Training("Training Description", methodsObject);

            //Add Check
            training.Add(indetifiersLecture);
            training.Add(identifiersLesson);
            training.Add(classesLecture);

            var trainingTwo = new Training("Training Two Description", null);
            
            //Training Two
            trainingTwo.Add(methodsLesson);
            trainingTwo.Add(identifiersLesson);
            trainingTwo.Add(classesLesson);

            //Is Practical Check
            Console.WriteLine($"Training is practical? =  {training.IsPractical()}");
            Console.WriteLine($"\nTraining two is practical? {trainingTwo.IsPractical()}");

        }
    }
}