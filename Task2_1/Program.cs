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

        }
    }
}