//
//Drugs.cs
//Created by Valerij Dimitriev
//
//on 2021.09.13
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lection3
{
    class Drugs
    {
        private string drugsName;
        private int amount;
        private string form;
        private int price;


        //для одного із полів Вашого класу оголосіть геттер та сеттер;
        public void setName(string drugsName) { this.drugsName = drugsName;}
        public string getName() { return drugsName; }

        //для іншого із полів Вашого класу оголосіть геттер та сеттер, але тіло повинно бути записано у вигляді виразу;
        public int setAmount(int amount) => this.amount = amount;
        public int getAmount()=>amount;
        public void Print() => Console.WriteLine($"Количество: {amount}");

        //для другого поля оголосіть звичайну властивість;
        public string Form
        {
            set { form = value;}
            get { return form;}
        }

        //замість третього поля Вашого класу створіть автоматичну властивість
        public int Price { get; set; }
        public override string ToString()
        {
            return $"Цена {price} гривен";
        }

        //додайте в клас оголошення довільного масиву та створіть індексатор.
        int[] array = new int[10];
        public int this[int i] {
            get => array[i];
            set => array[i] = value;
        }


    }
}
