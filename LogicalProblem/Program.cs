using System;

namespace LogicalProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Fibonacci fi = new Fibonacci();
            Console.WriteLine("Enter number till fibonacci number series");
            int n = Convert.ToInt32(Console.ReadLine());
            fi.fibonacciSeries(n);
        }
    }
}
