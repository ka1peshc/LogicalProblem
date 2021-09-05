using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalProblem
{
    class PrimeNumber
    {
        internal void checkPrimeNumber(int num)
        {
            int check = 0;
            for(int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    check = 1;
                    break;
                }
            }
            if (check == 1)
            {
                Console.WriteLine(num + " is not a prime number");
            }
            else
            {
                Console.WriteLine(num + " is a prime number");
            }
        }
    }
}
