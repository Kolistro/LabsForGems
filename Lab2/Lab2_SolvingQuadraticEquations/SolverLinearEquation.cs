using Lab2_SolvingQuadraticEquations.Equation;

namespace SolvingQuadraticEquations
{
    public static class SolverLinearEquation 
    {

        public static SolutionEquation Solve(LinearEquation equation)
        {
            if (equation.A == 0 && equation.B== 0)
            {
                equation.SolutionLinearEquation.NumberSolutions = -1;
                return equation.SolutionLinearEquation;
            }

            if (equation.A == 0)
            {
                equation.SolutionLinearEquation.NumberSolutions = 0;
                return equation.SolutionLinearEquation;
            }

            equation.SolutionLinearEquation.NumberSolutions = 1;
            equation.SolutionLinearEquation.X1 = -equation.B / equation.A;
            equation.SolutionLinearEquation.X2 = equation.SolutionLinearEquation.X1;
            return equation.SolutionLinearEquation;
        }
    }
}
