using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR5
{
    partial class Flue
    {
        string flueSolution;
        public override string ToString()
        {
            return $"Назавние противогрибкового -- {name} \nЦена: {price} \nКоличество: {amount} \nФорма -- {form} \nДействующее вещесвто -- {activeSubstance} \nТип простуды -- {flueType} \nМесто действия -- {flueSolution}"; ;
        }
    }
}
