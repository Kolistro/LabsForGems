using ModelingOperationOfSpeedControlPoint.CheckPoints;
using ModelingOperationOfSpeedControlPoint.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelingOperationOfSpeedControlPoint.Writer
{
    public interface IWriter
    {
        public void Write(AVehicle vehicle);
        public void Write(CheckPointStatics checkPointStatics);
        public void WriteAboutViolation(string violation);
    }
}
