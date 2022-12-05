using System;

namespace BasicDelegates
{
    public delegate void PrintDelegate();
    
    class Program
    {
        public static void PrintInfo()
        {
            Console.WriteLine("PIT Solutions, Technopark, Trivandrum");

        }
        static void Main(string[] args)
        {
            var printDel = new PrintDelegate(PrintInfo);
            printDel();
        }
    }
}
