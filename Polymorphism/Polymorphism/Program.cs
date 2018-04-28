using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure[] mas = new Figure[5];
            mas[0] = new Circle(new Point(2, 3), new Point(5, 0));
            mas[1] = new Rectangle(new Point(2, 2), new Point(45, 0));
            mas[2] = new Triangle(new Point(3, 3), new Point(4, 4), new Point(9, 9));
            mas[3] = new Line(new Point(0, 0), new Point(2, 5));
            mas[4] = new Ring(new Point(0, 0), new Point(3, 4), new Point(6, 9));
            foreach (Figure f in mas)
            {
                Console.WriteLine(f.Draw());              
            }
        }
    }
}
