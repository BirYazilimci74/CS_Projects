using System;

namespace Delegate
{
    class Program
    {
        public delegate void MyDelegate();
        public delegate void MyDelegateWithParam(string message);

        private static void Main(string[] args)
        {
            MessageSystem messageSystem = new MessageSystem();
            MyDelegate myDelegate = null;

            myDelegate += messageSystem.Hello;
            myDelegate += messageSystem.Alert;

            myDelegate();

            Console.WriteLine("*************");
            myDelegate -= messageSystem.Hello;
            myDelegate();

            Console.WriteLine("***With Parameter***");
            MyDelegateWithParam myDelegateWithParam = null;

            myDelegateWithParam += messageSystem.Alert2;
            myDelegateWithParam += messageSystem.Hello2;

            myDelegateWithParam("HelloWorld");

        }
    }
}
