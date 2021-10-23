using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class SelfWork: ITest, IComparable
    {
        public string name;
        public int result;
        public double coeficient;
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

        public int CompareTo(object obj)
        {
            SelfWork mem = (SelfWork)obj;
            return (int)(coeficient - mem.coeficient);
        }

        public override string ToString()
        {
            return $"Student name {name} result {result}";
        }
    }
}
