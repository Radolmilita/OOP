using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public delegate void GetCarInfoDelegate<in T>(T item);
    public delegate void VoidDelegate();
    class Program
    {
        static void CarData(Cars someCar) => someCar.Show();

        static void Main(string[] args)
        {
            // Own delegate 1 parametr
            GetCarInfoDelegate<Cars> carsShow;
            carsShow = CarData;
            Cars audi = new Cars { Vendor = "Audi", Model = "TT RS", HorsePower = 400, Concern = "Volkswagen"};
            carsShow(audi);

            Console.WriteLine(Environment.NewLine);

            //own delegate void

            Cars mercedes = new Cars {Vendor = "Mercedes-Benz", Model = "AMG GT-R", HorsePower = 585, Concern = "Daimler"};

            VoidDelegate showFunction = () => Console.WriteLine($"{mercedes}");
            showFunction();

            Console.WriteLine(Environment.NewLine);
            //in-built delegate void
            Cars toyota = new Cars {Vendor = "Toyota", Model = "Camry", HorsePower = 305, Concern = "Toyota Motor Corporation"};
            Action showToyota = () => Console.WriteLine(toyota);
            showToyota();

            Console.WriteLine(Environment.NewLine);
            //in-built delegate 1 parametr
            Cars forCall = new Cars();
            Cars [] carsArray = {  new Cars { Vendor = "Volkswagen", Model = "Golf GT-I", HorsePower = 350, Concern = "Volkswagen Group" },
                                   new Cars { Vendor = "Bentley", Model = "Continental", HorsePower = 463, Concern = "Volkswagen Group" },
                                   new Cars { Vendor = "Skoda", Model = "Octavia RS", HorsePower = 200, Concern = "Volkswagen Group" },
                                   new Cars { Vendor = "Mercedes-Benz", Model = "S-Classe", HorsePower = 630, Concern = "Daimler" },
                                   new Cars { Vendor = "Audi", Model = "RS-Q 7", HorsePower = 435, Concern = "Volkswagen Group" }
                                };

            Action<Cars[]> delegateForCarsArray = forCall.FindVolkswagenAmount;
            delegateForCarsArray(carsArray);

            Console.WriteLine(Environment.NewLine);

            // in-built delegate in in-built class
            List<Cars> carsList = new List<Cars>();
            Cars tesla = new Cars { Vendor = "Tesla", Model = "Model 3", HorsePower = 462, Concern = "Tesla Inc" };
            Cars mazda = new Cars { Vendor = "Mazda", Model = "6", HorsePower = 187, Concern = "Sumitomo" };
            Cars subaru = new Cars { Vendor = "Subaru", Model = "Legacy", HorsePower = 182, Concern = "Fuji Heavy Industries" };
            Cars renault = new Cars { Vendor = "Renault", Model = "Megane", HorsePower = 280, Concern = "Renault–Nissan–Mitsubishi" };
            carsList.Add(tesla);
            carsList.Add(mazda);
            carsList.Add(subaru);
            carsList.Add(renault);

            //Action<Cars>
            carsList.ForEach(car => Console.WriteLine(car));
            Console.WriteLine(Environment.NewLine);

            //Comparison
            carsList.Sort((car, otherCar) => otherCar.CompareTo(car));
            carsList.ForEach(car => Console.WriteLine(car));
            Console.WriteLine(Environment.NewLine);

            //Predicate

            List<Cars> changedCarsList = carsList.FindAll(car => (car.HorsePower > 200));
            changedCarsList.ForEach(car => Console.WriteLine(car));

            Console.WriteLine(Environment.NewLine);
            //Func
            Cars porscheMacan = new Cars { Vendor = "Porsche", Model = "Macan", Amount = 800000};
            Cars porscheCayene = new Cars { Vendor = "Porsche", Model = "Cayene", Amount = 1500000};
            Cars porsche911 = new Cars { Vendor = "Porsche", Model = "911", Amount = 400000};
            Cars porscheTaycan = new Cars { Vendor = "Porsche", Model = "Taycan", Amount = 60000 };
            List<Cars> porscheList = new List<Cars>();
            porscheList.Add(porscheMacan);
            porscheList.Add(porscheCayene);
            porscheList.Add(porsche911);
            porscheList.Add(porscheTaycan);

            Func<Cars, Cars, int> commonSuvAmount = (x, y) => porscheCayene.Amount + porscheMacan.Amount;
            Func<int, Cars, Cars, int> commonPorscheAmount = (x, y, z) => commonSuvAmount(porscheCayene, porscheMacan) + porsche911.Amount + porscheTaycan.Amount;
            Console.WriteLine($"Общее количество произведённых внедорожников Porsche {commonSuvAmount(porscheCayene, porscheMacan)}");
            Console.WriteLine($"Общее количество произведённых авто за последний год {commonPorscheAmount(commonSuvAmount(porscheCayene,porscheTaycan),porsche911,porscheTaycan)}");

            Console.ReadKey();
        }
    }
}
