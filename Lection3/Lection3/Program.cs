//
//Program.cs
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
    class Program
    {
        static void Main(string[] args)
        {
            Drugs citramon = new Drugs();
            Drugs nurofen = new Drugs();
            
            
            citramon.setName("Цитрамон");
            Console.WriteLine($"Название лекарсвта: {citramon.getName()}");

            nurofen.setName("Нурофен");
            Console.WriteLine($" Название лекарста: {nurofen.getName()}");
            
            citramon.setAmount(10);
            citramon.Print();
            nurofen.setAmount(45);
            nurofen.Print();

            citramon.Form = "Таблетка";
            Console.WriteLine($"Форма отпуска лекарственного средства: {citramon.Form}");

            nurofen.Form = "Таблетка";
            Console.WriteLine($"Форма отпуска лекарственного средства: {nurofen.Form}");



            citramon.Price = 20;
            nurofen.Price = 50;
            Console.WriteLine($"Цена {citramon.Price} гривен");
            Console.WriteLine(citramon.Price);
            Console.WriteLine($"Цена {nurofen.Price} гривен");
            Console.WriteLine(nurofen.Price);

            citramon[0] = 4;
            citramon[1] = 35;
            citramon[2] = 27;
            citramon[3] = 81;
            citramon[4] = 315;
            citramon[5] = 690;
            citramon[6] = 458;
            citramon[7] = 123;
            citramon[8] = 45;
            citramon[9] = 32;
            Console.WriteLine($"Массив в классе {citramon[0]} {citramon[1]} {citramon[2]} {citramon[3]} {citramon[4]} {citramon[5]} {citramon[6]} {citramon[7]} {citramon[8]} {citramon[9]}");

            Console.WriteLine();

            Test test = new Test(4,5);
            test.setField1(40);
            test.Field2 = 56;
            Console.WriteLine($"get field1 {test.getField1()}");
            Console.WriteLine(test.ToString());

            string str1 = "Tiefenrausch";

            Console.ReadKey();
        }
    }
}
