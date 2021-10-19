﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public double CalculateResult(ITest hw)
        {
           return hw.CommonResult();
        }
        static void Main(string[] args)
        {
            Exam t1 = new Exam("Valerij", 175,0.5);
            t1.Coeficient = 0.45;
            Console.WriteLine($"{t1} Competition mark = {t1.CommonResult()}/100");
            Program pr = new Program();
            SelfWork sf = new SelfWork("Jane", 70, 1);
            sf.Coeficient = 0.8;
            double n = pr.CalculateResult(sf);
            Console.WriteLine($"result for h/w {n}");
            SelfWork [] homework = {
                    new SelfWork("Valerij", 100, 10), 
                    new SelfWork("Dima",99, 8), 
                    new SelfWork("Alex",70, 23) };
            Array.Sort(homework, new SelfWork("",4,4));
            foreach (SelfWork obj in homework)
                Console.WriteLine(obj);
            Console.WriteLine(Environment.NewLine);
            Exam[] mainExam = {
                    new Exam("Valerij", 100, 10),
                    new Exam("Dima",99, 8),
                    new Exam("Alex",70, 23) };
            Array.Sort(mainExam);
            foreach (Exam m in mainExam) {
                Console.WriteLine(m);
            }


            Console.ReadKey();
        }
    }
}
