using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9Lecture6
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfVariable = Console.ReadLine();

            if (typeOfVariable == "integer")
            {
                int int1 = int.Parse(Console.ReadLine());
                Console.WriteLine(int1+1);
            }
            else if (typeOfVariable=="double")
            {
                double double1 = double.Parse(Console.ReadLine());
                Console.WriteLine(double1 + 1);
            }
            else if (typeOfVariable == "string")
            {
                string string1 = Console.ReadLine();
                Console.WriteLine(string1 + "*");
            }
            else
            {

            }
        }
    }
}
