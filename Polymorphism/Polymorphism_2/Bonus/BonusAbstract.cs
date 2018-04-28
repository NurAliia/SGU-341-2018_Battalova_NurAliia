using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_2.Bonus
{
    public abstract class BonusAbstract : GameObject, GameInterface
    {
        public BonusAbstract(Point point, int h, int w):base (point, h,w)
        {

        }
        public abstract void LevelChange(Boy player);
        public abstract void EqualsCoordainaties(Boy player);
        
    }
}
