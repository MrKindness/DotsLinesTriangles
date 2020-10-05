using System;

namespace DotsLinesTriangles.Classes
{
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
    public class Line
    {
        public NamePoint Begin;
        public NamePoint End;
        public double dist { get; }
        public Line(NamePoint begin, NamePoint end)
        {
            Begin = begin;
            End = end;
            dist = Math.Sqrt(Math.Pow(Begin.X - End.X, 2) + Math.Pow(Begin.Y - End.Y, 2));
        }
        public override string ToString()
        {
            return Begin.Lit + End.Lit;
        }
    }
    public class Triangle
    {
        public NamePoint[] points;
        public Triangle(NamePoint first, NamePoint second, NamePoint third)
        {
            points = new NamePoint[3];
            points[0] = first;
            points[1] = second;
            points[2] = third;
        }
    }
}
