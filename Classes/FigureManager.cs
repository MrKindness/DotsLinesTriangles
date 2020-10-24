using System;
using System.Collections.Generic;
using System.Drawing;

namespace DotsLinesTriangles
{
    public class FigureManager
    {
        int eps;
        string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        public List<NamePoint> dots = null;
        public Dictionary<string, Line> lines = new Dictionary<string, Line>();
        public Dictionary<int, Dictionary<string, Triangle>> triangles = new Dictionary<int, Dictionary<string, Triangle>>();
        List<Line> tmp = new List<Line>(3);
        Triangle tr;
        public FigureManager(int Eps) 
        {
            eps = Eps;
            triangles.Add(0, new Dictionary<string, Triangle>());
            triangles.Add(1, new Dictionary<string, Triangle>());
            triangles.Add(2, new Dictionary<string, Triangle>());
        }
        bool CheckDot(int x, int y)
        {
            foreach (var elem in dots)
                if (Math.Sqrt(Math.Pow(x - elem.X, 2) + Math.Pow(y - elem.Y, 2)) < eps)
                    return false;
            return true;
        }
        public bool CheckDotMagnet(int Width, int Height, int x, int y, string Lit) 
        {
            foreach (var elem in dots)
                if(elem.Lit != Lit)
                    if (x < 0 || y < 0 || x > Width-eps || y > Height-eps || 
                        Math.Sqrt(Math.Pow(x - elem.X, 2) + Math.Pow(y - elem.Y, 2)) < eps)
                        return false;
            return true;
        }
        void GenerateTriangle(NamePoint first, NamePoint second, NamePoint third)
        {
            tr = new Triangle(first, second, third);
            string name = first.Lit + second.Lit + third.Lit;
            tmp.Clear();
            tmp.Add(lines[first.Lit + second.Lit]);
            tmp.Add(lines[first.Lit + third.Lit]);
            tmp.Add(lines[second.Lit + third.Lit]);

            tmp.Sort((Line a, Line b) =>
            {
                if (a.dist > b.dist) return 1;
                else return 0;
            });

            if ((int)tmp[2].dist == (int)tmp[1].dist && (int)tmp[0].dist == (int)tmp[1].dist)
            {
                triangles[1].Add(name, tr);
                triangles[2].Add(name, tr);
            }
            else
            {
                if ((int)Math.Sqrt(Math.Pow(tmp[0].dist, 2) + Math.Pow(tmp[1].dist, 2)) == (int)tmp[2].dist)
                    triangles[0].Add(name, tr);
                if ((int)tmp[2].dist == (int)tmp[1].dist ||
                    (int)tmp[0].dist == (int)tmp[1].dist || (int)tmp[2].dist == (int)tmp[0].dist)
                    triangles[1].Add(name, tr);
            }
        }
        public void GenerateDotsLinesTriangles(int Width, int Height, int amount) 
        {
            dots = new List<NamePoint>(amount);
            lines.Clear();
            triangles[0].Clear();
            triangles[1].Clear();
            triangles[2].Clear();

            Random rand = new Random();
            NamePoint point;
        
            int X, Y;
            for (int i = 0; i < amount; i++)
            {
                //создаем точку
                do
                {
                    X = rand.Next(Width - eps);
                    Y = rand.Next(Height - eps);
                }
                while (!CheckDot(X, Y));

                point = new NamePoint(X, Y, alphabet[i].ToString());
                dots.Add(point);

                //создаем все возможные на данный момент линии
                foreach (NamePoint dot in dots)
                    if(dot.Lit != point.Lit)
                        lines.Add(dot.Lit + point.Lit, new Line(dot, point));

                //создаем все возможные на данный момент треугольники
                foreach (var elem in lines)
                    if (elem.Key.IndexOf(point.Lit) == -1)
                        GenerateTriangle(elem.Value.points[0], elem.Value.points[1], point);
            }
        }
        public void GenerateLinesTriangles()
        {
            lines.Clear();
            triangles[0].Clear();
            triangles[1].Clear();
            triangles[2].Clear();

            for (int i = 0; i < dots.Count; i++)
                for (int j = i + 1; j < dots.Count; j++)
                    lines.Add(dots[i].Lit + dots[j].Lit, new Line(dots[i], dots[j]));

            for (int i = 0; i < dots.Count - 2; i++)
                for (int j = i + 1; j < dots.Count - 1; j++)
                    for (int k = j + 1; k < dots.Count; k++)
                        GenerateTriangle(dots[i], dots[j], dots[k]);  
        }
    }
}
