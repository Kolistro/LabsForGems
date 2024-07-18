using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab2_SolvingQuadraticEquations.Equation;

namespace Lab2_SolvingQuadraticEquations.Writer
{
    internal interface IWriter
    {
        public void Write(SolutionEquation solutionEquation);
    }
}
