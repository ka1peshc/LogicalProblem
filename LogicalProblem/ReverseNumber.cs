using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalProblem
{
    class ReverseNumber
    {
        internal void doReverseNumber(int num)
        {
            int rem;
            int reverse = 0;
            while(num != 0)
            {
                rem = num % 10;
                reverse = (reverse * 10) + rem;
                num = num / 10;
            }
            Console.WriteLine("Reverse number is {0}", reverse);
        }
    }
}
