using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class SelfWork: ITest, IComparer
    {
        string name;
        int result;
        double coeficient;
        public SelfWork(string name, int result, double coeficient)
        {
            this.name = name;
            this.result = result;
            this.coeficient = coeficient;
        }
        public int Result
        {
            get => result;
            set => coeficient = value;
        }
        public double Coeficient
        {
            get => coeficient;
            set => coeficient = value;
        }

        public double CommonResult()
        {
            return result*coeficient + 21;
        }

        public int Compare(object x, object y)
        {
            SelfWork homeworkA = (SelfWork)x;
            SelfWork homeworkB = (SelfWork)y;
            return homeworkA.name.CompareTo(homeworkB.name);
        }

        public override string ToString()
        {
            return $"Student name {name} result {result}";
        }
    }
}
