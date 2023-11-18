using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;

namespace КП
{
    public class Graph : Panel
    {
        public List<Vertex> vertex = new List<Vertex>();
        public List<Edges> edges = new List<Edges>();
        public bool IsDraw = false;

        public Graph()
        {
            Dock = DockStyle.Top;
            BackColor = Color.FromArgb(235, 223, 170);

            for (int i = 0; i < vertex.Count; i++)
                this.Controls.Add(vertex[i]);
        }

        public void DrawGraph()
        {
            if (IsDraw == true)
            {
                Graphics a = CreateGraphics();
                a.Clear(BackColor);

                IsDraw = false;
            }

            for (int i = 0; i < vertex.Count; i++)//Рисуем вершины
                Controls.Add(vertex[i]);

            for (int i = 0; i < edges.Count; i++)//Рисование рёбер
                edges[i].DrawEdge(this);

            IsDraw = true;
        }
    }
}