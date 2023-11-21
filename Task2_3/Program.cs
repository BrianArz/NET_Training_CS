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
            var methodsPractical = new PracticalLesson(null, "cs.com/methods-task", "cs.com/methods-solution");

            //Lesson Two
            var identifiersPractical = new PracticalLesson("Identifiers Lesson Description", "cs.com/identifiers-task", "cs.com/identifiers-solution");

            //Lesson Three
            var classesPractical = new PracticalLesson("Classes Lesson Description", null, "cs.com/classes-solution");

            //Object
            var methodsObject = new Lesson[] { methodsLecture, methodsPractical };

            var training = new Training("Training Description", methodsObject);

            //Add Check
            training.Add(indetifiersLecture);
            training.Add(identifiersPractical);
            training.Add(classesLecture);

            var trainingTwo = new Training("Training Two Description", null);

            //Training Two
            trainingTwo.Add(methodsPractical);
            trainingTwo.Add(identifiersPractical);
            trainingTwo.Add(classesPractical);

            //Is Practical Check
            Console.WriteLine($"Training is practical? =  {training.IsPractical()}");
            Console.WriteLine($"\nTraining two is practical? {trainingTwo.IsPractical()}");

            //Clone Check
            var clonedTraing = trainingTwo.Clone();
            Console.WriteLine($"\nCloned Training is practical? {clonedTraing.IsPractical()}");

            //Deep cloning test
            var originalLecture = new Lecture("This is an original lecture", "Deep Cloning");
            var clonedLecture = (Lecture)originalLecture.Clone();

            clonedLecture.Description = "This is a cloned lecture";
            clonedLecture.Topic = "Deep Cloning Cloned Topic";

            Console.WriteLine($"\nOriginal lecture description: {originalLecture.Description} , topic: {originalLecture.Topic}");
            Console.WriteLine($"\nCloned lecture description: {clonedLecture.Description} , topic: {clonedLecture.Topic}");
        }
    }
}