using Lab2_SolvingQuadraticEquations.Equation;
using Lab2_SolvingQuadraticEquations.Reader;
using Lab2_SolvingQuadraticEquations.Writer;

var exitProgram = "";
do
{
    Console.WriteLine("Вы находитесь в программе для решения квадратных уравнений");
    
    IReader reader = new ConsoleReader();
    СoefficientsEquation coefficients = reader.Read();

    QuadraticEquation quadraticEquation = new(coefficients);
    quadraticEquation.Solve();

    IWriter writer = new ConsoleWriter();
    writer.Write(quadraticEquation.SolutionQuadraticEquation);

    Console.WriteLine("Для выхода из программы введите слово \"exit\"");
    exitProgram = Console.ReadLine();
} while (exitProgram != "exit");
