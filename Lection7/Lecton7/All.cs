using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecton7
{
    enum Month { January = 1, February, March, April, May, June, July, August, September, October, November, December };
    class All
    {
        public void PrintMonth(Month my) 
        {
            switch (my) {
                case Month.January: Console.WriteLine("First month");
                    break;
                case Month.February:
                    Console.WriteLine("Still winter");
                    break;
                case Month.March:
                    Console.WriteLine("There's spring");
                    break;
                case Month.April:
                    Console.WriteLine("That's 4-th month");
                    break;
                case Month.May:
                    Console.WriteLine("Summer is near");
                    break;
                case Month.June:
                    Console.WriteLine("Yeah");
                    break;
                case Month.July:
                    Console.WriteLine("I've passed one month of summer");
                    break;
                case Month.August:
                    Console.WriteLine("All good is getting over");
                    break;
                case Month.September:
                    Console.WriteLine("Still warm");
                    break;
                case Month.October:
                    Console.WriteLine("It's rainy. Again.");
                    break;
                case Month.November:
                    Console.WriteLine("May be, not the best");
                    break;
                case Month.December:
                    Console.WriteLine("Ah sh! Here we go again");
                    break;
            }    
        }
    }
}
