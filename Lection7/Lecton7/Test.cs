using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecton7
{
    class Test<T>
    {
        public static T resultForFirstSubject;
        public static T resultForSecondSubject;

        public T Sum<T>(T resultForFirstSubject, T resultForSecondSubject) {
            T substraction = (dynamic)resultForFirstSubject + (dynamic)resultForSecondSubject;
            return substraction;
        }
    }
}
