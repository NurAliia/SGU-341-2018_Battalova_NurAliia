using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_2.Bonus
{
    class Cherry : BonusAbstract
    {
        public Cherry(Point point)
			:base(point, 100, 100)
		{
        }
        public override void EqualsCoordainaties(Boy player)
        {
            if (EqualsCoordainaties(player.Point))
            {
                Console.WriteLine("Success! Pick an cherry ");
                LevelChange(player);
            }
        }
        public override void LevelChange(Boy player)
        {
            player.Health += 1;
        
            player.Intelligence += 2;
        
            player.Agility += 3;
        }

        public override string InfoObject()
        {
            return $"Coordinaties ({Point.X}, {Point.Y})";
        }
    }
}
