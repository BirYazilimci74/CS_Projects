﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Framework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DBFirst dBFirst = new DBFirst();

            dBFirst.DBFirstOperation();
            Console.ReadLine();
        }
    }
}
