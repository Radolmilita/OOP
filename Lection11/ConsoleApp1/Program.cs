using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayList
            ArrayList station = new ArrayList(20);
            station.Add(new Train(331223, "TGV", 2));
            station.Add(new Train(763456, "AVE S-101", 7));
            station.Add(new Train(587945, "HRC S2", 5));
            Console.WriteLine("---Перед сортировкой---");
            foreach(var item in station)
            {
                Console.WriteLine(item.ToString());
            }

            station.Insert(3, new Train(12312, "HRC S-2", 11));

            Console.WriteLine();
            station.Sort(new Train());

            Console.WriteLine("---После сортировки---");
            foreach (var item in station) {
                Console.WriteLine(item);
            }

            Train[] stationCopy = new Train[20];

            station.CopyTo(stationCopy);

            Console.WriteLine("---Скопированный ArrayList---");
            foreach (var item in stationCopy) {
                Console.WriteLine(item);
            }
            station.Clear();

            ArrayList values = new ArrayList(10);
            values.Add(23);
            values.Add(11);
            values.Add(91);
            int sum = 0;
            foreach (int item in values) {
                sum += item;
            }
            Console.WriteLine(sum);


            //List<T>

            Trees[] trees = {
                new Trees(10,"Дуб", 7),
                new Trees(45, "Тополь",100),
                new Trees(11, "Сосна", 18)
            };
            Console.WriteLine("---До сортировки---");
            Park<Trees> somePark = new Park<Trees>(trees);
            foreach (Trees tree in somePark) {
                Console.WriteLine(tree);
            }
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("---После сортировки---");
            somePark.Sort();
            foreach (Trees tree in somePark)
            {
                Console.WriteLine(tree);
            }

            Console.WriteLine(Environment.NewLine);

            Console.WriteLine($"Медоты List<T>");
            Console.WriteLine(Environment.NewLine);
            somePark.Reverse();
            foreach (Trees tree in somePark)
            {
                Console.WriteLine(tree);
            }

            Console.WriteLine(somePark.GetType());
            Console.WriteLine(somePark.Last());
            Console.WriteLine(somePark.GetHashCode());

            Console.WriteLine(Environment.NewLine);

            //HashSet
            HashSet<Train> hashTrains = new HashSet<Train>();
            hashTrains.Add(new Train(68127, "Sm3",2));
            hashTrains.Add(new Train(56765, "TGV Atlantique", 5));
            hashTrains.Add(new Train(65489, "TGV Duplex", 20));
            hashTrains.Add(new Train(65489, "TGV Duplex", 20));
            foreach (Train train in hashTrains) {
                Console.WriteLine(train);
            }
            Console.ReadKey();

        }
    }
}
