using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lection9
{
    class OwnException: Exception
    {
        public OwnException(string message): base(message) 
        {
        }
        
    }
}
