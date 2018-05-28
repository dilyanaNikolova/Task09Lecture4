using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeAfter10YearsLecture4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a birth date ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            int currentAge = (DateTime.Now.Year - birthDate.Year);
            int ageInTenYears = currentAge + 10;

            Console.WriteLine(currentAge);
            Console.WriteLine(ageInTenYears);
        }
    }
}
