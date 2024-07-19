namespace Lab2_SolvingQuadraticEquations.Equation
{
    public class LinearEquation
    {
        public double A {  get; set; }
        public double B { get; set; }
        public SolutionEquation SolutionLinearEquation { get; set; }

        public LinearEquation(double a, double b)
        {
            A = a;
            B = b;
            SolutionEquation solutionEquation = new SolutionEquation();
        }
        public LinearEquation(СoefficientsEquation coefficients)
        {
            if(coefficients.A != 0.0)
            {
                throw new ArgumentException(nameof(coefficients));
            }
            A = coefficients.B;
            B = coefficients.C;
            SolutionLinearEquation = new SolutionEquation();
        }

        public override string ToString()
        {
            return $"Уравнение: {A}x + {B} = 0";
        }

    }
}
