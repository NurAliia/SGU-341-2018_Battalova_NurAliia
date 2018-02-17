using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
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
        public static bool TryParse(string s1, string s2, out Point result)
        {
            double x;
            double y;
            result = null;
            if (Double.TryParse(s1, out x) && Double.TryParse(s2, out y))
            {
                result = new Point(x, y);
                return true;
            }
            return false;
        }
    }    

}
