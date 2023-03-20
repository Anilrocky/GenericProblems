using System;
namespace GenericProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            MaximumOfThree maximum = new MaximumOfThree();
            maximum.FindMaxIntNumber(10, 30, 15);
            maximum.FindMaxFloatNumber(1.6, 3.9, 6.5);
            maximum.FindMaxOfString("Apple", "Banana", "Mango");
        }
    }
}