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
            //整数の例
            var numbers = new List<int> { 19, 17, 15, 24, 12, 25, 14, 20, 12, 28, 19, 30, 24 };

            //var strings = numbers.Select(n => n.ToString("0000")).ToArray();
            //foreach (var str in strings)
            //{
            //    Console.Write(str + " ");
            //}
            

            numbers.Distinct().Select(n => n.ToString("0000")).ToList().ForEach(S => Console.Write(S + " "));

            Console.WriteLine();//改行

            //並べ替え
            var sortedNumbers = numbers.OrderBy(n => n);
            foreach (var nums in sortedNumbers)
            {
                Console.Write(nums + " ");
            }

            //文字列の例
            var words = new List<string> { "Microsoft", "Apple", "Google", "Oracle", "Facebook", };

            var loewer = words.Select(name => name.ToLower()).ToArray();

            //オブジェクトの例
            var books = Books.GetBooks();


            //タイトルリスト
            var tatles = books.Select(x => x.Title);

            foreach (var title in tatles)
            {
                Console.Write(title + " ");
            }

            Console.WriteLine();
            //ページ数の多い順に並べ替え（または金額の高い順）
            var sortedBooks = books.OrderByDescending(n => n.Pages);
            foreach (var item in sortedBooks)
            {
                Console.Write(item.Title + " " + item.Pages);
            }
        }

    }
}
