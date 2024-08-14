using ModelingOperationOfSpeedControlPoint.Enums;

namespace ModelingOperationOfSpeedControlPoint.Vehicles
{
    public class Truck : AVehicle
    {
        public Truck() 
        {
            BodyType = VehicleBodyType.TRUCK;
            Build();
        }
        public override int GetSpeed() => new Random().Next(70, 101);

    }
}
