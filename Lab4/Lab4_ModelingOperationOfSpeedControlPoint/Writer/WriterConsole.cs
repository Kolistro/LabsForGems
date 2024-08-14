using ModelingOperationOfSpeedControlPoint.CheckPoints;
using ModelingOperationOfSpeedControlPoint.Vehicles;

namespace ModelingOperationOfSpeedControlPoint.Writer
{
    public class WriterConsole : IWriter
    {
        public void Write(string str)
        {
            Console.WriteLine(str);
        }


        public void WriteAboutViolation(string violation)
        {
            Console.WriteLine("\n--------------------------------");
            Console.WriteLine(violation);
            Console.WriteLine("--------------------------------\n");
        }
    }
}
