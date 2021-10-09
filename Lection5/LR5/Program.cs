using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR5
{
    class Program
    {
        static void Main(string[] args)
        {
            Anastetic lidocain = new Anastetic();
                lidocain.SetName = "Лидокаин";
                lidocain.SetPrice = 20.5;
                lidocain.SetAmount = 8;
                lidocain.SetForm = "Ампула";
                lidocain.SetActiveSubstance = "лидокаина гидрохлорид";
                lidocain.SetAnasteticType = "Местный";
                Console.WriteLine(lidocain.ToString());
            Console.WriteLine(Environment.NewLine);

            AntiFunguns kanesten = new AntiFunguns();
                kanesten.SetName = "Канестен";
                kanesten.SetPrice = 705.21;
                kanesten.SetAmount = 10;
                kanesten.SetForm = "Таблетки";
                kanesten.SetActiveSubstance = "клотримазол";
                Console.WriteLine(kanesten.ToString());
            Console.WriteLine(Environment.NewLine);

            Flue askaril = new Flue();
                askaril.SetName = "Аскарил";
                askaril.SetPrice = 74.4;
                askaril.SetAmount = 10;
                askaril.SetForm = "Таблетка";
                askaril.SetActiveSubstance = "Сальбутамол";
                askaril.SetFlueType = "AH1N1";
                askaril.SetFlueSolution = "Лёгкие";
                Console.WriteLine(askaril.ToString());
            Console.WriteLine(Environment.NewLine);


            string text = "Антибиотики без пробиотков не вредны"; //Замена

            text = text.Replace("не", "--");
            Console.WriteLine(text);

            string proverb = "Каждый яД это лекАрство и кажДое лекарСтво это яд"; // регистр

            Console.WriteLine(proverb.ToLower());
            Console.WriteLine(proverb.ToUpper());

            string someText = "Billiards"; //Обрезка

            someText = someText.Trim();
            someText = someText.Trim(new char[] { 'B', 's' });
            Console.WriteLine(someText);

            string s1 = "Edelwiss"; //Сравнение
            string s2 = "Ost+Front";

            int result = String.Compare(s1, s2);
            if (result < 0)
            {
                Console.WriteLine("Строка s1 перед строкой s2");
            }
            else if (result > 0)
            {
                Console.WriteLine("Строка s1 стоит после строки s2");
            }
            else
            {
                Console.WriteLine("Строки s1 и s2 идентичны");
            }

            string ind = "Puppenjunge";
            Console.WriteLine(ind);
            char ch = 'p';
            int indexOfChar = ind.IndexOf(ch);
            Console.WriteLine($"Индекс первого вхождения символа { indexOfChar}");

            string subString = "ge";
            int indexOfSubstring = ind.IndexOf(subString);
            Console.WriteLine($"Индекс первого вхождения подстроки {indexOfSubstring}");

            Console.WriteLine();

            string oop = "OOP";
            string labO = "OOP";
            Console.WriteLine(Object.ReferenceEquals(oop,labO));

            Console.ReadKey();
        }
    }
}
