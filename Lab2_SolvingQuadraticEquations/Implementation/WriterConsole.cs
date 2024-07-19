using Lab2_SolvingQuadraticEquations.Equation;
using Lab2_SolvingQuadraticEquations.Writer;

namespace SolvingQuadraticEquations.Reader
{
    internal class WriterConsole : IWriter
    {
        public void Write(SolutionEquation solutionEquation)
        {
            Console.WriteLine(solutionEquation.ToString());
        }
    }
}
