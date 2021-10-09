using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR4
{
    class Program
    {
        public void Change(Drugs citramon) {
            citramon.Price = 20;
            citramon.Amount = 30;
        }
        static void Main(string[] args)
        {
            Drugs citramon = new Drugs(30, 20);//for reference
            Program pr = new Program();
            citramon.SetName("Цитрамон");
            pr.Change(citramon);
            Console.WriteLine(citramon.ToString());

            Console.WriteLine("");

            Drugs aspirin = new Drugs(10, 70);//for value
            int price = 10, amount = 70;
            aspirin.SetName("Аспирин");
            aspirin.Swap(price, amount);
            Console.WriteLine(aspirin.ToString());
            aspirin.Comparison(price, amount);

            Drugs analgin = new Drugs(30, 80); //for ref
            analgin.SetName("Анальгин");
            analgin.Price = 30; 
            analgin.Amount = 80;
            double fullPrice = analgin.Price;
            analgin.AddNDS(ref fullPrice);


            Drugs other = new Drugs(1, 1); //for out
            other.Input(out var sout);
            Console.WriteLine($"type sat = {sout.GetType()} \nsout= {sout}");
            int cpy = 9;
            other.Fun(4, 12, 15, 7);
            other.Fun(0, 8, 10);
            other.Fun(cpy, 8, 14, 58);
            other.Fun();
            int result, result1;
            result = other.NamedArguments(1, 6, 7);
            result1 = other.NamedArguments(first: 3, second: 11, 67);
            Console.WriteLine($"Результат = {result} Резульат1 = {result1}");
            Console.WriteLine("\n");
            other.OptionalArguments(1,2,5);
            other.OptionalArguments(7, 3, 5);
            other.OptionalArguments(1);           
            Console.ReadKey();
        }
    }
}
