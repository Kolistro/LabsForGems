using ModelingOperationOfSpeedControlPoint.Enums;
using ModelingOperationOfSpeedControlPoint.Vehicles;
using ModelingOperationOfSpeedControlPoint.Writer;

namespace ModelingOperationOfSpeedControlPoint.CheckPoints
{
    public class CheckPoint
    {
        private CheckPointStatics _static;
        private List<int> _stolenNumbers;
        private int _highSpeed = 110;

        public CheckPoint()
        {
            Random random = new Random();
            int countStolenNumbers = 10;
            _stolenNumbers = new List<int>();

            _static = new CheckPointStatics();
            for (int i = 0; i < countStolenNumbers; i++)
            {
                _stolenNumbers.Add(random.Next(100, 1000));
            }
        }

        public CheckPointStatics GetStatics()
        {
            return _static;
        }

        public void RegisterVehicle(AVehicle vehicle)
        {
            int speed = vehicle.GetSpeed();

            СountQuantityByVehicleBodyType(vehicle.BodyType);
            RecordSpeeding(speed);
            InterceptStolenVehicles(vehicle.LicensePlateNumber);          
            _static.AverageSpeed = GetAverageSpeed(speed);

        }

        private void СountQuantityByVehicleBodyType(VehicleBodyType vehicleType)
        {
            if (vehicleType == VehicleBodyType.CAR)
                _static.CarsCount++;
            else if (vehicleType == VehicleBodyType.BUS)
                _static.BusesCount++;
            else if (vehicleType == VehicleBodyType.TRUCK)
                _static.TruckCount++;
        }

        private void RecordSpeeding(int speed)
        {
            IWriter writer = new WriterConsole();
            writer.Write($"Скорость: {speed}");

            if (speed > _highSpeed)
            {
                _static.SpeedLimitBreakersCount++;
                writer.WriteAboutViolation("Превышение скорости!");    
            }
        }

        private void InterceptStolenVehicles(int licensePlateNumber)
        {
            if (IsNumberStolen(licensePlateNumber))
            {
                _static.CarJackersCount++;
                IWriter writer = new WriterConsole();
                writer.WriteAboutViolation("Перехват!");
            }
        }

        private bool IsNumberStolen(int licensePlateNumber)
        {
            foreach (int number in _stolenNumbers)
            {
                if(licensePlateNumber == number)
                {
                    return true;
                }
            }
            return false;
        }

        private double GetAverageSpeed(int speed)
        {
            int countVehicle = GetCountVehicle();
            double averageSpeed = ((_static.AverageSpeed * (countVehicle-1)) + speed)/(countVehicle);
            return Math.Round(averageSpeed);
        }

        private int GetCountVehicle()
        {
            return _static.CarsCount + _static.BusesCount + _static.TruckCount;
        }
    }
}
