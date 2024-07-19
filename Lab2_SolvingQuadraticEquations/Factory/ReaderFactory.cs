using Lab2_SolvingQuadraticEquations.Reader;
using SolvingQuadraticEquations.Implementation;
using SolvingQuadraticEquations.Interfaces;

namespace SolvingQuadraticEquations.Factory
{
    public static class ReaderFactory
    {
        public static IReader Create(ReaderType type)
        {
            if (type == ReaderType.Console)
                return new ReaderConsole();
            if (type == ReaderType.File)
                return new ReaderFile();
            throw new ArgumentException("Неверный тип считывания данных", nameof(type));
        }
        
    }
}
