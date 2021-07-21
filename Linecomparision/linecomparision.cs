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
            double x3;
            double y3;
            double x4;
            double y4;
            double distance1;
            double distance2;

            Console.WriteLine("Enter the first co-ordinate");
            x1 = Convert.ToDouble(Console.ReadLine());
            y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the second co-ordinate");
            x2 = Convert.ToDouble(Console.ReadLine());
            y2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the third co-ordinate");
            x3 = Convert.ToDouble(Console.ReadLine());
            y3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the fourth co-ordinate");
            x4 = Convert.ToDouble(Console.ReadLine());
            y4 = Convert.ToDouble(Console.ReadLine());


            distance1 = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            Console.WriteLine("The length of the line one is:" + distance1);
            distance2 = Math.Sqrt(Math.Pow(x4 - x3, 2) + Math.Pow(y4 - y3, 2));
            Console.WriteLine("The length of the line two is :" + distance2);

            if (distance1 == distance2)
                Console.WriteLine("Both lines are equal");
            else
                Console.WriteLine("lines are unequal");
        }
    }
}

