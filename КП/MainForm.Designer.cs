namespace КП
{
    partial class Main_Form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            this.BorderPanel = new System.Windows.Forms.Panel();
            this.IconBorder = new System.Windows.Forms.PictureBox();
            this.ButtonMinimezed = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.inputNumbers = new System.Windows.Forms.TextBox();
            this.buttonCreateGraph = new System.Windows.Forms.Button();
            this.PanelException = new System.Windows.Forms.Panel();
            this.ButtonOkFormException = new System.Windows.Forms.Button();
            this.MessageException = new System.Windows.Forms.Label();
            this.graph = new КП.Graph();
            this.BorderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconBorder)).BeginInit();
            this.PanelException.SuspendLayout();
            this.SuspendLayout();
            // 
            // BorderPanel
            // 
            this.BorderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(33)))), ((int)(((byte)(52)))));
            this.BorderPanel.Controls.Add(this.IconBorder);
            this.BorderPanel.Controls.Add(this.ButtonMinimezed);
            this.BorderPanel.Controls.Add(this.CloseButton);
            this.BorderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.BorderPanel.Location = new System.Drawing.Point(0, 0);
            this.BorderPanel.Name = "BorderPanel";
            this.BorderPanel.Size = new System.Drawing.Size(568, 24);
            this.BorderPanel.TabIndex = 0;
            this.BorderPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BorderPanel_MouseDown);
            // 
            // IconBorder
            // 
            this.IconBorder.Dock = System.Windows.Forms.DockStyle.Left;
            this.IconBorder.Image = ((System.Drawing.Image)(resources.GetObject("IconBorder.Image")));
            this.IconBorder.Location = new System.Drawing.Point(0, 0);
            this.IconBorder.Name = "IconBorder";
            this.IconBorder.Size = new System.Drawing.Size(41, 24);
            this.IconBorder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IconBorder.TabIndex = 1;
            this.IconBorder.TabStop = false;
            // 
            // ButtonMinimezed
            // 
            this.ButtonMinimezed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(33)))), ((int)(((byte)(52)))));
            this.ButtonMinimezed.Dock = System.Windows.Forms.DockStyle.Right;
            this.ButtonMinimezed.FlatAppearance.BorderSize = 0;
            this.ButtonMinimezed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonMinimezed.Location = new System.Drawing.Point(520, 0);
            this.ButtonMinimezed.Name = "ButtonMinimezed";
            this.ButtonMinimezed.Size = new System.Drawing.Size(24, 24);
            this.ButtonMinimezed.TabIndex = 3;
            this.ButtonMinimezed.Text = "—";
            this.ButtonMinimezed.UseVisualStyleBackColor = false;
            this.ButtonMinimezed.Click += new System.EventHandler(this.ButtonMinimezed_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(33)))), ((int)(((byte)(52)))));
            this.CloseButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Location = new System.Drawing.Point(544, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(24, 24);
            this.CloseButton.TabIndex = 2;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // inputNumbers
            // 
            this.inputNumbers.Font = new System.Drawing.Font("Jost", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputNumbers.ForeColor = System.Drawing.Color.Gray;
            this.inputNumbers.Location = new System.Drawing.Point(12, 347);
            this.inputNumbers.Name = "inputNumbers";
            this.inputNumbers.Size = new System.Drawing.Size(260, 25);
            this.inputNumbers.TabIndex = 8;
            this.inputNumbers.Text = "Введите последовательность";
            this.inputNumbers.Click += new System.EventHandler(this.inputNumbers_Click);
            this.inputNumbers.Leave += new System.EventHandler(this.inputNumbers_Leave);
            // 
            // buttonCreateGraph
            // 
            this.buttonCreateGraph.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(139)))), ((int)(((byte)(174)))));
            this.buttonCreateGraph.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreateGraph.Font = new System.Drawing.Font("Jost", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCreateGraph.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonCreateGraph.Location = new System.Drawing.Point(302, 347);
            this.buttonCreateGraph.Margin = new System.Windows.Forms.Padding(0);
            this.buttonCreateGraph.Name = "buttonCreateGraph";
            this.buttonCreateGraph.Size = new System.Drawing.Size(254, 25);
            this.buttonCreateGraph.TabIndex = 9;
            this.buttonCreateGraph.Text = "Построить простой граф";
            this.buttonCreateGraph.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonCreateGraph.UseVisualStyleBackColor = false;
            this.buttonCreateGraph.Click += new System.EventHandler(this.buttonCreateGraph_Click);
            // 
            // PanelException
            // 
            this.PanelException.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(148)))), ((int)(((byte)(113)))));
            this.PanelException.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelException.Controls.Add(this.ButtonOkFormException);
            this.PanelException.Controls.Add(this.MessageException);
            this.PanelException.Location = new System.Drawing.Point(152, 86);
            this.PanelException.Name = "PanelException";
            this.PanelException.Size = new System.Drawing.Size(266, 122);
            this.PanelException.TabIndex = 3;
            this.PanelException.Visible = false;
            // 
            // ButtonOkFormException
            // 
            this.ButtonOkFormException.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(139)))), ((int)(((byte)(174)))));
            this.ButtonOkFormException.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonOkFormException.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ButtonOkFormException.Location = new System.Drawing.Point(80, 82);
            this.ButtonOkFormException.Name = "ButtonOkFormException";
            this.ButtonOkFormException.Size = new System.Drawing.Size(106, 23);
            this.ButtonOkFormException.TabIndex = 0;
            this.ButtonOkFormException.Text = "ОК";
            this.ButtonOkFormException.UseVisualStyleBackColor = false;
            this.ButtonOkFormException.Click += new System.EventHandler(this.ButtonOkException_Click);
            // 
            // MessageException
            // 
            this.MessageException.Dock = System.Windows.Forms.DockStyle.Top;
            this.MessageException.Font = new System.Drawing.Font("Jost", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MessageException.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MessageException.Location = new System.Drawing.Point(0, 0);
            this.MessageException.Name = "MessageException";
            this.MessageException.Size = new System.Drawing.Size(264, 67);
            this.MessageException.TabIndex = 1;
            this.MessageException.Text = "\r\nСообщение об ошибке";
            this.MessageException.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // graph
            // 
            this.graph.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(223)))), ((int)(((byte)(170)))));
            this.graph.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.graph.Dock = System.Windows.Forms.DockStyle.Top;
            this.graph.Location = new System.Drawing.Point(0, 24);
            this.graph.Name = "graph";
            this.graph.Size = new System.Drawing.Size(568, 316);
            this.graph.TabIndex = 7;
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(223)))), ((int)(((byte)(170)))));
            this.ClientSize = new System.Drawing.Size(568, 383);
            this.Controls.Add(this.PanelException);
            this.Controls.Add(this.buttonCreateGraph);
            this.Controls.Add(this.inputNumbers);
            this.Controls.Add(this.graph);
            this.Controls.Add(this.BorderPanel);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main_Form";
            this.Text = "MainForm";
            this.BorderPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IconBorder)).EndInit();
            this.PanelException.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel BorderPanel;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button ButtonMinimezed;
        private System.Windows.Forms.PictureBox IconBorder;
        private Graph graph;
        private System.Windows.Forms.TextBox inputNumbers;
        private System.Windows.Forms.Button buttonCreateGraph;
        private System.Windows.Forms.Panel PanelException;
        private System.Windows.Forms.Button ButtonOkFormException;
        private System.Windows.Forms.Label MessageException;
    }
}

