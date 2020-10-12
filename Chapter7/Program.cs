using Section02;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter7
{
    class Program
    {
        static void Main(string[] args)
        {
            //var employeeDict = new Dictionary<int, Employee>
            //{
            //    {100,new Employee(100,"清水遼久") },
            //    {112,new Employee(112,"芹沢洋和") },
            //    {125,new Employee(125,"岩瀬奈央子") },

            //};
            //var employees = employeeDict.Where(emp => emp.Value.Id % 2 == 0);
            //foreach (var item in employees)
            //{
            //    Console.WriteLine($"{item.Value.Name}");
            //}

            //リスト
            //  var employee = new List<Employee>(){
            //      new Employee(100,"清水遼久") ,
            //      new Employee(112, "芹沢洋和") ,
            //      new Employee(125, "岩瀬奈央子"),
            //      new Employee(143,"山田太郎"),
            //      new Employee(148,"池田次郎"),
            //      new Employee(152,"幸田三郎"),
            //      new Employee(155,"石川幸田"),
            //      new Employee(161,"中沢信也"),
            //  };

            //  var employeeDict = employee.Where(emp=>emp.Id % 2 ==0).ToDictionary(emp => emp.Id);

            ////  Console.WriteLine(employeeDict.Sum(x=>x.Value.Id));
            //  foreach (KeyValuePair<int,Employee> item in employeeDict)
            //  {
            //      Console.WriteLine($"{item.Value.Id} = {item.Value.Name}");
            //  }
            //___________________________________________________________________________________________________
            //var dict = new Dictionary<MonthDay, string>
            //{
            //    {new MonthDay(3,5),"珊瑚の日" },
            //    {new MonthDay(8,4),"箸の日" },
            //    {new MonthDay(10,3),"登山の日" },
            //};

            //var md = new MonthDay(8, 4);
            //var s = dict[md];
            //Console.WriteLine(s);
            //_________________________________________________________________________________

            var lines = File.ReadAllLines("sample.txt");
            var we = new WordsExtractor(lines);
            foreach (var word in we.Extract()) 
            {
                Console.WriteLine(word);
            }

            
        }
    }
}
