using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Symmetry
{
    public class SymmetryCalc
    {
        private readonly int _int;
        private int[] _array;
        private int[] _reversedArray;

        public SymmetryCalc(int integer)
        {
            _int = integer;
        }

        public void ConvertToArray()
        {
            _array = _int.ToString().ToCharArray().Select(x =>
            (int)Char.GetNumericValue(x)).ToArray();
        }

        public void ReverseArray()
        {
            _reversedArray = _array.Reverse().ToArray();
        }

        public void IsSymmetrical()
        {
            if (Enumerable.SequenceEqual(_array, _reversedArray)) Console.WriteLine("Symmetrical");
            else Console.WriteLine("Nonsymmetrical");
        }
    }
}

