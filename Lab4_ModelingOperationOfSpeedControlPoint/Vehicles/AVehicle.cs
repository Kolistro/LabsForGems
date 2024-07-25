using ModelingOperationOfSpeedControlPoint.Enums;

namespace ModelingOperationOfSpeedControlPoint.Vehicles
{
    public abstract class AVehicle
    {
        public VehicleColor Color { get; set; }
        public VehicleBodyType BodyType { get; set; }
        public int LicensePlateNumber { get; set; }
        public bool HasPassenger { get; set; }

        public void Build()
        {
            var enumVehicleColorLength = Enum.GetNames(typeof(VehicleColor)).Length;
            var randomVehicleColor = (VehicleColor) new Random().Next(enumVehicleColorLength);

            Color = randomVehicleColor;
            LicensePlateNumber = new Random().Next(100, 1000);
            HasPassenger = Convert.ToBoolean(new Random().Next(0, 2));
        }

        public abstract int GetSpeed();

        public override string ToString()
        {
            return $"{BodyType}:\t Цвет {Color}, Номер {LicensePlateNumber}, Наличие пассажира: {HasPassenger}";
        }

    }
}
