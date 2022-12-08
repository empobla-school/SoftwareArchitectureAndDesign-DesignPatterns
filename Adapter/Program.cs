using Adapter.Classes;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            double magnitude = 11;
            double degrees = 105;
            double radians = degrees * Math.PI / 180;

            ThirdPartyLib vectorLibrary = new ThirdPartyLib();
            DegRadsAdapter adapter = new DegRadsAdapter(vectorLibrary);
            
            Vector resultFromLib = vectorLibrary.getVectorFromAngle(radians, magnitude);
            Vector resultFromAdapter = adapter.getVectorFromAngle(degrees, magnitude);

            Console.WriteLine(String.Format("Result from Third Party Library: {0}", resultFromLib));
            Console.WriteLine(String.Format("Result from Adapter: {0}", resultFromAdapter));
            Console.WriteLine(String.Format("Both results equal: {0}", Vector.isEqual(resultFromLib, resultFromAdapter)));
        }
    }
}