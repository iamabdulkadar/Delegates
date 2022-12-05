using System;

namespace ParameterDelegate
{
    public delegate void PrintName(string name);
    class Program
    {
        static void Main(string[] args)
        {
            string Name = "Abdul";
            var printName = new PrintName(GetName);
            printName(Name);
        }
        static void GetName(string name)
        {
            Console.WriteLine("Name is : "+name);
        }
    }
}
