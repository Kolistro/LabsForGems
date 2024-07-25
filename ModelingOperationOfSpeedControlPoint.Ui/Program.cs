using ModelingOperationOfSpeedControlPoint;
using ModelingOperationOfSpeedControlPoint.CheckPoints;
using ModelingOperationOfSpeedControlPoint.Vehicles;
using ModelingOperationOfSpeedControlPoint.Writer;

Console.WriteLine("Запущена работа автоматизированного пункта контроля скорости дорожного движения.\n");
CheckPoint checkPoint = new CheckPoint();
IWriter writerConsole = new WriterConsole();

do
{
    AVehicle vehicle = VehicleGenerator.Generate();
    writerConsole.Write(vehicle.ToString());
    checkPoint.RegisterVehicle(vehicle);

    int timeBetweenVehicle = new Random().Next(500, 5001);
    System.Threading.Thread.Sleep(timeBetweenVehicle);
} while (!Console.KeyAvailable);

writerConsole.Write(checkPoint.GetStatics().ToString());