using MyUnit;
using SystemArithmetic.Tests;

internal class Program
{
    private static void Main(string[] args)
    {
        var targetType = typeof(ArithmeticTest);
        try
        {
            MyTestRunner.RunForType(targetType, Console.WriteLine);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());   
        }
        
    }
}