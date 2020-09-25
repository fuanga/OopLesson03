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
            var names = new List<string>
            {
                "Tokyo","New Delhi","Bangkok","London","Paris","Berlin","Canberra","HongKong",
            };

            IEnumerable<string> query = names.Where(s => s.Length <= 5) ;
            foreach(var item in query)
            
                {
                    Console.WriteLine(item);
                }
            Console.WriteLine("-------------");

            names[0] = "Osaka";
            foreach (var item in query) 
            {
                Console.WriteLine(item);
            }
               
            
           

        }
    }
}