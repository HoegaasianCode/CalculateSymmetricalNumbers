using System;
using System.Linq;

namespace Symmetry
{
    class Program
    {
        // https://edabit.com/challenge/H77JNgLtEnQcX5hcu
        // SOLVED

        static void Main(string[] args)
        {
            SymmetryCalc symmetry = new SymmetryCalc(14441);
            symmetry.ConvertToArray();
            symmetry.ReverseArray();
            symmetry.IsSymmetrical();
        }
    }
}
