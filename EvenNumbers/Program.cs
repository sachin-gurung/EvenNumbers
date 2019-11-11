using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 20; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine("Even numbers are {0}", i);
            }
        }
    }
}
/*
Even numbers are 0
Even numbers are 2
Even numbers are 4
Even numbers are 6
Even numbers are 8
Even numbers are 10
Even numbers are 12
Even numbers are 14
Even numbers are 16
Even numbers are 18
Press any key to continue . . .
*/
