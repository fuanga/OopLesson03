using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3
{
    class Program
    {
        //デリゲートの宣言(int型の引数を受け取ってbool型を返すメソッド)
        public delegate bool Judgement(int value);
        static void Main(string[] args)
        {
            var numbers = new[] { 5, 3, 9, 6, 7, 5, 8, 1, 0, 5, 10, 4 };

            //匿名メソッドを使用した例
            //int count = Count(numbers,delegate(int n){ return (n >= 5);}) ;
            int count = Count(numbers,  n => 5 <=n && n <= 8);
            Console.WriteLine(count);
        }

        //nが偶数かどうか調べる
       // public static bool IsEven(int n)
       //{
       //     return (n >= 5);

            //return (n % 2 == 0);

            //if (n % 2 ==0)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
       // }


        public static int Count(int[] numbers, Judgement judge)
        {
           
            int count = 0;
            foreach(var n in numbers)
            {
                if (judge(n)==true)
                    count++;
            }
            return count;
        }
    }
}
