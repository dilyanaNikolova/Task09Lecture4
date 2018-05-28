using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3Lecture6
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int num4 = int.Parse(Console.ReadLine());
            int num5 = int.Parse(Console.ReadLine());
            int big = Math.Max(num1, num2);
            int bigger = Math.Max(big, num3);
            int biggest = Math.Max(bigger, num4);
            int theBiggest = Math.Max(biggest, num5);

            Console.WriteLine($"The biggest number is {theBiggest}");
        }
    }
}
