using Lab2_SolvingQuadraticEquations.Equation;
using SolvingQuadraticEquations.Interfaces;

namespace Lab2_SolvingQuadraticEquations.Reader
{
    internal class ReaderConsole : IReader
    {
        public СoefficientsEquation Read()
        {
            Console.WriteLine("Квадратное уравнение вида: ax*x + bx + c = 0.");

            double a;
            double b;
            double c;

            Console.WriteLine("Введите коэффициент a: ");
            while (!double.TryParse(Console.ReadLine(), out a))
                Console.WriteLine("Проверьте ввод, ожидается число");

            Console.WriteLine("Введите коэффициент b: ");
            while (!double.TryParse(Console.ReadLine(), out b))
                Console.WriteLine("Проверьте ввод, ожидается число");

            Console.WriteLine("Введите коэффициент c: ");
            while (!double.TryParse(Console.ReadLine(), out c))
                Console.WriteLine("Проверьте ввод, ожидается число");

            СoefficientsEquation сoefficients = new(a, b, c);
            //Console.WriteLine($"{сoefficients.ToString}");
            return сoefficients;
        }
    }
}
