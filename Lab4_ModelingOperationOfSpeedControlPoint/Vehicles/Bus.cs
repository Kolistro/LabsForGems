using ModelingOperationOfSpeedControlPoint.Enums;

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
