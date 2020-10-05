using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotsLinesTriangles.Classes
{
    class OldInterface
    {
        //using System;
        //using System.Collections.Generic;
        //using System.Drawing;
        //using System.Windows.Forms;

        //namespace DotsLinesTriangles
        //{
        //    public partial class DotsLinesTriangles : Form
        //    {
        //        int eps = 20;
        //        private string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        //        public List<NamePoint> dots = null;
        //        public Dictionary<string, Line> lines = new Dictionary<string, Line>();
        //        public Dictionary<int, Dictionary<string, Triangle>> triangles = new Dictionary<int, Dictionary<string, Triangle>>();

        //        Graphics g;
        //        SolidBrush BlackBrush = new SolidBrush(Color.Black);
        //        SolidBrush WhiteBrush = new SolidBrush(Color.White);
        //        Pen LinesPen = new Pen(Color.Blue, 2);
        //        Pen DotsPen = new Pen(Color.Black, 2);

        //        public DotsLinesTriangles()
        //        {
        //            InitializeComponent();
        //            g = GraphicBox.CreateGraphics();
        //        }
        //        private void GraphicBox_SizeChanged(object sender, EventArgs e)
        //        {
        //            g = GraphicBox.CreateGraphics();
        //        }
        //        private void DrawDot(NamePoint p)
        //        {
        //            g.DrawEllipse(DotsPen, p.X, p.Y, eps, eps);
        //            g.FillEllipse(WhiteBrush, p.X + 1, p.Y + 1, eps - 2, eps - 2);
        //            Font f = new Font("Consolas", 8, FontStyle.Bold);

        //            //g.PageUnit = GraphicsUnit.Pixel;
        //            //SizeF LSize = g.MeasureString(Litera.ToString(), f);

        //            g.DrawString(p.Lit, f, BlackBrush, new Point(p.X + 5, p.Y + 3));
        //        }
        //        private void DisplayDotsButt_Click(object sender, EventArgs e)
        //        {
        //            g.Clear(Color.FromArgb(255, 255, 255));
        //            if (dots != null)
        //                foreach (var elem in dots)
        //                    DrawDot(elem);
        //        }
        //        private bool CheckDot(int x, int y)
        //        {
        //            foreach (var elem in dots)
        //                if (Math.Sqrt(Math.Pow((x - elem.X), 2) + Math.Pow((y - elem.Y), 2)) < eps)
        //                    return false;
        //            return true;
        //        }
        //        private void GenerateButt_Click(object sender, EventArgs e)
        //        {
        //            dots = new List<NamePoint>((int)DotsAmount.Value);
        //            triangles.Clear();
        //            triangles.Add(0, new Dictionary<string, Triangle>());
        //            triangles.Add(1, new Dictionary<string, Triangle>());
        //            triangles.Add(2, new Dictionary<string, Triangle>());
        //            lines.Clear();
        //            g.Clear(Color.FromArgb(255, 255, 255));
        //            Random rand = new Random();
        //            NamePoint point;

        //            int X, Y;

        //            for (int i = 0; i < DotsAmount.Value; i++)
        //            {
        //                do
        //                {
        //                    X = rand.Next(GraphicBox.Width - eps);
        //                    Y = rand.Next(GraphicBox.Height - eps);
        //                }
        //                while (!CheckDot(X, Y));

        //                point = new NamePoint(X, Y, alphabet[i].ToString());
        //                dots.Add(point);
        //                DrawDot(point); ;
        //            }
        //        }
        //        private void DrawLine(NamePoint start, NamePoint end)
        //        {
        //            double R = eps / 2.0;
        //            g.DrawLine(LinesPen, (float)(start.X + R), (float)(start.Y + R), (float)(end.X + R), (float)(end.Y + R));
        //        }
        //        private void DisplayLinesButt_Click(object sender, EventArgs e)
        //        {
        //            if (dots != null)
        //            {
        //                if (lines.Count == 0)
        //                {
        //                    for (int i = 0; i < dots.Count; i++)
        //                    {
        //                        for (int j = i + 1; j < dots.Count; j++)
        //                        {
        //                            lines.Add(dots[i].Lit + dots[j].Lit, new Line(dots[i], dots[j]));
        //                            DrawLine(dots[i], dots[j]);
        //                        }
        //                    }
        //                }
        //                else
        //                {
        //                    foreach (var elem in lines)
        //                        DrawLine(elem.Value.Begin, elem.Value.End);
        //                }
        //                foreach (NamePoint point in dots)
        //                    DrawDot(point);
        //            }
        //        }
        //        private void DrawTriangles(Dictionary<string, Triangle> trs)
        //        {
        //            g.Clear(Color.FromArgb(255, 255, 255));
        //            foreach (KeyValuePair<string, Triangle> tr in trs)
        //            {
        //                DrawLine(tr.Value.First, tr.Value.Second);
        //                DrawLine(tr.Value.First, tr.Value.Third);
        //                DrawLine(tr.Value.Second, tr.Value.Third);
        //            }
        //            TrianglesBox.Items.Clear();
        //            foreach (KeyValuePair<string, Triangle> tr in trs)
        //            {
        //                TrianglesBox.Items.Add(tr.Key);
        //                DrawDot(tr.Value.First);
        //                DrawDot(tr.Value.Third);
        //                DrawDot(tr.Value.Second);
        //            }
        //        }
        //        private void DrawTriangle(int type, string name)
        //        {
        //            DrawLine(triangles[type][name].First, triangles[type][name].Second);
        //            DrawLine(triangles[type][name].First, triangles[type][name].Third);
        //            DrawLine(triangles[type][name].Second, triangles[type][name].Third);

        //            DrawDot(triangles[type][name].First);
        //            DrawDot(triangles[type][name].Second);
        //            DrawDot(triangles[type][name].Third);
        //        }
        //        private void TrianglesTypeBox_SelectedIndexChanged(object sender, EventArgs e)
        //        {
        //            if (dots != null)
        //            {
        //                if (lines.Count == 0)
        //                    DisplayLinesButt_Click(new object(), new EventArgs());
        //                if (triangles[0].Count == 0 && triangles[1].Count == 0 && triangles[2].Count == 0)
        //                {
        //                    for (int i = 0; i < dots.Count - 2; i++)
        //                    {
        //                        for (int j = i + 1; j < dots.Count - 1; j++)
        //                        {
        //                            for (int k = j + 1; k < dots.Count; k++)
        //                            {
        //                                Triangle tr = new Triangle(dots[i], dots[j], dots[k]);
        //                                string name = tr.First.Lit + tr.Second.Lit + tr.Third.Lit;
        //                                MessageBox.Show(name);
        //                                List<Line> tmp = new List<Line>(3);
        //                                tmp.Add(lines[dots[i].Lit + dots[j].Lit]);
        //                                tmp.Add(lines[dots[j].Lit + dots[k].Lit]);
        //                                tmp.Add(lines[dots[i].Lit + dots[k].Lit]);

        //                                tmp.Sort((Line a, Line b) =>
        //                                {
        //                                    if (a.dist > b.dist)
        //                                        return 1;
        //                                    else
        //                                        return 0;
        //                                });

        //                                if ((int)tmp[2].dist == (int)tmp[1].dist && (int)tmp[0].dist == (int)tmp[1].dist)
        //                                {
        //                                    triangles[1].Add(name, tr);
        //                                    triangles[2].Add(name, tr);
        //                                }
        //                                else
        //                                {
        //                                    if ((int)Math.Sqrt(Math.Pow(tmp[0].dist, 2) + Math.Pow(tmp[1].dist, 2)) == (int)tmp[2].dist)
        //                                        triangles[0].Add(name, tr);
        //                                    if ((int)tmp[2].dist == (int)tmp[1].dist ||
        //                                        (int)tmp[0].dist == (int)tmp[1].dist || (int)tmp[2].dist == (int)tmp[0].dist)
        //                                        triangles[1].Add(name, tr);
        //                                }
        //                            }
        //                        }
        //                    }
        //                }
        //                DrawTriangles(triangles[TrianglesTypeBox.SelectedIndex]);
        //            }
        //        }
        //        private void TrianglesBox_SelectedIndexChanged(object sender, EventArgs e)
        //        {
        //            DrawTriangle(TrianglesTypeBox.SelectedIndex, (string)TrianglesBox.SelectedItem);
        //        }
        //    }
        //}
    }
}
