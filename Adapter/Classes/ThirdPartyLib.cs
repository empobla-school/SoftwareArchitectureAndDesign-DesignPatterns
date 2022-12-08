namespace Adapter.Classes
{
    class ThirdPartyLib
    {
        public Vector getVectorFromAngle(double angle, double magnitude)
        {
            // Angle is in radians
            double xComponent = magnitude * Math.Cos(angle);
            double yComponent = magnitude * Math.Sin(angle);

            Vector vector = new Vector(xComponent, yComponent);
            return vector;
        }
    }
}