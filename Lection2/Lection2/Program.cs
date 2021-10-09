using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lection2
{

    struct drugsStr {
        string drugsNameStr;
        int amountStr;
        int priceStr;
        internal drugsStr(string drugsNameStr, int amountStr, int priceStr)
        {
            this.drugsNameStr = drugsNameStr;
            this.amountStr = amountStr;
            this.priceStr = priceStr;
        }
        public override string ToString()
        {
            return "Название лекарства: " + drugsNameStr.ToString() + "\nКоличесвто: " + amountStr.ToString() + "\nЦена: " + amountStr.ToString();
        }
        public override bool Equals(object obj)
        {

            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                drugsStr n = (drugsStr)obj;
                return (drugsNameStr == n.drugsNameStr) && (amountStr == n.amountStr) && (priceStr == n.priceStr);
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            //Завдання 1
            int[] arrayInit = new int [] { 1, 27, 13, 46, 5, 17 }; //array with initialisation
            int [] arrayNoInit; //array witout initialisation
            arrayNoInit = new int[5]; //memory allocation
            arrayNoInit[0] = 16; //appeal to elements of array
            arrayNoInit[1] = 33;
            arrayNoInit[2] = 38;
            arrayNoInit[3] = 52;
            arrayNoInit[4] = 41;
            int sum = 0;
            foreach (int value in arrayInit) {
                sum += value;
            }
            Console.WriteLine($"Сумма элементов массива с инициализацией {sum}");
            Console.WriteLine($"Сумма элементов массива без инициализации {arrayNoInit.Sum()}");
            Console.WriteLine($"Длинна массива с инициализациией {arrayInit.GetLength(0)}");
            Console.WriteLine($"Длинна массива без инициализации {arrayNoInit.GetLength(0)}");
            
            
            //Завдання 2
            int[,] dimensionalArrayInit = new int[,] { {6, 97, 63, 47, 35 },
                                                       {22, 29, 51, 2, 9},
                                                       {44, 36, 21, 13, 3} };
            Console.WriteLine($"Длинна двумерного массива с инициализацией {dimensionalArrayInit.GetLength(1)}");

            int result = 1;
            for (int i = 0; i < dimensionalArrayInit.GetLength(0); i++)
                for (int j = 0; j < dimensionalArrayInit.GetLength(1); j++)
                    if (i % 2 == 0)
                        result *= dimensionalArrayInit[i, j];
            Console.WriteLine($"Произведение чётных строк матрицы с инициализацией = {result}");



            Console.WriteLine(Environment.NewLine);

            int[,] dimensionalArrayNoInit;
            dimensionalArrayNoInit = new int [5,5];
            
            Random ran = new Random();
            int maxRanValue = 10;
            for (int i = 0; i < dimensionalArrayNoInit.GetLength(0); i++) {
                for (int j = 0; j < dimensionalArrayNoInit.GetLength(1); j++) {
                    dimensionalArrayNoInit[i, j] = ran.Next(13, 79);
                    Console.Write("{0}\t", dimensionalArrayNoInit[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Длинна двумерного массива без инициализации {dimensionalArrayNoInit.GetLongLength(1)}");
            result = 1;
            for (int i = 0; i < dimensionalArrayNoInit.GetLength(0); i++)
                for (int j = 0; j < dimensionalArrayNoInit.GetLength(1); j++)
                    if (i % 2 == 0)
                        result *= dimensionalArrayNoInit[i, j];
            Console.WriteLine($"Произведение чётных строк матрицы без инициализации = {result}");


            Console.WriteLine(Environment.NewLine);

            Console.Write("Введите n: ");
            string input = Console.ReadLine();
            Console.WriteLine();
            int n, m;
            int.TryParse(input, out n);
            Console.Write("Введите m: ");
            input = Console.ReadLine();
            Console.WriteLine();
            int.TryParse(input, out m);
            int[,] array2 = new int[n, m];
            Console.WriteLine("Rank: " + array2.Rank);

            for (int i = 0; i < array2.GetLength(0); i++)
                for (int j = 0; j < array2.GetLength(1); j++)
                {
                    array2[i, j] = ran.Next(maxRanValue);
                    Console.WriteLine($"i:{i}, j:{j}, value:{array2[i, j]}");
                }
            Console.WriteLine($"Высота двумерного массива без инициализацией {dimensionalArrayInit.GetLength(0)}");
            Console.WriteLine($"Длинна двумерного массива без инициализации {array2.GetLength(1)}");

            result = 0;
            for (int i = 0; i < array2.GetLength(0); i++)
                for (int j = 0; j < array2.GetLength(1); j++)
                    if (i % 2 != 0)
                        result += array2[i, j];
            Console.WriteLine($"Проиведение чётных строк матрицы без инициализации = {result}");

            Console.WriteLine(Environment.NewLine);
            int r;
            while (true)
            {
                Console.Write("Введите количество строк: ");
                input = Console.ReadLine();
                Console.WriteLine();
                if (int.TryParse(input, out r))
                {
                    break;
                }
                Console.WriteLine("Вы ввели не правильное количество строк! Повторите попытку!");
            }
            // Создание и заполнение массива
            int[][] jagged = new int[r][];
            for (int i = 0; i < r; i++)
            {
                while (true)
                {
                    Console.Write($"Введите количество столбцов в {i}-ой строке: ");
                    input = Console.ReadLine();
                    Console.WriteLine();
                    if (int.TryParse(input, out m))
                    {
                        jagged[i] = new int[m];
                        for (int j = 0; j < m; j++)
                        {
                            jagged[i][j] = ran.Next(maxRanValue);
                        }
                        break;
                    }
                    Console.WriteLine("Вы ввели не правильное количество столбцов! Повторите попытку!");
                }
            }
            result = 0;
            for (int i = 0; i < jagged.GetLength(0); i++)
                for (int j = 0; j < jagged[i].Length; j++)
                    if (j % 2 != 0)
                        result += jagged[i][j];

            Console.WriteLine($"Произведение чётных строк матрицы = {result}");

            Console.WriteLine(Environment.NewLine);

            int valueToComp;
            while (true)
            {
                Console.Write($"Введите значение для сравнения: ");
                input = Console.ReadLine();
                Console.WriteLine();
                if (int.TryParse(input, out valueToComp))
                {
                    break;
                }
                Console.WriteLine("Вы ввели не правильное значение для сравнения! Повторите попытку!");
            }
            int repeats = 0;
            foreach (var value in dimensionalArrayInit)
            {
                if (value == valueToComp)
                {
                    repeats += 1;
                }
            }
            Console.WriteLine($"Колво повторов в 1D масиве- {repeats}!");

            repeats = 0;
            foreach (var value in dimensionalArrayInit)
                if (value == valueToComp)
                    repeats += 1;
            Console.WriteLine($"Колво повторов в 2D масиве - {repeats}!");

            repeats = 0;
            foreach (var row in jagged)
                foreach (var value in row)
                    if (value == valueToComp)
                        repeats += 1;
            Console.WriteLine($"Колво повторов в 2D невыровняном масиве - {repeats}!");

            Console.WriteLine();


            drugsStr codein = new drugsStr("Кодеин-фосфат", 20, 300);
            Console.WriteLine(codein);
            drugsStr efidrin = new drugsStr("Эфидрин", 15, 1000);
            Console.WriteLine(efidrin);

            bool mark = codein is drugsStr;
            if (codein is Drugs)
                Console.WriteLine("Кодеин принадлежит классу Drugs");
            else
                Console.WriteLine("Кодеин не относится к классу Drugs");



            Console.WriteLine("\n");

            Drugs paracetamol = new Drugs("Парацетамол", 5, 23);
            Console.WriteLine(paracetamol);
            Drugs gutallax = new Drugs("Гуталлакс", 15, 112);
            Console.WriteLine(gutallax);
                if (paracetamol.Equals(gutallax))
                    Console.WriteLine("Схожи");
                else
                    Console.WriteLine("Не схожи");
            
            Console.ReadKey();
        }
    }
}
