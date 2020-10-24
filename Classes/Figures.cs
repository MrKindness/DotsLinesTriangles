using System;

namespace DotsLinesTriangles
{
    public abstract class ComplexFig 
    {
        public NamePoint[] points;
    }
    public class NamePoint
    {
        public int X, Y;
        public string Lit;
        public NamePoint(int x, int y, string Name)
        {
            X = x;
            Y = y;
            Lit = Name;
        }
    }
    public class Line : ComplexFig
    {
        public double dist { get; }
        public Line(NamePoint begin, NamePoint end)
        {
            points = new NamePoint[2];
            points[0] = begin;
            points[1] = end;
            dist = Math.Sqrt(Math.Pow(begin.X - end.X, 2) + Math.Pow(begin.Y - end.Y, 2));
        }
    }
    public class Triangle : ComplexFig
    {
        public Triangle(NamePoint first, NamePoint second, NamePoint third)
        {
            points = new NamePoint[3];
            points[0] = first;
            points[1] = second;
            points[2] = third;
        }
    }
}
