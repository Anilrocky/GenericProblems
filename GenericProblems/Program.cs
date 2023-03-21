using System;
namespace GenericProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            MaximumOfThree<int> maximum1 = new MaximumOfThree<int>(13,45,23);
            maximum1.FindMax();
            MaximumOfThree<double> maximum2 = new MaximumOfThree<double>(6.7, 1.6, 3.6);
            maximum2.FindMax();
            MaximumOfThree<string> maximum3 = new MaximumOfThree<string>("Car","Bike","Flight");
            maximum3.FindMax();
            //maximum.FindMax<int>(12, 34, 55);
            //maximum.FindMax<double>(1.4, 5.4, 2.3);
            //maximum.FindMax<string>("Apple", "Peach", "Banana");
        }
    }
}