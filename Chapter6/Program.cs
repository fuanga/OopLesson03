using Chapter06;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Chapter6
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[] { 5, 10, 17, 9, 3, 21, 10, 40, 21, 3, 35 };
            //6.1-1
            Console.WriteLine("______________6.1-1______________");
            Console.WriteLine(numbers.Max());

            //6.1-2
            Console.WriteLine();
            Console.WriteLine("______________6.1-2______________");
            int pos = numbers.Length - 2;
            foreach(var number in numbers.Skip(pos))
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
            //6.1-3
            Console.WriteLine();
            Console.WriteLine("______________6.1-3______________");
            var strNums = numbers.Select(n => n.ToString());
            foreach (var str in strNums)
            {
                Console.Write(str + " ");
            }


            //6.1-4
            Console.WriteLine();
            Console.WriteLine("______________6.1-4______________");
            var sorte = numbers.OrderBy(x => x);
            foreach (var item in sorte.Take(3))
            {
                Console.Write(item + " ");
            }
            //6.1-5
            Console.WriteLine();
            Console.WriteLine("______________6.1-5______________");
            Console.WriteLine( numbers.Distinct().Count(n => n > 10));

            //6.2-1





            var books = new List<Book> {
  
                new Book { Title = "C#プログラミングの新常識", Price = 3800, Pages = 378 },
                new Book { Title = "ラムダ式とLINQの極意", Price = 2500, Pages = 312 },
                new Book { Title = "ワンダフル・C#ライフ", Price = 2900, Pages = 385 },
                new Book { Title = "一人で学ぶ並列処理プログラミング", Price = 4800, Pages = 464 },
                new Book { Title = "フレーズで覚えるC#入門", Price = 5300, Pages = 604 },
                new Book { Title = "私でも分かったASP.NET MVC", Price = 3200, Pages = 453 },
                new Book { Title = "楽しいC#プログラミング教室", Price = 2540, Pages = 348 },

            };

        }


    }
}
