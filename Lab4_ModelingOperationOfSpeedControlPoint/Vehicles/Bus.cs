using ModelingOperationOfSpeedControlPoint.Enums;
using System.Drawing;

namespace ModelingOperationOfSpeedControlPoint.Vehicles
{
    public class Bus : AVehicle
    {
        public Bus() {          
            BodyType = VehicleBodyType.BUS;
            Build();   
        }
        public override int GetSpeed() => new Random().Next(80, 111);
    }
}
