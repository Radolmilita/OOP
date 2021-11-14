using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Train : IComparer
    {
        int serialNumber;
        string model;
        int age;
        public Train() { }
        public Train(int serialNumber, string model, int age) {
            this.serialNumber = serialNumber;
            this.model = model;
            this.age = age;
        }

        public int Compare(object x, object y)
        {
            Train train1 = (Train)x;
            Train train2 = (Train)y;
            return train1.age.CompareTo(train2.age);
        }

        public override bool Equals(object obj)
        {
            Train someTrain = (Train)obj;
            return serialNumber == someTrain.serialNumber &&
                                   age == someTrain.age &&
                                   string.Equals(model, someTrain.model);
        }

        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }

        public override string ToString()
        {
            return $"Серийный номер -- {serialNumber}   Модель -- {model}   В эксплуатации -- {age} (года)";
        }
    }
}
