//
//Lection1.sln
//OOP
//
//Created by Valerij Dimitriev on 2021.09.03
//
using System;

namespace Lection1
{
    class Program
    {

        static void Main(string[] args)
          {
            // Завдання 1
            // Оголошення мінімум 4 змінних різних типів.Для кожного типу використати ключеве слово мови С# та тип із .Net.
            int eiler1 = 271;
            System.Single eiler2 = 2.7182818284590452F;
            System.String eiler3 = "2,71828182845";
            System.Double eiler4 = 2.71828182845904523536028747;
            Console.WriteLine($"Целое значение {eiler1} \nС плавающей запятой = {eiler2} \nСтроковое {eiler3} \nРасширенный с плавающей {eiler4}");

            // Завдання 2
            // Оголошення змінних різних типів (reference та value). Демонстрацію різниці в роботі оператора присвоєння для цих типів.
            byte b1 = 250, b2 = 18, b3;
            b3 = (byte)(b1 + b2);
            Console.WriteLine($"Сумма байт = {b3}");
            
            Console.Write("Нравятся пары в университете? \n -");
            string attitude = Console.ReadLine();
            
            Console.Write("Напишите желаемую оценку по алгоритмам: ");

            int mark1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Напишите желаемую оценку по ООП: ");
            double mark2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Напишите желаемую оценку по web: ");
            uint mark3 = Convert.ToUInt32(Console.ReadLine());

            // Завдання 3
            // Демонстрацію роботи з методами для різних типів даних (тобто показати, що вбудовані типи є об‘єктами структур).
            string whole = "Simple text.";
            Console.WriteLine($"Before: \n * {whole} *\n After: \n * {whole.ToLower()} *");
            double new_eiler = double.Parse(eiler3);
            string new_eiler2 = new_eiler.ToString()+" This was eiler.";

            // Завдання 4
            // Явне та неявне перетворення типів.
            eiler4 = eiler2; // неявне
            eiler1 = (int)eiler4; // явне

            // Завдання 5
            // Використання ключових слів checked / unchecked
            checked
            {
                int lab1 = (int)(eiler2 * eiler4);
            }
            double lab12 = unchecked(eiler2 * eiler4);


            // Завдання 6
            // Роботу з нульовими типами даних.
            int? i = null;
            Console.WriteLine("i=" + i);
            i = i ?? 45;
            Console.WriteLine("i =" + i);

            // Завдання 7
            // Використання ключового слова var.
            var state = -334;
            Console.WriteLine(state.ToString());

            // Завдання 8
            // Використання ключового слова var.Меню (використати оператор switch), яке дозволяє вибрати, що вводити з клавіатури – ім‘я чи вік студента та завершувати роботу.
            Console.WriteLine("Сыграем партию?");
            string selection = Console.ReadLine().ToLower();
            switch (selection)
            {
                case "да":
                    Console.WriteLine("Шары на стол!");
                    break;
                case "нет":
                    Console.WriteLine("Что ж, в другой раз");
                    break;
                default:
                    Console.WriteLine("Не мешай тренеровке!");
                    break;
            }

            // Завдання 9
            // Фрагмент коду, в якому вводиться з клавіатури Ваше ім‘я та вік. Надалі виведиться Ваше ім‘я та кількість років, збільшених вдвоє, на екран. Обробку віку треба виконати в двох варіантах:
            // Без передбачення помилки введення
            // Обробити помилку при введенні числа з клавіатури.
            Console.Write("Введите имя: ");
            string name = Console.ReadLine();
            Console.Write("Введите возраст: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{name}, возраст увеличенный вдвое: {age*2}?");
            if (age > 90)
            {
                try
                {
                    Console.Write("Введите ваш возраст ещё раз: ");
                    int age2 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine($"{name}, ваш возраст увеличенный вдвое: {age2 * 2}?");
                }
                catch
                {
                }
            }
            // Завдання 10
            // Додатково для поглибленого вивчення: Огляд можливостей класу Environment
            Console.WriteLine("Дальше будет пустая линия" + Environment.NewLine);//перехід на новий рядок

            string[] myPc = Environment.GetLogicalDrives();//отримання дискiв ПК
            foreach (string drive in myPc) 
                Console.WriteLine("диск" + drive);//Вивiд дискiв на екран

            Console.WriteLine("Путь: " + Environment.GetEnvironmentVariable("PATH"));
            Console.ReadKey();
        }
    }
}
