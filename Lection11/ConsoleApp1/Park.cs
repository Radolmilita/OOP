using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Park <T>:IEnumerable<T> where T: Trees
    {
        List<T> treesList = new List<T>(30);
        public Park(T[] trees) {
            foreach (T tree in trees) {
                treesList.Add(tree);
            }
        }

        public void Sort() {
            treesList.Sort();
        }
        public void Clear() {
            treesList.Clear();
        }
        public void Reverse()
        {
            treesList.Reverse();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return treesList.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

    }
}
