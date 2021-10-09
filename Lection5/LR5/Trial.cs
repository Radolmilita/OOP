using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR5
{
    class Trial
    {
        public string NameOfCometition { get; set; }
        public int Point { get; set; }
        public string LevelOfExemple { get; set; }

        public Trial(string nameOfCometition, int point, string levelOfExemple)
        {
            NameOfCometition = nameOfCometition;
            Point = point;
            LevelOfExemple = levelOfExemple;
        }
        // создал виртуальную функцию для того что б прегрузить в
        //дальнейшем и использивать при создании массива объэктов
        public virtual void Display()
        {
            Console.WriteLine("Nameofcompetiton " + NameOfCometition);
            Console.WriteLine("Point " + Point);
            Console.WriteLine("Levelofexemple " + LevelOfExemple);

        }

    }
}
