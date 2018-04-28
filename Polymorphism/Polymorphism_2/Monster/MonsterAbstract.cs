using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_2.Monster
{
    public abstract class MonsterAbstract : GameObject, GameInterface
    {
        public MonsterAbstract(Point point, int h, int w):base (point, h,w)
        {

        }
        public abstract void LevelChange(Boy player);
        public abstract void EqualsCoordainaties(Boy player);
    }
}
