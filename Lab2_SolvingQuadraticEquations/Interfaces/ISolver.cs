using Lab2_SolvingQuadraticEquations.Equation;

namespace SolvingQuadraticEquations.Interfaces
{
    internal interface ISolver
    {
        public SolutionEquation Solve(IEquation equation);
    }
}
