using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_2
{
    public class Boy : GameObject
    {
        public int Health { get; set; }
        public int Intelligence { get; set; }
        public int Agility { get; set; }


        public Boy(Point point)
			:base(point, 100, 100)
		{
            //подгружаем из файла здоровье..
        }
        public override string InfoObject()
        {
            return $"Health = {Health}, Intelligence = {Intelligence}, Agility = {Agility}";
        }
    }
}
