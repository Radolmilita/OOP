using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecton7
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] all = Enum.GetNames(typeof(Month));
            var str = string.Join("\n", all);
            Console.WriteLine(str);
            Console.WriteLine(Environment.NewLine);
            Month a = Month.October;
            All yep = new All();
            yep.PrintMonth(a);
            Month b = Month.March;
            Month c = Month.December;
            Console.WriteLine($"It's {(b.SpringComing() ? "spring came" : "smth different")}");
            Console.WriteLine($"It's {(c.SpringComing() ? "spring came" : "smth different")}");
            Test<int> test = new Test <int>();
            int resultFirst = 100;
            int resultSecond = 70;
            int result = test.Sum(resultFirst, resultSecond);
            Console.WriteLine($"Общий результат {result}");
            Console.ReadKey();
        }
    }
}
