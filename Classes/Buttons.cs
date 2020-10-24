using System.Drawing;
using System.Windows.Forms;

namespace DotsLinesTriangles
{
    public class Button
    {
        protected GraphicManager GrpMngr;
        protected FigureManager FigManager;
        public virtual void onclick(ComboBox TrianglesTypeBox, ComboBox TrianglesBox, int DotsAmount, int Width, int Height) { }
        public Button(GraphicManager graphicManager, FigureManager figureManager)
        {
            GrpMngr = graphicManager;
            FigManager = figureManager;
        }
    }

    public class GenerateButton : Button
    {
        public GenerateButton(GraphicManager graphicManager, FigureManager figureManager) :
            base(graphicManager, figureManager) { }
        public override void onclick(ComboBox TrianglesTypeBox, ComboBox TrianglesBox, int DotsAmount, int Width, int Height)
        {
            TrianglesTypeBox.SelectedIndex = -1;
            TrianglesBox.Items.Clear();
            FigManager.GenerateDotsLinesTriangles(Width, Height, DotsAmount);
            GrpMngr.graphics.Clear(Color.FromArgb(255, 255, 255));
            if (FigManager.dots != null)
                foreach (var elem in FigManager.dots)
                    GrpMngr.DrawDot(elem);
        }
    }

    public class DispalyDotsButton : Button
    {
        public DispalyDotsButton(GraphicManager graphicManager, FigureManager figureManager) :
            base(graphicManager, figureManager) { }

        public override void onclick(ComboBox TrianglesTypeBox, ComboBox TrianglesBox, int DotsAmount, int Width, int Height)
        {
            GrpMngr.graphics.Clear(Color.FromArgb(255, 255, 255));
            if (FigManager.dots != null)
                foreach (var elem in FigManager.dots)
                    GrpMngr.DrawDot(elem);
        }
    }

    public class DisplayLinesButton : Button
    {
        public DisplayLinesButton(GraphicManager graphicManager, FigureManager figureManager) :
            base(graphicManager, figureManager) { }

        public override void onclick(ComboBox TrianglesTypeBox, ComboBox TrianglesBox, int DotsAmount, int Width, int Height)
        {
            if (FigManager.dots != null)
            {
                foreach (var elem in FigManager.lines)
                    GrpMngr.DrawLine(elem.Value.points[0], elem.Value.points[1]);

                foreach (NamePoint point in FigManager.dots)
                    GrpMngr.DrawDot(point);
            }
        }
    }

}
