namespace Lab2_SolvingQuadraticEquations.Equation
{
    internal class SolutionEquation
    {
        /* 
        * поле NumberSolutions будет отвечать за кол-во корней в уравнении.
        * 0 - действительных корней нет
        * 1 - один действительный корень (x1=x2)
        * 2 - два действительных корня
        * -1 - бесконечное число действительных корней
        */
        public int NumberSolutions { get; set; }
        public double X1 { get; set; }
        public double X2 { get; set; }


        public SolutionEquation()
        {
            NumberSolutions = 0;
        }

        public SolutionEquation(double x1, double x2, int numberSolutions)
        {
            X1 = x1;
            X2 = x2;
            NumberSolutions = numberSolutions;
        }
    }
}
