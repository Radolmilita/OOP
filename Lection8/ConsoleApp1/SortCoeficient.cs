using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class SortCoeficient : IComparer
    {
        public int Compare(object x, object y)
        {
            SelfWork homeworkA = (SelfWork)x;
            SelfWork homeworkB = (SelfWork)y;
            return homeworkA.name.CompareTo(homeworkB.name);
        }
    }
}
