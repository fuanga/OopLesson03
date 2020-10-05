using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter5
{
    class Program
    {
        static void Main(string[] args)
        {

            #region 5.1
            //Console.Write("文字列１");
            //var str1 = Console.ReadLine();
            //Console.Write("文字列2");
            //var str2 = Console.ReadLine();
            //if (string.Compare(str1, str2, true) ==0)
            //{
            //    Console.WriteLine("等しい");
            //}
            //else
            //{
            //    Console.WriteLine("等しくない");
            //}
            #endregion
            #region 5.2
            //Console.Write("数値文字列");
            //var line = Console.ReadLine();
            //int num; //変換後の数値格納用
            //if(int.TryParse(line,out num))
            //{
            //    Console.WriteLine(num.ToString("#,#"));
            //}
            //else
            //{
            //    Console.WriteLine("数値文字列でありません");
            //}
            #endregion
            #region 5.3

            String str = "Jackdaws love my big sphinx of quartz";

            //1.
            //int spaces = str.Count(c => c == ' ');
            //Console.WriteLine("空白数{0}", spaces);

            //2.
            //var reqlaced = str.Replace("big", "small");
            //Console.WriteLine(reqlaced); 

            //3.
            //int count = str.Split(' ').Count();
            //Console.WriteLine(count);

            #region 自
            //string[] words = str.Split(' ');
            //Console.WriteLine(words.Length);
            #endregion
            //4.
            //var text = str.Split(' ')
            //    .Where(S => S.Length <= 4);
            //foreach(var tex in text){
            //    Console.WriteLine(tex);
            //}

            #region 自

            //for (int i = 0; i < words.Length; i++)
            //{
            //    if (words[i].Length <=4)
            //    {
            //        Console.WriteLine(words[i]);
            //    }
            //}
            #endregion

            //5.

            //var array = str.Split(' ').ToArray();
            //if (array.Length > 0) 
            //{
            //    var sb = new StringBuilder(array[0]);
            //    foreach(var word in array.Skip(1))
            //    {
            //        sb.Append(' ');
            //        sb.Append(word);
            //    }
            //    Console.WriteLine(sb);
            //}
            #endregion

            var lines = "Novelist=谷崎潤一郎;BestWork=春琴抄;Born=1886";

            
            foreach (var item in lines.Split(';'))
            {
                var word = item.Split('=');
                Console.WriteLine("{0}:{1}", ToJapanese(word[0]), word[1]);
            }



        }
        static string ToJapanese(string key)
        {
            switch (key)
            {
                case "Novelist":
                    return "作家";
                case "BestWork":
                    return "代表作";
                case "Born":
                    return "誕生年";
                default:
                    return "       ";


            }
        }
    }
}
