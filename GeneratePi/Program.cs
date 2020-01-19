using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneratePi
{
    class Program
    {
        static void Main(string[] args)
        { 

            Console.WriteLine("Enter amount of tries / accuracy:");

            read();

        }

        static void read()
        {

            long acc = Convert.ToInt64(Console.ReadLine());

            decimal pi = calc(acc);

            Console.WriteLine("Final: " + pi);
            Console.WriteLine("Difference: " + Math.Abs(pi - (decimal) Math.PI));
            read();

        }

        static decimal calc(long accuracy)
        {
            //Using only random numbers (from 0 to 1), calculate pi.
            Random random = new Random();
            long inside = 0;
            long total = 0;

            for (int i = 0; i < accuracy; i++)
            {
                double x = random.NextDouble();
                double y = random.NextDouble();
                if (x * x + y * y <= 1)
                {
                    inside++;
                }
                total++;
            }

            Console.WriteLine("inside: " + inside + ", total: " + total);
            //From 0 to 1 represents the 1st quadrant, top right of circle and square.
            //Area of the 1st quadrant of circle = pi*r^2/4 = pi / 4
            //Area of the quarter of the square (total) = 4*r^2 /4 = r^2 = 1
            //inside : total = pi / 4 : 1
            //therefore inside : total = pi : 4
            //inside/total = x / 4
            //(inside/total)*4 = x
            decimal pi = ((decimal)inside / total) * 4;
            return pi;


        }
    }
}
