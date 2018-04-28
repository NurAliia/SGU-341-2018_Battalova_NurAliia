using System;

namespace Polymorphism_2.Bonus
{
    public class Apple : BonusAbstract
    {
        public Apple(Point point)
			:base(point, 100, 100)
		{
        }
        public override void EqualsCoordainaties(Boy player)
        {
            if (EqualsCoordainaties(player.Point))
            {
                Console.WriteLine("Success! Pick an apple ");
                LevelChange(player);
            }
        }
        public override void LevelChange(Boy player)
        {
            player.Health += 3;
        
            player.Intelligence += 2;
       
            player.Agility += 1;
        }
        public override string InfoObject()
        {
            return $"Coordinaties ({Point.X}, {Point.Y})";
        }
    }
}