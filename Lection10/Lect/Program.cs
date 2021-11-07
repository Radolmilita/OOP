using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Lect
{
    class Program
    {
        static void Main(string[] args)
        {
            Test someStudent = new Test("Valerij", 95.2, 0.45);
            Console.WriteLine(someStudent.ToString());
            Test studentBadMarks = new Test("Dmitrij", 40.5, 0.1);
            try
            {
                Console.WriteLine(studentBadMarks); 
            }
            finally {
                studentBadMarks.Dispose();
            }

            GC.Collect();

            string path = @"D:\OOP\L\forlect.txt";

            MemoryStream destination = new MemoryStream();

            using (FileStream source = File.Open(path, FileMode.Open))
            {

                Console.WriteLine($"Source length: {source.Length.ToString()}");
                source.CopyTo(destination);
            }

            Console.WriteLine($"Destination length: {destination.Length.ToString()}");

            SelfWork someWork = new SelfWork("Andy", 48.5);
            someWork.Dispose();
            Console.ReadKey();
        }
    }
}
