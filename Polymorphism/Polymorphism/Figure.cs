using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public abstract class Figure
    {
        protected Figure()
        { }
        public abstract string Draw();
    }
    public class Line :Figure
    {
        private Point first;
        private Point second;
        public Line(Point first, Point second)
        {
            this.first = first.Clone();
            this.second = second.Clone();
        }
        public override string Draw()
        {
            return $"Line coordinaties is ({first.X}, {first.Y}), ({second.X}, {second.Y})";
        }
    }
    public class Circle :Figure
    {
        public Point Center { get; set; }
        public Point Point { get; set; }

        public Circle(Point center, Point point)
        {
            Center = center.Clone();
            Point = point.Clone();
        }
      
        public override string Draw()
        {
            return $"Circle coordinaties is ({Center.X}, {Center.Y}), ({Point.X}, {Point.Y})";
        }
    }
    public class Ring :Figure
    {
        private Circle firstCircle;
        private Circle secondCircle;
        public Ring(Point center, Point first, Point second)
        {
            firstCircle = new Circle(center, first);
            secondCircle = new Circle(center,second);
        }
        public override string Draw()
        {
            return $"Ring coordinaties is  ({firstCircle.Center.X}, {firstCircle.Center.Y}), ({firstCircle.Point.X}, {firstCircle.Point.Y}), ({secondCircle.Point.X}, {secondCircle.Point.Y}) ";
        }
    }
    public class Rectangle : Figure
    {
        public Point First { get; set; }
        public Point Second { get; set; }
        public Rectangle(Point first, Point second)
        {
            First = first.Clone();
            Second = second.Clone();
        }
        public override string Draw()
        {
            return $"Rectangle coordinaties is ({First.X}, {First.Y}), ({Second.X}, {Second.Y})";
        }
    }
    public class Triangle : Figure
    {
        public Point First { get; set; }
        public Point Second { get; set; }
        public Point Third { get; set; }
        public Triangle(Point first, Point second, Point third)
        {
            First = first.Clone();
            Second = second.Clone();
            Third = third.Clone();
        }
        public override string Draw()
        {
            return $"Triangle coordinaties is ({First.X}, {First.Y}), ({Second.X}, {Second.Y}), ({Third.X}, {Third.Y})";
        }
    }
}
