using System;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DotsLinesTriangles
{
    class Magnet
    {
        FigureManager FigureManager;
        GraphicManager Graphic;
        PictureBox Box;
        Point Target;
        CancellationTokenSource cancelTokenSource;
        CancellationToken token;
        Task MagnetTask = null;

        int Width;
        int Height;
        object TargetLocker = new object();
        object SizeLocker = new object();
        public Magnet(FigureManager figureManager, GraphicManager graphic, PictureBox PictBox)
        {
            FigureManager = figureManager;
            Graphic = graphic;
            Box = PictBox;
            Width = Box.Width;
            Height = Box.Height;
            cancelTokenSource = new CancellationTokenSource();
            token = cancelTokenSource.Token;
        }
        void MagnetWork(CancellationToken token) 
        {
            while (!token.IsCancellationRequested)
            {
                int X, Y;
                foreach (NamePoint dot in FigureManager.dots)
                {
                    X = dot.X;
                    Y = dot.Y;

                    lock (TargetLocker) 
                    {
                        if (Target.X > dot.X) X++;
                        else if (Target.X < dot.X) X--;

                        if (Target.Y > dot.Y) Y++;
                        else if (Target.Y < dot.Y) Y--;
                    }
                  
                    lock (SizeLocker) 
                    {
                        if (FigureManager.CheckDotMagnet(Width, Height, X, Y, dot.Lit))
                        {
                            dot.X = X;
                            dot.Y = Y;
                        }
                    }   
                }

                //Action action = () =>
                //{
                    Graphic.graphics.Clear(Color.FromArgb(255, 255, 255));
                    foreach (var elem in FigureManager.dots)
                        Graphic.DrawDot(elem);
                //};

                //if (Box.InvokeRequired)
                //    Box.Invoke(action);
                //else
                //    action();
            }
        }
        public void StartWork() 
        {
            if(MagnetTask == null || MagnetTask.Status == TaskStatus.RanToCompletion)
                MagnetTask = Task.Factory.StartNew(() => { MagnetWork(token); });
        }
        public void StopWork() 
        {
            if (MagnetTask.Status == TaskStatus.Running) 
            {
                cancelTokenSource.Cancel();
                MagnetTask.Wait();
                cancelTokenSource = new CancellationTokenSource();
                token = cancelTokenSource.Token;
            }
        }
        public void SetTarget(Point NewPoint) 
        {
            lock (TargetLocker) 
            {
                Target.X = NewPoint.X;
                Target.Y = NewPoint.Y;
            }
        }
        public void SetWidthHeight(int width, int height) 
        {
            lock (SizeLocker) 
            {
                Width = width;
                Height = height;
            }
        }
    }
}
