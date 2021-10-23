using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Trees
    {
        public string name;
        public int age;
        public double height;
        public Trees(string name, int age, double height)
        {
            this.name = name;
            this.age = age;
            this.height = height;
        }
        public override string ToString()
        {
            return $"Имя дерева {name}, Возраст дерева {age}, Высота дерева {height}";
        }
    }
}
