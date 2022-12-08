namespace Adapter.Classes
{
    class Vector
    {
        public double x { get; set; }
        public double y { get; set; }

        public Vector(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public static bool isEqual(Vector A, Vector B)
        {
            return A.x == B.x && A.y == B.y;
        }

        public override string ToString()
        {
            return String.Format("[ {0} {1} ]", this.x, this.y);
        }
    }
}