using ModelingOperationOfSpeedControlPoint.CheckPoints;
using ModelingOperationOfSpeedControlPoint.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelingOperationOfSpeedControlPoint.Writer
{
    public class WriterConsole : IWriter
    {
        public void Write(AVehicle vehicle)
        {
            Console.WriteLine(vehicle.ToString());
        }

        public void Write(CheckPointStatics checkPointStatics)
        {
            Console.WriteLine(checkPointStatics.ToString());
        }

        public void WriteAboutViolation(string violation)
        {
            Console.WriteLine("\n--------------------------------");
            Console.WriteLine(violation);
            Console.WriteLine("--------------------------------\n");
        }
    }
}
