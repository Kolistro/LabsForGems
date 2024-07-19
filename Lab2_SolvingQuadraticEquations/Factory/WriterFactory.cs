using Lab2_SolvingQuadraticEquations.Writer;
using SolvingQuadraticEquations.Implementation;
using SolvingQuadraticEquations.Reader;

namespace SolvingQuadraticEquations.Factory
{
    public static class WriterFactory
    {
        public static IWriter Create(WriterType type)
        {
            if (type == WriterType.Console)
                return new WriterConsole();
            if (type == WriterType.File)
                return new WriterFile();
            throw new ArgumentException(nameof(type));
        }
    }
}
