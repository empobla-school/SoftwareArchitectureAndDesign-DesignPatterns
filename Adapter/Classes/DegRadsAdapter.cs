namespace Adapter.Classes
{
    class DegRadsAdapter
    {
        ThirdPartyLib vectorLibrary;

        public DegRadsAdapter(ThirdPartyLib vectorLibrary)
        {
            this.vectorLibrary = vectorLibrary;
        }

        public Vector getVectorFromAngle(double angle, double magnitude)
        {
            // Angle in degrees
            double angleInRads = angle * Math.PI / 180;
            Vector vector = vectorLibrary.getVectorFromAngle(angleInRads, magnitude);
            
            return vector;
        }
    }
}