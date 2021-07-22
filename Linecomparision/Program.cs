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
            if (line1 == line2)
            {
                Console.WriteLine("Length of two Lines are equals");
            }
            else
            {
                Console.WriteLine("Length of two lines are not equals");
            }

        }
    }
}