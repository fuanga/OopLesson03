﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3
{
    class Program
    {

        static void Main(string[] args)
        {
            var numbers = new List<int> { 12, 87, 94, 14, 53, 20, 40, 35, 76, 91, 31, 17, 48 };

            IE = numbers.Select(s => s * 2);

            foreach (var s in query)
            {
                Console.WriteLine(s);
            }
            

        }
    }
}