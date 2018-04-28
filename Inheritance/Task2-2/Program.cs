using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Man man = new Man("Ivan", 25, 80, 180);
            Console.WriteLine(man);
            Student st = new Student("Natasha", 18, 45, 160, 2015, 3, 341);
            Console.WriteLine(st);
        }
    }
}
