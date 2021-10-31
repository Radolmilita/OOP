using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lection9
{
    class SelfWork: IComparer
    {
        string studentName;
        int mark;
        public SelfWork(string studentName, int mark) {
            this.studentName = studentName;
            this.mark = mark;
        }

        public int Compare(object x, object y)
        {
            SelfWork firstWork = (SelfWork)x;
            SelfWork secondWork = (SelfWork)y;
            return firstWork.studentName.CompareTo(secondWork.studentName);
        }
    }
}

