using System;

namespace NewDelegates
{
    public delegate int NewDelegate(int firstNumber, int secondNumber, int thirdNumber);
    class Program
    {
        static void Main(string[] args)
        {
            var newDelegate = new NewDelegate(SumOfNumbers);
            Console.WriteLine(newDelegate.Invoke(5, 5, 5));
        }

        public static int SumOfNumbers(int firstNumber, int secondNumber, int thirdNumber)
        {
            return (firstNumber + secondNumber + thirdNumber);
        }
    }
}
