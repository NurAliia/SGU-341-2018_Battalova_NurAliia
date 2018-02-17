using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{  
    class Triangle
    {
        private Point point1, point2, point3;
        private double? square = null;
        private double? perimeter = null;
        private double ab;
        private double bc;
        private double ac;
        public double Square
        {
            get
            {
                return (double)(this.square ?? (this.square = Math.Sqrt((double)perimeter /2*((double)perimeter /2 - ab)*
                    ((double)perimeter /2 - ac)*((double)perimeter /2 - bc))));                
            }                
        }
        public double Perimeter
        {
            get
            {
                return (double)(this.perimeter ?? (this.perimeter = ab + bc + ac));
            }
        }

        public Triangle(Point point1, Point point2, Point point3)
        {
            this.point1 = point1;
            this.point2 = point2;
            this.point3 = point3;
            ab = LengthSide(point1, point2);
            bc = LengthSide(point2, point3);
            ac = LengthSide(point1, point3);
            try
            {
                if (((point1.X == point2.X) && (point1.X == point3.X)) ||
                        ((point1.Y == point2.Y) && (point1.Y == point3.Y)))
                {
                    throw new Exception("No exist triangle");
                }
            }
            catch (Exception e)
            {
                RWStream stream = new RWStream();
                stream.WriteToFile(e.Message);
                throw e;
            }
        }
        public double LengthSide(Point a, Point b)
        {
            return Math.Sqrt(Math.Pow(a.X - b.X, 2) + Math.Pow(a.Y - b.Y, 2));
        }                   
    }
}
