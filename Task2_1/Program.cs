namespace Task2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Test Constructor
            var pointOne = new PointWithMass(1,2,3,4);

            pointOne.Mass = -2;
            pointOne.X = 3;
            pointOne.Y = 4;
            pointOne.Z = 5;

            Console.WriteLine($"Point One: X = {pointOne.X} ; Y = {pointOne.Y} ; Z = {pointOne.Z} ; Mass = {pointOne.Mass}");
            Console.WriteLine($"First check, IsZero: {pointOne.IsZero()}");

            pointOne.Mass = 4.5;
            pointOne.X = 0;
            pointOne.Y = 0;
            pointOne.Z = 0;

            Console.WriteLine($"\nPoint One: X = {pointOne.X} ; Y = {pointOne.Y} ; Z = {pointOne.Z} ; Mass = {pointOne.Mass}");
            Console.WriteLine($"Second check, IsZero: {pointOne.IsZero()}");
        }
    }
}