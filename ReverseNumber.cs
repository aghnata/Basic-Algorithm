using System;
using System.Collections.Generic;
using System.Text;

namespace Persiapan_Xtremax
{
    class ReverseNumber
    {
        public void Result(int number)
        {
            int res = 0;
            while (number > 0)
            {
                var remainder = number % 10;
                res = (res * 10) + remainder;
                number /= 10;
            }
            Console.WriteLine(res);
        }
    }
}
