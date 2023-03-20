using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericProblems
{
    public class MaximumOfThree
    {
        public void FindMaxIntNumber(int a,int b,int c)
        {           
            if (a > b && a > c)
                Console.WriteLine("a is maximum");
            if (b > a && b > c)
                Console.WriteLine("b is maximum");
            else
                Console.WriteLine("c is maximum");
        }
        public void FindMaxFloatNumber(double a, double b, double c)
        {
            if (a > b && a > c)
                Console.WriteLine("a is maximum");
            if (b > a && b > c)
                Console.WriteLine("b is maximum");
            else
                Console.WriteLine("c is maximum");
        }
        public void FindMaxOfString(string a, string b, string c)
        {
            if (a.CompareTo(b) > 0 && a.CompareTo(c) > 0)
                Console.WriteLine("a is maximum");
            if (b.CompareTo(a) > 0 && b.CompareTo(c) > 0)
                Console.WriteLine("b is maximum");
            else
                Console.WriteLine("c is maximum");
        }
    }
}
