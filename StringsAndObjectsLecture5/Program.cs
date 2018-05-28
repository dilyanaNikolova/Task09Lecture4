using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsAndObjectsLecture5
{
    class Program
    {
        static void Main(string[] args)
        {
            string hello = "Hello";
            string world = "world";
            object concatinated = hello + " " + world;
            string obj = (string)concatinated;

            Console.WriteLine(hello);
            Console.WriteLine(world);
            Console.WriteLine(concatinated);
            Console.WriteLine(obj);



        }
    }
}
