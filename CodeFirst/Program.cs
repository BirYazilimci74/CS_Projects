using CodeFirst.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            EFCodeFirst eFCodeFirst = new EFCodeFirst();
            eFCodeFirst.CodeFirstOperations();

            Console.ReadLine();
        }
    }
}
