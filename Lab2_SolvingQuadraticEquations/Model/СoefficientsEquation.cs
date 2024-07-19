namespace Lab2_SolvingQuadraticEquations.Equation
{
    public class СoefficientsEquation
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public СoefficientsEquation()
        {
            A = 0.0;
            B = 0.0;
            C = 0.0;
        }

        public СoefficientsEquation(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public СoefficientsEquation(СoefficientsEquation сoefficients)
        {
            A = сoefficients.A;
            B = сoefficients.B;
            C = сoefficients.C;
        }


    }
}
