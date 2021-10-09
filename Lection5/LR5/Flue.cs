using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR5
{
    sealed partial class Flue: Drugs
    {
        string flueType;
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

        public string SetFlueType {
            set => flueType = value;
            get => flueType;
        }
        public string SetFlueSolution {
            set => flueSolution = value;
            get => flueSolution;
        }
    }
}
