using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_2.Obstacle
{
    class Tree: ObstacleAbstract
    {
        public Tree(Point point)
            : base(point, 100, 100)
        {
        }
        public override void EqualsCoordainaties(Boy player)
        {
            if (EqualsCoordainaties(player.Point))
            {
                Console.WriteLine("Turn arount it is  tree");            
                LevelChange(player);
            }
        }
        public override void LevelChange(Boy player)
        {          
            if (player.Agility > 1)
            {
                player.Agility -= 1;
            }
            else
            {
                throw new Exception("Game over");
            }
        }
        public override string InfoObject()
        {
            return $"Coordinaties ({Point.X}, {Point.Y})";
        }
    }
}
