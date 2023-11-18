using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace КП
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        }
        
        #region Форма
        //Кнопки на границе формы
        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void ButtonMinimezed_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //Перемещение формы
        private void BorderPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                BorderPanel.Capture = false;

                const int WM_NCLBUTTONDOWN = 0x00A1, HTCAPTION = 2;

                Message msg = Message.Create(this.Handle, WM_NCLBUTTONDOWN, new IntPtr(HTCAPTION), IntPtr.Zero);
                this.DefWndProc(ref msg);
            }
        }
        //Ввод последовательности, убираем подсказку
        private void inputNumbers_Click(object sender, EventArgs e)
        {
            if (inputNumbers.Text == "Введите последовательность")
            {
                inputNumbers.ForeColor = Color.Black;
                inputNumbers.Text = string.Empty;
            }
        }
        //Ввод последовательности, добавляем подсказку
        private void inputNumbers_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(inputNumbers.Text))
            {
                inputNumbers.ForeColor = Color.Gray;
                inputNumbers.Text = "Введите последовательность";
            }
        }
        #endregion

        //Генерация графа с заданнай последовательностью степеней
        private void buttonCreateGraph_Click(object sender, EventArgs e)
        {
            PanelException.Visible = false;
            string[] stringArray= (inputNumbers.Text).Split();
            int[] powerArray = new int[stringArray.Length];

            if (graph.IsDraw)
            {
                Graphics a = graph.CreateGraphics();
                a.Clear(graph.BackColor);

                graph.vertex[0].newCountVertex();
                graph.vertex.Clear();
                graph.edges.Clear();
                graph.Controls.Clear();
                graph.IsDraw = false;
            }

            for (int i = 0; i < stringArray.Length; i++)//Преобразуем из строки в массив чисел
                if (int.TryParse(stringArray[i].Trim(',', '.', ' '), out powerArray[i]))
                    powerArray[i] = int.Parse(stringArray[i].Trim(',', '.', ' '));
                else
                {
                    PanelException.Visible = true;
                    MessageException.Text = "\nНекорректный ввод";
                    return;
                }

            if (CheckPowers(powerArray))
                graph.DrawGraph();
            else
            {
                PanelException.Visible = true;
                MessageException.Text = "\nПростого графа не существует";
            }
        }
        private bool CheckPowers(int[] powArray)
        {
            if (powArray.Sum() % 2 == 1) return false;//Проверка условия о четности степеней
            if (powArray.Max() >= powArray.Length) return false;//Проверка условия о сравнении степеней
            Random randLocation = new Random();

            for (int i = 0; i < powArray.Length; i++)//Создание вершин и случайное их расположение
            {
                graph.vertex.Add(new Vertex());
                graph.vertex[i].Location = new Point(randLocation.Next(0, graph.Width - 30),
                                                     randLocation.Next(0, graph.Height - 30));
                graph.vertex[i].pow = powArray[i];
            }

            graph.vertex = SortVertexPow(graph.vertex);

            for (int i = 0; i < graph.vertex.Count - 1; i++)//Проход по каждой изымаемой вершине
            {
                if (graph.vertex[i].pow - 1 >= 0)//Если ненулевая вершина, то изимаем её
                {
                    for (int j = i + 1; graph.vertex[i].pow - 1 >= 0; j++)//Изъятие вершины
                    {
                        if (graph.vertex[j].pow - 1 >= 0 && graph.vertex[i].pow - 1 >= 0) //Если степень изымаемоё и других вершин не 0, то уменьшаем их и создаем ребро
                        {
                            graph.edges.Add(new Edges(graph.vertex[i].Location, graph.vertex[j].Location));
                            graph.vertex[j].pow--;
                            graph.vertex[i].pow--;
                        }
                        else if (j == graph.vertex.Count - 1) return false;//Если последняя неизымаемая вершина со степенью 0, то графа не существует
                        else continue;
                    }
                }
                else continue; //Если нулевая вершина, то пропускаем её
            }
            return true;
        }
        private List<Vertex> SortVertexPow(List<Vertex> vertex)
        {
            Vertex temp;

            for (int i = 1; i < vertex.Count; i++)
                for (int j = 0; j < vertex.Count - i; j++)
                {
                    if (vertex[j].pow < vertex[j + 1].pow)
                    {
                        temp = vertex[j];
                        vertex[j] = vertex[j + 1];
                        vertex[j + 1] = temp;
                    }
                }

            return vertex;
        }

        private void ButtonOkException_Click(object sender, EventArgs e)
        {
            PanelException.Visible = false;
        }
    }
}
