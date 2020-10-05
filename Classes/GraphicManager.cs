using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DotsLinesTriangles.Classes
{
    class GraphicManager
    {
        int eps;
        float eps2;
        public Graphics graphics;
        public SolidBrush BlackBrush = new SolidBrush(Color.Black);
        SolidBrush WhiteBrush = new SolidBrush(Color.White);
        SolidBrush[] TrianglesBrushes =  { 
            new SolidBrush(Color.FromArgb(255, 253, 193, 175)),
            new SolidBrush(Color.FromArgb(255, 175, 190, 253)),
            new SolidBrush(Color.FromArgb(255, 175, 253, 181)) };    
        Pen LinesPen = new Pen(Color.Blue, 2);
        Pen DotsPen = new Pen(Color.Black, 2);
        Font f = new Font("Consolas", 8, FontStyle.Bold);

        public GraphicManager(Graphics graphics, int eps) 
        {
            this.eps = eps;
            this.graphics = graphics;
            eps2 = eps / 2;
        }
        public void DrawDot(NamePoint p)
        {
            graphics.DrawEllipse(DotsPen, p.X, p.Y, eps, eps);
            graphics.FillEllipse(WhiteBrush, p.X + 1, p.Y + 1, eps - 2, eps - 2);

            //g.PageUnit = GraphicsUnit.Pixel;
            //SizeF LSize = g.MeasureString(Litera.ToString(), f);

            graphics.DrawString(p.Lit, f, BlackBrush, new Point(p.X + 5, p.Y + 3));
        }
        public void DrawLine(NamePoint start, NamePoint end)
        {
            graphics.DrawLine(LinesPen, start.X + eps2, start.Y + eps2, end.X + eps2, end.Y + eps2);
        }
        public void DrawTriangle(int type, Triangle tr)
        {
            Point[] ps = new Point[] {
                new Point(tr.points[0].X + (int)eps2, tr.points[0].Y + (int)eps2),
                new Point(tr.points[1].X + (int)eps2, tr.points[1].Y + (int)eps2),
                new Point(tr.points[2].X + (int)eps2, tr.points[2].Y + (int)eps2) };
            graphics.FillPolygon(TrianglesBrushes[type], ps);

            DrawLine(tr.points[0], tr.points[1]);
            DrawLine(tr.points[0], tr.points[2]);
            DrawLine(tr.points[1], tr.points[2]);
        }
        public void DrawTriangles(Dictionary<string, Triangle> trs, List<NamePoint> dots, ComboBox TrianglesBox)
        {
            graphics.Clear(Color.FromArgb(255, 255, 255));
            TrianglesBox.BeginUpdate();
            TrianglesBox.Items.Clear();
            foreach (KeyValuePair<string, Triangle> tr in trs)
            {
                TrianglesBox.Items.Add(tr.Key);
                DrawLine(tr.Value.points[0], tr.Value.points[2]);
                DrawLine(tr.Value.points[0], tr.Value.points[1]);
                DrawLine(tr.Value.points[1], tr.Value.points[2]);
            }
            TrianglesBox.EndUpdate();
            foreach (var elem in dots)
                DrawDot(elem);
        }
    }
}
