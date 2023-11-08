namespace Task2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Test Constructor
            var pointOne = new PointWithMass(7,8,2,4);

            //Point two with negative mass
            var pointTwo = new PointWithMass(20, 2, -3, -5.2);

            //Point One and IsZero validation
            Console.WriteLine($"Point One: X = {pointOne.X} ; Y = {pointOne.Y} ; Z = {pointOne.Z} ; Mass = {pointOne.Mass}");
            Console.WriteLine($"Point One, IsZero: {pointOne.IsZero()}");

            //Point Two and IsZero validation
            Console.WriteLine($"\nPoint Two: X = {pointTwo.X} ; Y = {pointTwo.Y} ; Z = {pointTwo.Z} ; Mass = {pointTwo.Mass}");
            Console.WriteLine($"Point Two, IsZero: {pointTwo.IsZero()}");

            //Distance between Point One and Point Two
            Console.WriteLine($"\nDistance between Point One and Point Two = {pointOne.CalculateDistanceTo(pointTwo)}");
        }
    }
}