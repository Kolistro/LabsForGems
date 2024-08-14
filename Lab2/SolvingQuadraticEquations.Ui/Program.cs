using Lab2_SolvingQuadraticEquations.Writer;
using SolvingQuadraticEquations.Interfaces;
using SolvingQuadraticEquations.Ui;

IReader reader;
IWriter writer;
do
{
    UiManager.SolveQuadraticEquations(out reader, out writer);
    Console.WriteLine("Для выхода из программы введите слово \"exit\"");  
} while (Console.ReadLine() != "exit");
