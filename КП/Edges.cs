using System.Drawing;
using System.Windows.Forms;

namespace КП
{
    public class Edges
    {
        public Point pointStart, pointEnd;
        private Pen pen = new Pen(Color.Black);
        public Edges(Point v1, Point v2)
        {
            pointStart = new Point(v1.X + 15, v1.Y + 15);
            pointEnd = new Point(v2.X + 15, v2.Y + 15);
            pen.Width = 2;
        }

        public void DrawEdge(Panel graphView)
        {
            Graphics Draw = graphView.CreateGraphics();
            Draw.DrawLine(pen, pointStart, pointEnd);
        }
    }
}
