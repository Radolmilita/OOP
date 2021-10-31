using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lection9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] alg = { 1, 2, 5, 2 };
            int a = 100, b = 0, result;
            int[] oneDAry = new int[5];
            int[,] twoDAry = new int[2, 3];

            //Возникновение, перехват исключения, блок finally.
            try
            {
                result = a / b;
            }
            catch (DivideByZeroException)
            {
                b = 11;
                result = a / b;
                Console.WriteLine(result);
            }
            finally {
                b = 10;
                result = a / b;
                Console.WriteLine($"Works finally {result}");
            }
            //catch без параметров
            try
            {
                Console.WriteLine(alg[11]);
            }
            catch
            {
                Console.WriteLine("You're making some sh@@@");
            }
            Console.WriteLine(Environment.NewLine);
            //Получение начальной точки после повторной генерации исключения
            for (int i = 0; i < 2; i++)
            {
                oneDAry.SetValue(i, i);
            }
            try
            {
                try
                {
                    Array.Copy(oneDAry, twoDAry, 2);
                }
                catch (RankException ex)
                {
                    Console.WriteLine(ex.StackTrace);
                    throw;
                }
            }
            catch (RankException ex) {
                Console.WriteLine($"{ex.InnerException} \n{ex.Message}");
            }
            Console.WriteLine(Environment.NewLine);

            //Своё исключение
            try
            {
                Test oop = new Test();
                oop.Name = "Valerij";
                oop.TestResult = 33;
            }
            catch (OwnException ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
            Console.WriteLine(Environment.NewLine);

            //Генерирование NullReference 
            int[] smth = null;
            try
            {
                foreach (var items in smth)
                    Console.WriteLine(smth);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine($"This is NullReferenceException {ex.Message}");
            }
            Console.WriteLine(Environment.NewLine);

            //Генерирование ArgumentNullException
            SelfWork[] mainWork = null;
            try
            {
                Array.Sort(mainWork, new SelfWork("", 0));
            }
            catch (ArgumentNullException ex) {
                Console.WriteLine($"Got ArgumentNullException {ex.Message}");
            }
            Console.WriteLine(Environment.NewLine);

            //Генерирование InvalidOperationException
            SelfWork[] math = {
                  new SelfWork("Valerij", 5),
                  null,
                  new SelfWork(null, 3)
            };
            try
            {
                Array.Sort(math);
            }
            catch (InvalidOperationException ex) {
                Console.WriteLine($"Got InvalidOperationException {ex.Message}");
            }

                Console.ReadKey();
        }
    }
}


//var numbers = new List<int>() { 1, 2, 3, 4, 5 };
//try
//{
//    foreach (var number in numbers)
//    {
//        int inSquare = (int)Math.Pow(number, 2);
//        Console.WriteLine($"{number}{inSquare}");
//        Console.WriteLine($"Adding {inSquare} to the collection...\n");
//        numbers.Add(inSquare);
//    }
//}
//catch (InvalidOperationException ex) {
//    Console.WriteLine($"Got exception {ex.Message}");
//}
