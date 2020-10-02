using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4
{
    class Program
    {
        static void Main(string[] args)
        {
            var ymCollection = new YearMonth[]
            {
                new YearMonth(1988,1),
                new YearMonth(1992,5),
                new YearMonth(2000,6),
                new YearMonth(2011,9),
                new YearMonth(2020,12),
            };
            Console.WriteLine("--4.2.2--");
            foreach (var ym in ymCollection)
            {
                Console.WriteLine(ym);
            }
            Console.WriteLine("------------");

            Console.WriteLine("--4.2.4");
            Exercise2_4(ymCollection);
            Console.WriteLine("-----------");

            Console.WriteLine("--4.2.5");
            Exercise2_5(ymCollection);
            Console.WriteLine("-----------");



        }
        
        static YearMonth FindFirst21C(YearMonth[] yms)
        {
            foreach (var ym in yms)
            {
                if (ym.Is21Century)
                    return ym;
            }
            return null;
        }

        private static void Exercise2_4(YearMonth[] ymCollection)
        {
            var yearmonth = FindFirst21C(ymCollection);

            if (yearmonth == null)
            {
                Console.WriteLine("21世紀のデータはありません");
            }
            else
            {
                Console.WriteLine(yearmonth);
            }
        }

        private static void Exercise2_5(YearMonth[] ymcollection)
        {
            var array = ymcollection.Select(ym => ym.AddOneMonth()).ToArray();
            foreach(var ym in array)
            {
                Console.WriteLine(ym);
            }
        }

       

       
    }

   
}
