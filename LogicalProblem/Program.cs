using System;

namespace LogicalProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            Fibonacci fi = new Fibonacci();
            Console.WriteLine("Enter number till fibonacci number series");
            int n = Convert.ToInt32(Console.ReadLine());
            fi.fibonacciSeries(n);
            
            PerfectNumber pf = new PerfectNumber();
            Console.WriteLine("Enter number to check if it is Perfect number");
            int num = Convert.ToInt32(Console.ReadLine());
            pf.checkPerfectNumber(num);
            

            PrimeNumber pn = new PrimeNumber();
            Console.WriteLine("Enter number to check if it is Prime number");
            int numPrime= Convert.ToInt32(Console.ReadLine());
            pn.checkPrimeNumber(numPrime);
            
            Console.WriteLine("Enter number to reverse it");
            int numRev = Convert.ToInt32(Console.ReadLine());
            ReverseNumber rn = new ReverseNumber();
            rn.doReverseNumber(numRev);
            
            Console.WriteLine("Enter number to genrate n coupon");
            int numGC = Convert.ToInt32(Console.ReadLine());
            CouponGenrator cg = new CouponGenrator();
            cg.genrateCoupon(numGC);
            watch.Stop();
            var time = watch.ElapsedMilliseconds;
            Console.WriteLine("Time taken to execute above 5 program is {0} ms",time);

        }
    }
}
