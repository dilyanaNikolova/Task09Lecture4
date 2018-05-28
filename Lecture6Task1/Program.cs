using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture6Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            double max = num1;

            Console.WriteLine($"Num1: {num1}");
            Console.WriteLine($"Num2: {num2}");
            if (num1>num2)
            {
                num1 = num2;
                num2 = max;
            }
            Console.WriteLine($"Num1: {num1}");
            Console.WriteLine($"Num2: {num2}");
        }
    }
}
