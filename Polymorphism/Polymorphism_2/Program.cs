using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Polymorphism_2.Bonus;
using Polymorphism_2.Monster;
using Polymorphism_2.Obstacle;


namespace Polymorphism_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Game();
        }
        static void Game()
        {
            Boy boy = new Boy(new Point (1, 1));
            Apple apple1 = new Apple(new Point(3, 3));
            Cherry cherry = new Cherry(new Point (5, 4));
            Wolf wolf = new Wolf(new Point(4, 4));
            Stone stone = new Stone(new Point(5, 5));
            for (int i = 0; i < 10; i++)
            {
                apple1.EqualsCoordainaties(boy);
                cherry.EqualsCoordainaties(boy);
                wolf.EqualsCoordainaties(boy);
                stone.EqualsCoordainaties(boy);
                if (i / 2 == 0)
                {
                    wolf.Point.X += i;
                }
                else
                {

                    wolf.Point.Y += i;
                }
                boy.Point.X += i;
                boy.Point.Y += i;
            }
        }
    }
}
