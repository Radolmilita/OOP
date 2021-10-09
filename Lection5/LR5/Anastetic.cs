using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR5
{
    sealed class Anastetic : Drugs
    {
        string anasteticType;
        public double SetPrice {
            set => price = value;
            get => price;
        }

        public int SetAmount {
            set => amount = value;
            get => amount;
        }

        public string SetName {
            set => name = value;
            get => name;
        }

        public string SetForm {
            set => form = value;
            get => form;
        }

        public string SetActiveSubstance {
            set => activeSubstance = value;
            get => activeSubstance;
        }

        public string SetAnasteticType {
            set => anasteticType = value;
            get => anasteticType;
        }
        public override string ToString()
        {
            return $"Назавние анастетика -- {name} \nЦена: {price} \nКоличество: {amount} \nФорма -- {form} \nДействующее вещесвто -- {activeSubstance} \nКласс анастетика -- {anasteticType}";
        }
    }
}
