using System;
using System.Collections.Generic;
using System.Text;

namespace Persiapan_Xtremax
{
    class PrimeNumber
    {
        public void Print(int maxNumber)
        {
            for ( int i = 2; i <= maxNumber; i++)
            {
                if (i <= 2)
                {
                    Console.WriteLine(i);
                }
                else if (i <= 8)
                {
                    if (i%2 != 0)
                    {
                        Console.WriteLine(i);
                    }
                }
                else
                {
                    if (i%2 != 0 && i %3 != 0 && i%5 != 0 && i%7 != 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }
    }
}
