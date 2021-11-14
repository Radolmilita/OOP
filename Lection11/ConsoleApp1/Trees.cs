using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Trees:IComparable<Trees>
    {
        public int age;
        string treeName;
        int height;
        public int GetAge => age;
        public int GetHeigh => height;
        public Trees(int age, string treeName, int height) {
            this.age = age;
            this.treeName = treeName;
            this.height = height;
        } 


        public Trees() { }


        public override string ToString()
        {
            return $"Название дерева -- {treeName} Возраст дерева -- {age} Высота дерева -- {height}";
        }

        public int CompareTo(Trees other)
        {
            return GetHeigh-other.GetHeigh;
        }
    }
}
