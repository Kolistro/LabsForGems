using Lab2_SolvingQuadraticEquations.Equation;
using Lab2_SolvingQuadraticEquations.Writer;
using SolvingQuadraticEquations.Factory;
using SolvingQuadraticEquations.Interfaces;

namespace SolvingQuadraticEquations.Ui
{
    internal static class UiManager
    {
        public static void SolveQuadraticEquations(out IReader reader, out IWriter writer)
        {
            Console.WriteLine("Вы находитесь в программе для решения квадратных уравнений");
           
            reader = UiManager.InitializeReader();
            writer = UiManager.InitializeWriter();
            try
            {
                СoefficientsEquation coefficients = reader.Read();
                QuadraticEquation quadraticEquation = new(coefficients);
                SolverQuadraticEquationcs.Solve(quadraticEquation);
                writer.Write(quadraticEquation.SolutionQuadraticEquation);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }     
        }

        public static IReader InitializeReader() {
            var valueParsed = 0;
            ReaderType type;
            Console.WriteLine("Выберите способ ввода коэффициентов (введите только число): ");
            Console.WriteLine("1. С консоли");
            Console.WriteLine("2. С файла");
            Console.WriteLine("По умолчанию включён режим ввода с консоли\n");
           
            while (!int.TryParse(Console.ReadLine(), out valueParsed))
                Console.WriteLine("Проверьте ввод, ожидается число\n");
            
            switch (valueParsed)
            {
                case 1: 
                    type = ReaderType.Console;
                    break;
                case 2:
                    type = ReaderType.File;
                    break;
                default:
                    type = ReaderType.Console;
                    break;
            }

            return ReaderFactory.Create(type);
        }

        public static IWriter InitializeWriter()
        {
            var valueParsed = 0;
            WriterType type;
            Console.WriteLine("Выберите способ вывода ответа (введите только число): ");
            Console.WriteLine("1. На консоль");
            Console.WriteLine("2. В файл");
            Console.WriteLine("По умолчанию включён режим вывода на консоль\n");
            while (!int.TryParse(Console.ReadLine(), out valueParsed))
                Console.WriteLine("Проверьте ввод, ожидается число\n");
            switch (valueParsed)
            {
                case 1:
                    type = WriterType.Console;
                    break;
                case 2:
                    type = WriterType.File;
                    break;
                default:
                    type = WriterType.Console;
                    break;
            }
            return WriterFactory.Create(type);
        }
       
    }
}
