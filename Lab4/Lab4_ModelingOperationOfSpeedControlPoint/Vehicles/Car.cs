using ModelingOperationOfSpeedControlPoint.Enums;

namespace ModelingOperationOfSpeedControlPoint.Vehicles
{
    public class Car : AVehicle
    {
        public Car() 
        {
            BodyType = VehicleBodyType.CAR;
            Build();
        }
        public override int GetSpeed() => new Random().Next(90, 151);
    }
}
