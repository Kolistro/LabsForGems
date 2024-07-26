using Lab2_SolvingQuadraticEquations.Equation;
using Lab2_SolvingQuadraticEquations.Writer;

namespace SolvingQuadraticEquations.Implementation
{
    internal class WriterFile : IWriter
    {
        public void Write(SolutionEquation solutionEquation)
        {
            string filePath = "OutputData\\output.txt";
            if (!File.Exists(filePath))
            {
                throw new IOException("Файл для записи не существует!");
            }
            File.WriteAllText(filePath, solutionEquation.ToString());

        }
    }
}
