using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalProblem
{
    class PerfectNumber
    {
        internal void checkPerfectNumber(int n)
        {
            String Divisor="1";
            int sum = 1;
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    Divisor = Divisor+"+"+i.ToString();
                    sum += i;
                }
            }
            Console.WriteLine(sum);
            if (sum == n)
            {
                Console.WriteLine("{0} is perfect number",n);
                Console.WriteLine(Divisor);
            }
            else
            {
                Console.WriteLine("{0} is not perfect number", n);
                Console.WriteLine(Divisor);
            }
        }
    }
}
