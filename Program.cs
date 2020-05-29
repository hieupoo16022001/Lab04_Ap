using System;
using System.Collections.Generic;
using System.Text;

namespace lab4
{
   public class Program
    {
        static void Main(String[] args)
        {
            Circle c1 = new Circle(2.45, "Blue", 23);
            Console.WriteLine("Circle before change" + c1.ToString());

            c1.PColor = "Red";
            c1.PWeight = 2.56;
            Console.WriteLine("Circle after change: " + c1.ToString());
            Console.ReadLine();
        }
    }
}
