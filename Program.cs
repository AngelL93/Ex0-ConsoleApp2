﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex0.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please type your name?");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello {name}");
            Console.ReadKey();
        }
    }
}
