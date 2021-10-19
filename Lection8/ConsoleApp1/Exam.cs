using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Exam: ITest, IComparable<Exam>
    {
        string name;
        int result;
        double coeficient;
        public Exam(string name, int result, double coeficient)
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
            return result * coeficient;
        }

        public int CompareTo(Exam other)
        {
           return name.CompareTo(other.name);
        }

        public override string ToString()
        {
            return $"Student name {name} result {result} coeficient {coeficient}";
        }
    }
}
