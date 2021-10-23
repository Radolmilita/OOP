using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Park:IEnumerable,IEnumerator
    {
        int pos = -1;
        Trees[] trees;
        public Park(Trees[] tree) {
            trees = new Trees[tree.Length];
            for (int i = 0; i < tree.Length; i++) {
                trees[i] = tree[i];
            }
        }

        public object Current => trees[pos];

        public IEnumerator GetEnumerator()
        {
            return (IEnumerator) this;
        }

        public bool MoveNext()
        {
            pos++ ;
            if (pos < trees.Length)
                return true;
            return false;
        }

        public void Reset()
        {
            pos = -1;
        }
    }
}