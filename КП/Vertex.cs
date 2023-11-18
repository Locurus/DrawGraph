using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;
using System.Threading;

namespace КП
{
    public class Vertex : Control
    {
        static int countVertex = 0;
        public int pow;
        private Random randLocation = new Random();
        public Vertex()
        {
            Size = new Size(30, 30);
            BackColor = Color.Blue;
            countVertex++;
            Name = "V" + countVertex;
            Text = "V" + countVertex;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics graph = e.Graphics;
            RectangleF sirc = new RectangleF(0, 0, Width - 1, Height - 1);

            graph.Clear(Parent.BackColor);//Очищаем созданную фигуру
            graph.SmoothingMode = SmoothingMode.HighQuality;//Улучшаем качество
            graph.DrawEllipse(new Pen(Color.FromArgb(81, 26, 44)), sirc);//Рисование контура
            graph.FillEllipse(new SolidBrush(Color.FromArgb(81, 26, 44)), sirc);//Заполнение цветом
        }
    }
}