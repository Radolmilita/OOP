using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lection9
{
    class Test
    {
        public int result;
        public string Name { get; set; }
        public int TestResult {
            get { 
                return result; 
            }
            set {
                if (value < 40)
                    throw new OwnException("Невозможно набрать настолько мало баллов");
                else
                    result = value;
            }
        }


    }
}
