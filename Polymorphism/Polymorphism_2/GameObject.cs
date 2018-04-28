using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_2
{
    public abstract class GameObject
    {
        private Point point;
        private int width; // Ширина игрового объекта.
        private int height; // Высота игрового объекта.
        
        public Point Point
        {
            get
            {
                return point;
            }
        }
               
        // Ширина игрового объекта. Свойство. Только для чтения.
        public int Width
        {
            get { return width; }
        }
        
        //Высота игрового объекта. Свойство. Только для чтения.
        public int Height
        {
            get { return height; }
        }

        public GameObject(Point point, int width, int height)
        {
            this.point = point;

            if (width <= 0)
            {
                throw new Exception("Неверное значение ширины. Используйте положительные значения.");
            }
            this.width = width;

            if (height <= 0)
            {
                throw new Exception("Неверное значение высоты. Используйте положительные значения.");
            }
            this.height = height;
        }
        public abstract string InfoObject();

        public bool EqualsCoordainaties(Point lastObjectGame)
        {
            return this.point.Equals(lastObjectGame);
        }
    }
}
