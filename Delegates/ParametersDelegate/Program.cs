using System;

namespace ParameterDelegate
{
    public delegate void TwoParameterDel(string firstName, string lastName);
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var twoParameterDel = new TwoParameterDel(PrintName);
            twoParameterDel.Invoke("Abdul", "Hasee");
        }
        public static void PrintName(string firstname, string lastname)
        {
            Console.WriteLine($"My name is {firstname} {lastname}");
        }
    }
}
