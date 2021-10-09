using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR5
{
    class Test: Trial
    {
        public int NumberOfTask { get; set; }
        public Test(string nameOfCometition, int point, string levelOfExemple, int numberOfTask): base(nameOfCometition, point, levelOfExemple)
        {
            NumberOfTask = numberOfTask;
        }
    }
}
