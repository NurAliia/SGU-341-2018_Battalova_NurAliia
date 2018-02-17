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
        private Dictionary<int, KeyValuePair<int, int>> coordinates = new Dictionary<int, KeyValuePair<int, int>>();
        private double? square = null;
        private double? perimeter = null;
        public double Square
        {
            get
            {
                return (double)(this.square ?? (this.square = ((point1.X - point3.X) * (point2.Y - point3.Y) -
                (point2.X - point3.X) * (point1.Y - point3.Y)) / 2));
                
            }                
        }
        public double Perimeter
        {
            get
            {
                return (double)(this.perimeter ?? (this.perimeter = LengthSide(point1, point2) + LengthSide(point1, point3) + LengthSide(point3, point1)));
            }
        }

        public Triangle(Point point1, Point point2, Point point3)
        {
            this.point1 = point1;
            this.point2 = point2;
            this.point3 = point3;
        }

        public double LengthSide(Point a, Point b)
        {
            return Math.Sqrt(Math.Pow(a.X - b.X, 2) + Math.Pow(a.Y - b.Y, 2));
        }                   
    }
}
