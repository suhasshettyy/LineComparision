using System;

namespace LineComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Line linecomp = new Line(15, 26, 32, 40);
            double line1 = linecomp.LengthOfLine();
            Line linecomp2 = new Line(28, 24, 30, 20);
            double line2 = linecomp2.LengthOfLine();
            Console.WriteLine(" The length of First line is : " + line1);
            Console.WriteLine(" The length of First line is : " + line2);
            if (line1.CompareTo(line2) == 0)
                Console.WriteLine("Both lines are equal");
            else if (line1.CompareTo(line2) > 0)
            {
                Console.WriteLine("length of first line is greater than second line");
            }
            else
            {
                Console.WriteLine("lines are not equal and length of first line is less than second line");
            }
        }
    }
}