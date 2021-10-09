using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR5
{
    class Exam : Trial
    {
        public int PageNumber { get; set; }
        public Exam(string nameOfCometition, int point, string levelOfExemple, int pageNumber)
            : base(nameOfCometition, point, levelOfExemple)
        {
            PageNumber = pageNumber;
        }
        // 12
        public override void Display()
        {
            Console.WriteLine("Pages in Exem " + PageNumber);
        }
        //10
        // функция котороя принимает объекты класса object
        public void Foo(Object obj)
        {
            Exam exem = obj as Exam;
            if (exem != null)
            {
                Console.WriteLine("not null");
            }
            else
            {
                Console.WriteLine(obj);
            }
        }
        //11
        // функция которая принимает в качестве парметра обэкты моего базового класса
        public void Voo(Trial tp, Trial tq)
        {
            Console.WriteLine(tp);
            Console.WriteLine(tq);
        }

    }
}
