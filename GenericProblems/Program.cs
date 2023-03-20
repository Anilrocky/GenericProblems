using System;
namespace GenericProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            MaximumOfThree maximum = new MaximumOfThree();
            maximum.FindMax<int>(14, 56, 67);
            maximum.FindMax<double>(13.8, 1.5, 12.6);
            maximum.FindMax<string>("Apple", "Peach", "Banana");
        }
    }
}