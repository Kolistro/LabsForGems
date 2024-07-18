namespace Lab2_SolvingQuadraticEquations.Equation
{
    internal class LinearEquation : IEquation
    {
        public СoefficientsEquation Coefficients { get; set; }
        public SolutionEquation SolutionLinearEquation { get; set; }
        public LinearEquation(СoefficientsEquation coefficients)
        {
            Coefficients = coefficients;
            SolutionLinearEquation = new SolutionEquation();
        }
        public void Solve()
        {
            if (Coefficients.B == 0 && Coefficients.C == 0)
            {
                SolutionLinearEquation.NumberSolutions = -1;
                return;
            }

            if (Coefficients.B == 0)
            {
                SolutionLinearEquation.NumberSolutions = 0;
                return;
            }

            SolutionLinearEquation.NumberSolutions = 1;
            SolutionLinearEquation.X1 = -Coefficients.C / Coefficients.B;
            SolutionLinearEquation.X2 = SolutionLinearEquation.X1;
        }
    }
}
