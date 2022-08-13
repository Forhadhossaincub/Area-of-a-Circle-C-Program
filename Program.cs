using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_of_a_circle_Program
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double radius;
            double area;

            radius = 10.0;

            area = radius * radius * 3.1416;

            Console.WriteLine("Circle area is " + area);

            Console.ReadKey();
        }
    }
}
