using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_2.Monster
{
    class Wolf : MonsterAbstract
    {
        public Wolf(Point point)
            : base(point, 100, 100)
        {
        }
        public override void EqualsCoordainaties(Boy player)
        {
            if (EqualsCoordainaties(player.Point))
            {
                Console.WriteLine("Fail! Met a wolf");
                LevelChange(player);
            }
        }
        public override void LevelChange(Boy player)
        {
            if (player.Health > 2)
            {
                player.Health -= 2;
            }
            else
            {
                throw new Exception("Game over");
            }
       
            if (player.Intelligence > 1)
            {
                player.Intelligence -= 1;
            }
            else
            {
                throw new Exception("Game over");
            }
      
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