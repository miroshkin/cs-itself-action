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

            Action<int> printActionDel = ConsolePrint;
            printActionDel(200);

            Action<string> printMessage = ConsolePrint;
            printMessage.Invoke("Hello, world!");

            Action<string, int> printLongMessage = new Action<string, int>(ConsolePrint);
            printLongMessage.Invoke("Error", 404);

        }

        static void ConsolePrint(int i)
        {
            Console.WriteLine(i);
        }

        static void ConsolePrint(string message)
        {
            Console.WriteLine("Message : " + message);
        }

        static void ConsolePrint(string message, int value)
        {
            Console.WriteLine($"{message} #{value}");
        }
    }
}
