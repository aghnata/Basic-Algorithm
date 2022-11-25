using System;
using System.Collections.Generic;
using System.Text;

namespace Persiapan_Xtremax
{
    class Factorial
    {
        public int Result(int number)
        {
            if (number == 1) return 1;

            return Result(number - 1) * number;
        }
    }
}
