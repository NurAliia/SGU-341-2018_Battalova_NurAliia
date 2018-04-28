using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_2
{
    public class Point
    {
        public double X { get; set; }
        public double Y { get; set; }
        public Point(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }
        public override bool Equals(Object lastPoint)
        {
            var tempPoint = lastPoint as Point;
            if (tempPoint == null)
            {
                return false;
            }
            return this.X == tempPoint.X && this.Y == tempPoint.Y;
        }

        public override int GetHashCode()
        {
            return this.X.GetHashCode() ^ this.Y.GetHashCode();
        }
    }
}
