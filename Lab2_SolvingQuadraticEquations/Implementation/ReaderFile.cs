using Lab2_SolvingQuadraticEquations.Equation;
using SolvingQuadraticEquations.Interfaces;

namespace SolvingQuadraticEquations.Implementation
{
    internal class ReaderFile : IReader
    {
        public СoefficientsEquation Read() 
        {
            string filePath = "InputData\\input.txt";
            if (!File.Exists(filePath))
            {
                throw new IOException("Файл для чтения не существует!");
            }

            string fileContent = File.ReadAllText(filePath);

            string[] coefficientsString = fileContent.Split(" ");
            double[] coefficientsDouble = new double[3];

            if (coefficientsString.Length != coefficientsDouble.Length)
                throw new ArgumentException("Количество коэффициентов должно быть равно 3", nameof(coefficientsString));

            for (int i = 0; i < coefficientsString.Length; i++)
            {
                if (!double.TryParse(coefficientsString[i], out coefficientsDouble[i]))
                    throw new ArgumentException("Полученое значение не удалось преобразовать в double[]", nameof(coefficientsString));
            }

            СoefficientsEquation сoefficients = 
                new СoefficientsEquation(coefficientsDouble[0], coefficientsDouble[1], coefficientsDouble[2]);
            return сoefficients;
        }
    }
}
