using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lect
{
    class Test: IDisposable
    {
        string name;
        double result;
        double coeficient;
        public Test(string name, double result, double coeficient) {
            this.name = name;
            this.result = result;
            this.coeficient = coeficient;
        }

        public override string ToString()
        {
            return $"Имя студента: -- {name} Результат теста: -- {result} Коефициент по результатм учёбы: -- {coeficient}";
        }

        public void Dispose()
        {
            Console.WriteLine("Dispose by interface");
            Console.Beep();
            GC.SuppressFinalize(this);
        }

        //Недетерминированное уничтожение объектов 
        ~Test()
        {
            Console.Beep();
            Console.WriteLine("destructor");
            Console.ReadKey();
        }


    }
}
