using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L6
{
    class Program
    {
        static void Main(string[] args)
        {
            Test t1 = new Test(95, "Valerij");
            Test t2 = new Test(40, "Andy");
            Test inSub = new Test(0, " ");
            Console.WriteLine(t1);
            Console.WriteLine(t2);
            inSub = t1 + t2;
            Console.WriteLine($"Общий {inSub.ToString()} {Environment.NewLine}");
            Test t3 = new Test(70, "Eugene");
            Console.WriteLine(t3);
            Test t4 = new Test(0, " ");
            t4 = ++t3;
            Console.WriteLine($"Исполльзование инкремента {t4} {Environment.NewLine}");
            Test t7 = new Test(100, "Mary");
            Console.WriteLine(t7);
            int d = t7 - 27;
            Console.WriteLine($"Отнимание числа от объекта {d} {Environment.NewLine}");
            Test resultValue = 80;
            Console.WriteLine($"Неявное преобразование {resultValue}");
            Int32 expValue = (Int32)resultValue;
            Console.WriteLine($"Явное преобразование {expValue}");
            Test other = 44;
            Console.WriteLine($"Расширение в действии {other.Sub()}");
            Console.ReadKey();
        }
    }
}
