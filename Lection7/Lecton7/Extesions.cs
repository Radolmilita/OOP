using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecton7
{
    static class Extesions
    {
        public static Month spring = Month.March;
        public static Month springS = Month.April;
        public static bool SpringComing(this Month month) {
            return month == spring;
        }
    }
}
