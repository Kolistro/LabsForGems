using System;
using Lab2_SolvingQuadraticEquations.Equation;


namespace Lab2_SolvingQuadraticEquations.Writer
{
    internal class ConsoleWriter : IWriter
    {
        public void Write(SolutionEquation solutionEquation)
        {
            switch (solutionEquation.NumberSolutions)
            {
                case -1:
                    Console.WriteLine("Действительных корней бесконечно много.");
                    break;

                case 0:
                    Console.WriteLine("Действительных корней нет.");
                    break;

                case 1:
                    Console.WriteLine("Действительный корень один.");
                    Console.WriteLine($"x1 = x2 = {solutionEquation.X1}");
                    break;

                case 2:
                    Console.WriteLine("Действительных корней два.");
                    Console.WriteLine($"x1 = {solutionEquation.X1}");
                    Console.WriteLine($"x2 = {solutionEquation.X2}");
                    break;
            }

        }
    }
}
