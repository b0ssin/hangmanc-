using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mortgagePmt
{
    class Program
    {
        static void Main(string[] args)
        {
            //get interest rate
            Console.WriteLine("Enter your interest rate");
            double interestRate = Convert.ToDouble(Console.ReadLine());
            //get principal
            Console.WriteLine("Enter your principal");
            double principal = Convert.ToDouble(Console.ReadLine());
            //get fixed year
            Console.WriteLine("Enter your fixed year amount(15-20-30");
            double year = Convert.ToDouble(Console.ReadLine());

            // monthly payments = P[r(1+r)^N] / [(1+r)^N - 1]
            double p = principal;
            double r = interestRate / 12;
            // ensures it's a monthly interest rate not yearly
            double n = year * 12;
            double exp = Math.Pow(1 + r, n);
            double monthlyPmt = p * ((r * exp) / (exp - 1));
            Console.WriteLine(p + "  the principal");
            Console.WriteLine(r + " is the interestRate");
            Console.WriteLine(n + " is the total of months");
            Console.WriteLine(monthlyPmt);
            Console.ReadKey();
        }
    }
}
