namespace Lab2_SolvingQuadraticEquations.Equation
{
    public class QuadraticEquation
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
        public double Discriminant()
        {
            return Coefficients.B * Coefficients.B - 4 * Coefficients.A * Coefficients.C;

        }

        public override string ToString()
        {
            return $"Уравнение: {Coefficients.A}x*x + {Coefficients.B}x + {Coefficients.C} = 0";
        }
    }
}
