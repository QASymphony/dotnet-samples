using System;
using System.Collections.Generic;
using System.Text;

namespace MSTestSample.UnitTest
{
    class Arithmetic
    {
        public decimal Addition(int x, int y)
        {
            return x + y;
        }

        public decimal Subtraction(int x, int y)
        {
            return x - y;
        }

        public decimal Multiplication(int x, int y)
        {
            return x * y;
        }

        public decimal Division(int x, int y)
        {
            return x / y;
        }
    }
}
