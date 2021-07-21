using System;
using System.Collections.Generic;
using System.Text;

namespace Linecomparision
{
    class linecomparision
    {
        public void Length()
        {
            double x1;
            double y1;
            double x2;
            double y2;
            double distance;

            Console.WriteLine("Enter the first co-ordinate");
            x1 = Convert.ToDouble(Console.ReadLine());
            y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the second co-ordinate");
            x2 = Convert.ToDouble(Console.ReadLine());
            y2 = Convert.ToDouble(Console.ReadLine());

            distance = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            Console.WriteLine("The length of the line is:" + distance);

        }
    }
}

