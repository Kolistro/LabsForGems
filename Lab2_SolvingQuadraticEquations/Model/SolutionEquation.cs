namespace Lab2_SolvingQuadraticEquations.Equation
{
    public class SolutionEquation
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

        public override string ToString()
        {
            string solutionStr;
            switch (NumberSolutions)
            {
                case -1:
                    solutionStr = "Действительных корней бесконечно много.";
                    break;

                case 0:
                    solutionStr = "Действительных корней нет.";
                    break;

                case 1:
                    solutionStr = "Действительный корень один.";
                    solutionStr += $"\nx1 = x2 = {X1}";
                    break;

                case 2:
                    solutionStr = "Действительных корней два."; ;
                    solutionStr += $"\nx1 = {X1}";
                    solutionStr += $"\nx2 = {X2}";
                    break;
                default:
                    solutionStr = "Ошибка";
                    break;
            }
            return solutionStr;
        }
    }
}
