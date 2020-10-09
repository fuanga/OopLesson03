using Chapter06;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Chapter6
{
    class Book
    {
        public string Title { get; set; }
        public int Price { get; set; }
        public int Pages { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var books = new List<Book> {

                new Book { Title = "C#プログラミングの新常識", Price = 3800, Pages = 378 },
                new Book { Title = "ラムダ式とLINQの極意", Price = 2500, Pages = 312 },
                new Book { Title = "ワンダフル・C#ライフ", Price = 2900, Pages = 385 },
                new Book { Title = "一人で学ぶ並列処理プログラミング", Price = 4800, Pages = 464 },
                new Book { Title = "フレーズで覚えるC#入門", Price = 5300, Pages = 604 },
                new Book { Title = "私でも分かったASP.NET MVC", Price = 3200, Pages = 453 },
                new Book { Title = "楽しいC#プログラミング教室", Price = 2540, Pages = 348 },

            };

            Console.WriteLine("___________6.2-1______________");
            var book = books.FirstOrDefault(b => b.Title == "ワンダフル・C#ライフ");
            if (book != null)
            {
                Console.WriteLine($"{book.Price} {book.Pages}");
            }

            Console.WriteLine("___________6.2-2______________");
            Console.WriteLine(books.Count(x => x.Title.Contains("C#"))+"冊");

            
            Console.WriteLine("___________6.2-3______________");

            var average = books.Where(b => b.Title.Contains("C#")).Average(b => b.Pages);

            Console.WriteLine(average);

            Console.WriteLine("___________6.2-4______________");
            var bok = books.FirstOrDefault(b => b.Price >= 4000);
            if (bok != null)
            {
                Console.WriteLine(bok.Title);
            }

            Console.WriteLine("___________6.2-5______________");
            var pages = books.Where(b => b.Price < 4000).Max(b=>b.Pages);
            Console.WriteLine(pages);

            Console.WriteLine("___________6.2-6______________");
            var selected = books.Where(b => b.Pages >= 400).OrderByDescending(b => b.Price);
            foreach (var item in selected)
            {
                Console.WriteLine($"{book.Title} {book.Price}");
            }

            Console.WriteLine("___________6.2-7______________");
            var selecte = books.Where(b => b.Title.Contains("C#") && b.Pages <= 500);
            foreach (var item in books)
            {
                Console.WriteLine(item.Title);
            }
        }


    }
}
