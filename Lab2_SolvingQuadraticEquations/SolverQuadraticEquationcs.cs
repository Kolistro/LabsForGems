using Lab2_SolvingQuadraticEquations.Equation;

namespace SolvingQuadraticEquations
{
    public static class SolverQuadraticEquationcs 
    {
        public static SolutionEquation Solve(QuadraticEquation equation)
        {
            if (equation.Coefficients.A == 0)
            {
                LinearEquation linearEquation = new(equation.Coefficients);
                SolverLinearEquation.Solve(linearEquation);
                equation.SolutionQuadraticEquation = linearEquation.SolutionLinearEquation;
                return equation.SolutionQuadraticEquation;
            }

            double discriminant = equation.Discriminant();
            if (discriminant < 0)
            {
                equation.SolutionQuadraticEquation.NumberSolutions = 0;
            }
            else if (discriminant == 0)
            {
                equation.SolutionQuadraticEquation.NumberSolutions = 1;
                equation.SolutionQuadraticEquation.X1 = -equation.Coefficients.B / (2 * equation.Coefficients.A);
                equation.SolutionQuadraticEquation.X2 = equation.SolutionQuadraticEquation.X1;
            }
            else
            {
                double sqrtDiscriminant = Math.Sqrt(discriminant);
                equation.SolutionQuadraticEquation.NumberSolutions = 2;
                equation.SolutionQuadraticEquation.X1 = (-equation.Coefficients.B + sqrtDiscriminant) / (2 * equation.Coefficients.A);
                equation.SolutionQuadraticEquation.X2 = (-equation.Coefficients.B - sqrtDiscriminant) / (2 * equation.Coefficients.A);
            }
            return equation.SolutionQuadraticEquation;

        }
        

    }
}
