using MyUnit;
using SystemArithmetic.Tests;

internal class Program
{
    private static void Main(string[] args)
    {
        var targetType = typeof(ArithmeticTest);

        MyTestRunner.RunForType(targetType, Console.WriteLine);
    }
}