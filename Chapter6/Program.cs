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
            var numbers = new List<int> { 9, 7, -5, 4, 2, 5, 4, 0, -4, -1, 0, 4, };
            Console.WriteLine($"平均値:{ numbers.Average()}");
            Console.WriteLine($"合計値:{ numbers.Sum()}");
            Console.WriteLine($"最小値:{numbers.Where(n=>n>0). Min()}");
            Console.WriteLine($"最大値:{numbers.Max()}");

            bool exists = numbers.Any(n => n % 7 == 0);

            var results = numbers.Where(n => n > 0).Take(5);
            foreach (var result in results)
            {
                Console.Write(result + " ");
            }

            var books = Books.GetBooks();
            Console.WriteLine($"平均価格:{books.Average(X=>X.Price)}");
            Console.WriteLine($"合計価格:{books.Sum(X => X.Price)}");
            Console.WriteLine($"ページ数最大:{books.Max(X => X.Pages)}");
            Console.WriteLine($"一番高い本:{books.Max(X => X.Price)}");
            Console.WriteLine($"タイトルに「物語」がある冊数:{ books.Count(x => x.Title.Contains("物語"))}");

            //600ページを超える書籍があるか？
          
            Console.WriteLine(books.Any(x => x.Pages > 600)?"ある":"ない");
         
            //全てが200ページ以上の書籍か？
            
            Console.WriteLine(books.All(x => x.Pages >= 200)?"です":"ちがう");
            //400ページを超える本は何冊目か？

            //var book = books.FirstOrDefault (x => x.Pages > 400);
            //int i;
            //for ( i = 0; i < books.Count; i++)
            //{
            //    if (books[i].Title.Contains(book.Title))
            //    {
            //        break;
            //    }
            //}
            //Console.WriteLine($"400ページを超える本は{i + 1}冊目です。");


            var count = books.FindIndex(x => x.Pages > 400);
            Console.WriteLine($"400ページを超える本は{count + 1}冊目です。");

            //本の値段が400以上のものを3冊表示
            var bookprise = books.Where(x => x.Price >= 400).Take(3);
            foreach (var item in bookprise)
            {
                Console.WriteLine(item.Title + " ");
            }
        }

    }
}
