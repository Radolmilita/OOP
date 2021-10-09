using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR4
{
    class Drugs
    {
        private string drugsName;
        private int amount;
        private string form;
        private double price;

        public Drugs(int amount, int price) {
            this.price = price;
            this.amount = amount;
        }

        public void Swap(int amount, int price) {
            int temp = price;
            price = amount;
            amount = temp;
            Console.WriteLine($"Название {drugsName} \nЦена {price} \nКоличество {amount} {Environment.NewLine}");
        }

        public double Price { 
            set => price = value;
            get => price; 
        }
        public int Amount {
            set => amount = value;
            get => amount;
        }
        public void SetName(string drugsName) { this.drugsName = drugsName; }
        public string GetName() { return drugsName; }

        public void AddNDS(ref double fullPrice) {
            double a = 0.2;
            fullPrice = price + (price * a);

            Console.WriteLine($"{Environment.NewLine}Название {drugsName} \nЦена с НДС {fullPrice} {Environment.NewLine}");
        }

        public void Input(out int sat) {
            sat = 800;
            Console.WriteLine($"sat= {sat}");
        }

        //использование params
        public void Fun(params int [] sf) {  
            foreach (int i in sf)
                Console.WriteLine($"parametr = {i}");
            Console.WriteLine("\n");
        }

        public int NamedArguments(int first, int second, int third) {
            return first + second * third;   
        }

        public void OptionalArguments(int opt3, int opt1 = 4, int opt2 = 2) {
            Console.WriteLine($"optional argument f = {opt1}, \noptional argument s= {opt2} \noptional argument t = {opt3}");
        }

        public void Comparison(int amount, int price) {
            if (amount > price) {
                Console.WriteLine("Было в достатке");
            } else if (amount == price) {
                Console.WriteLine("Мы где-то зашли не там");
            }
            else {
                Console.WriteLine("Походу дефицит, поднимай ещё цены!");
            }
            
        }

        public override string ToString()
        {
            return $"Название {drugsName} \nЦена {price} \nКоличество {amount}";
        }
    }
}
