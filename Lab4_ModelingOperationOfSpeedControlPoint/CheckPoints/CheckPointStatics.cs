namespace ModelingOperationOfSpeedControlPoint.CheckPoints
{
    public class CheckPointStatics
    {
        public int CarsCount { get; set; }
        public int TruckCount { get; set; }
        public int BusesCount { get; set; }
        public int SpeedLimitBreakersCount { get; set; }
        public int CarJackersCount { get; set; }
        public int AverageSpeed { get; set; }

        public override string ToString()
        {
            string str = "\n";
            str += $"Количество легковых автомобилей: {CarsCount}\n";
            str += $"Количество грузовых автомобилей: {TruckCount}\n";
            str += $"Количество автобусов: {BusesCount}\n";
            str += $"Количество транспортных средств превысивших скорость: {SpeedLimitBreakersCount}\n";
            str += $"Количество угнанных транспортных средств: {CarJackersCount}\n";
            str += $"Средняя скорость всех транспортных средств: {AverageSpeed}\n";
            return str;
        }
    }
}
