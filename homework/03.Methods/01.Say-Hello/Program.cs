﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Say_Hello
{
    class Program
    {
        static void PrintName()
        {
            string name = Console.ReadLine();
            Console.WriteLine("Hello, {0}!", name);
        }
        static void Main()
        {
            PrintName();
        }
    }
}
