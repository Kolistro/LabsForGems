namespace Lab2_SolvingQuadraticEquations.Equation
{
    internal class QuadraticEquation : IEquation
    {
        public СoefficientsEquation Coefficients { get; set; }
        public SolutionEquation SolutionQuadraticEquation { get; set; }

        public QuadraticEquation(double A, double B)
        {
            Coefficients = new СoefficientsEquation(0.0, A, B);
            SolutionQuadraticEquation = new SolutionEquation();
        }

        public QuadraticEquation(СoefficientsEquation сoefficients)
        {
            Coefficients = new СoefficientsEquation(сoefficients);
            SolutionQuadraticEquation = new SolutionEquation();

        }

        public void Solve()
        {
            if (Coefficients.A == 0)
            {
                LinearEquation linearEquation = new(Coefficients);
                linearEquation.Solve();
                SolutionQuadraticEquation = linearEquation.SolutionLinearEquation;
                return;
            }

            double discriminant = Discriminant();
            if (discriminant < 0)
            {
                SolutionQuadraticEquation.NumberSolutions = 0;
            }
            else if (discriminant == 0)
            {
                SolutionQuadraticEquation.NumberSolutions = 1;
                SolutionQuadraticEquation.X1 = -Coefficients.B / (2 * Coefficients.A);
                SolutionQuadraticEquation.X2 = SolutionQuadraticEquation.X1;
            }
            else
            {
                double sqrtDiscriminant = Math.Sqrt(discriminant);
                SolutionQuadraticEquation.NumberSolutions = 2;
                SolutionQuadraticEquation.X1 = (-Coefficients.B + sqrtDiscriminant) / (2 * Coefficients.A);
                SolutionQuadraticEquation.X2 = (-Coefficients.B - sqrtDiscriminant) / (2 * Coefficients.A);
            }

        }

        private double Discriminant()
        {
            return Coefficients.B * Coefficients.B - 4 * Coefficients.A * Coefficients.C;

        }
    }
}
