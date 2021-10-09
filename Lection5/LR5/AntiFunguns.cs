using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR5
{
    class AntiFunguns: Drugs
    {
        string fungunType;
        string bodyPart;
        public AntiFunguns():this ("Fungun","All") 
        {
            fungunType = "Candid";
        }

        public AntiFunguns(string fungunType, string bodyPart)
        {
            this.fungunType = fungunType;
            this.bodyPart = bodyPart;
        }

        public double SetPrice
        {
            set => price = value;
            get => price;
        }

        public int SetAmount
        {
            set => amount = value;
            get => amount;
        }

        public string SetName
        {
            set => name = value;
            get => name;
        }

        public string SetForm
        {
            set => form = value;
            get => form;
        }

        public string SetActiveSubstance
        {
            set => activeSubstance = value;
            get => activeSubstance;
        }

        public override string ToString()
        {
            return $"Назавние противогрибкового -- {name} \nЦена: {price} \nКоличество: {amount} \nФорма -- {form} \nДействующее вещесвто -- {activeSubstance} \nНазвание грибка -- {fungunType} \nМесто действия -- {bodyPart}";
        }
    }
}
