using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Singleton_Design_Pattern
{
    public class Singleton
    {
        private static Singleton _singleton;
        
        public static Singleton Instance()
        {
            return _singleton ?? (_singleton = new Singleton());
        }

        public void Hello()
        {
            Console.WriteLine("Hello World");
        }
    }
}