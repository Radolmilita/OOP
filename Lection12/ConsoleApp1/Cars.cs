using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    delegate void CarsDelegate (Cars[]carsArray);
    class Cars : IComparable<Cars>
    {
        public string Vendor { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
        public string Concern { get; set; }
        public int Amount { get; set; }
        public Cars() { }
        public void Show() {
            Console.WriteLine($"Марка машины {Vendor} \n Модель авто: {Model} \n Мощность двигателя (в ЛС) {HorsePower} \n Концерн к которому относится марка: {Concern}");
        }
        public void ShowWithAmount() {
            Console.WriteLine($"Марка машины {Vendor} \n Модель авто: {Model} \n Произведено штук {Amount} \n Концерн к которому относится марка: {Concern}");
        }
        public void FindVolkswagenAmount(Cars[]carsArray){
            int count = 0;
            foreach (Cars car in carsArray) {
                if (car.Concern == "Volkswagen Group") {
                    count++;
                }
            }
            Console.WriteLine($"Автомобилей концерна VAG Group в массиве: {count}");
        }

        public override string ToString()
        {
            return $"Марка машины {Vendor} \n Модель авто: {Model} \n Мощность двигателя (в ЛС) {HorsePower} \n Концерн к которому относится марка: {Concern}";
        }

        public int CompareTo(Cars other)
        {
            return HorsePower - other.HorsePower;
        }
    }
}
