using System;
using System.Drawing;
using System.Windows.Forms;

namespace DotsLinesTriangles
{
    public partial class DotsLinesTriangles : Form
    {
        int eps = 20;
        bool Magnet = false;
        bool MousePressed = false;

        FigureManager FigManager;
        GraphicManager GrpMngr;
        Magnet magnet;
        Cursor MagnetCursor;
        Button[] buttons;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern IntPtr LoadCursorFromFile(string fileName);
        public DotsLinesTriangles()
        {
            InitializeComponent();
            GrpMngr = new GraphicManager(GraphicBox.CreateGraphics(), eps);
            FigManager = new FigureManager(eps);
            magnet = new Magnet(FigManager, GrpMngr, GraphicBox);
            MagnetCursor = new Cursor(LoadCursorFromFile(Application.StartupPath.Remove(Application.StartupPath.IndexOf("bin")) + @"icons\magnet.cur"));

            buttons = new Button[3];
            buttons[0] = new GenerateButton(GrpMngr, FigManager);
            buttons[1] = new DispalyDotsButton(GrpMngr, FigManager);
            buttons[2] = new DisplayLinesButton(GrpMngr, FigManager);
        }
        private void GraphicBox_SizeChanged(object sender, EventArgs e)
        {
            GrpMngr.graphics = GraphicBox.CreateGraphics();
            magnet.SetWidthHeight(GraphicBox.Width, GraphicBox.Height);
        }
        private void GenerateButt_Click(object sender, EventArgs e)
        {
            buttons[0].onclick(TrianglesTypeBox, TrianglesBox, (int)DotsAmount.Value, GraphicBox.Width, GraphicBox.Height);
            //TrianglesTypeBox.SelectedIndex = -1;
            //TrianglesBox.Items.Clear();
            //FigManager.GenerateDotsLinesTriangles(GraphicBox.Width, GraphicBox.Height, (int)DotsAmount.Value);
            //GrpMngr.graphics.Clear(Color.FromArgb(255, 255, 255));
            //if (FigManager.dots != null)
            //    foreach (var elem in FigManager.dots)
            //        GrpMngr.DrawDot(elem);
        }
        private void DisplayDotsButt_Click(object sender, EventArgs e) 
        {
            buttons[1].onclick(TrianglesTypeBox, TrianglesBox, (int)DotsAmount.Value, GraphicBox.Width, GraphicBox.Height);
            //GrpMngr.graphics.Clear(Color.FromArgb(255, 255, 255));
            //if(FigManager.dots != null)
            //    foreach (var elem in FigManager.dots)
            //        GrpMngr.DrawDot(elem);
        }
        private void DisplayLinesButt_Click(object sender, EventArgs e)
        {
            buttons[2].onclick(TrianglesTypeBox, TrianglesBox, (int)DotsAmount.Value, GraphicBox.Width, GraphicBox.Height);
            //if (FigManager.dots != null)
            //{
            //    foreach (var elem in FigManager.lines)
            //        GrpMngr.DrawLine(elem.Value.points[0], elem.Value.points[1]);

            //    foreach (NamePoint point in FigManager.dots)
            //        GrpMngr.DrawDot(point);
            //}
        }
        private void TrianglesTypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FigManager.dots != null && TrianglesTypeBox.SelectedIndex != -1)
                GrpMngr.DrawTriangles(FigManager.triangles[TrianglesTypeBox.SelectedIndex], FigManager.dots, TrianglesBox);
        }
        private void TrianglesBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            GrpMngr.DrawTriangle(TrianglesTypeBox.SelectedIndex, FigManager.triangles[TrianglesTypeBox.SelectedIndex][(string)TrianglesBox.SelectedItem]);
            foreach (NamePoint point in FigManager.dots)
                GrpMngr.DrawDot(point);
        }
        private void MagnetButt_Click(object sender, EventArgs e)
        {
            if (FigManager.dots != null) 
            {
                if (!Magnet)
                {
                    GrpMngr.graphics.Clear(Color.FromArgb(255, 255, 255));
                    foreach (var elem in FigManager.dots)
                        GrpMngr.DrawDot(elem);
                    
                    GraphicBox.Cursor = MagnetCursor;
                    Magnet = true;
                }
                else
                {
                    GraphicBox.Cursor = Cursors.Default;
                    Magnet = false;
                }
            }
        }
        private void GraphicBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (Magnet && MousePressed)
                magnet.SetTarget(e.Location);
        }
        private void GraphicBox_MouseDown(object sender, MouseEventArgs e)
        {
            MousePressed = true;
            if (Magnet)
            {
                magnet.StartWork();
                magnet.SetTarget(e.Location);
            }   
        }
        private void GraphicBox_MouseUp(object sender, MouseEventArgs e)
        {
            TrianglesTypeBox.SelectedIndex = -1;
            TrianglesBox.Items.Clear();
            MousePressed = false;
            if (Magnet)
            {
                magnet.StopWork();
                FigManager.GenerateLinesTriangles();
            }
        }
    }
}
