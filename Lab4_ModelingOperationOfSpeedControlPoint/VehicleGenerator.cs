using ModelingOperationOfSpeedControlPoint.Enums;
using ModelingOperationOfSpeedControlPoint.Vehicles;

namespace ModelingOperationOfSpeedControlPoint
{
    public  class VehicleGenerator
    {
        private Random _random = new Random();
        
        public static AVehicle Generate()
        {
            var enumLength = Enum.GetNames(typeof(VehicleBodyType)).Length;
            var randomBodyType = (VehicleBodyType)new Random().Next(enumLength);

            if(randomBodyType == VehicleBodyType.CAR)
            {
                return new Car();
            }
            else if(randomBodyType == VehicleBodyType.BUS)
            {
                return new Bus();
            }
            else if (randomBodyType == VehicleBodyType.TRUCK)
            {
                return new Truck();
            }

            throw new ArgumentException(nameof(VehicleGenerator.Generate));
        }


    }
}
