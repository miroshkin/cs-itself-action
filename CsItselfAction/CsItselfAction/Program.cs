using System;

namespace CsItselfAction
{
    class Program
    {
        public delegate void Print(int val);

        static void Main(string[] args)
        {
            Print print = ConsolePrint;
            print.Invoke(1234);
        }

        static void ConsolePrint(int i)
        {
            Console.WriteLine(i);
        }
    }
}
