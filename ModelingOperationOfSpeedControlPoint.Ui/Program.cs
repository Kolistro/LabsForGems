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


    System.Threading.Thread.Sleep(10);
} while (!Console.KeyAvailable);

writerConsole.Write(checkPoint.GetStatics().ToString());