
namespace Task2_1
{
    internal class PointWithMass
    {
        private int[] _coordinates = new int[3];
        private double _mass;

        public PointWithMass(int x, int y, int z, double mass)
        {
            X = x;
            Y = y;
            Z = z;
            Mass = mass;
        }

        public int X
        {
            get => _coordinates[0];
            set => _coordinates[0] = value;
        }

        public int Y
        {
            get => _coordinates[1];
            set => _coordinates[1] = value;
        }

        public int Z
        {
            get => _coordinates[2];
            set => _coordinates[2] = value;
        }

        //Mass cannot be less than zero
        public double Mass
        {
            get => _mass;
            set => _mass = value >= 0 ? value : 0;
        }

        public bool IsZero()
        {
            return X == 0 && Y == 0 && Z == 0;
        }

        public double CalculateDistanceTo(PointWithMass point)
        {
            return Math.Sqrt(Math.Pow((point.X - X), 2) + Math.Pow((point.Y - Y), 2) + Math.Pow((point.Z - Z),2));
        }
    }
}
