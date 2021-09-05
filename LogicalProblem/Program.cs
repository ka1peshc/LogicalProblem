using System;

namespace LogicalProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Fibonacci fi = new Fibonacci();
            Console.WriteLine("Enter number till fibonacci number series");
            int n = Convert.ToInt32(Console.ReadLine());
            fi.fibonacciSeries(n);
            */
            PerfectNumber pf = new PerfectNumber();
            Console.WriteLine("Enter number to check if it is Perfect number");
            int num = Convert.ToInt32(Console.ReadLine());
            pf.checkPerfectNumber(num);
        }
    }
}
