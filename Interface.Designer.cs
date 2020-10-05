namespace DotsLinesTriangles
{
    partial class DotsLinesTriangles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DotsLinesTriangles));
            this.GenerateLabel = new System.Windows.Forms.Label();
            this.DotsAmount = new System.Windows.Forms.NumericUpDown();
            this.GenerateButt = new System.Windows.Forms.Button();
            this.DisplayDotsButt = new System.Windows.Forms.Button();
            this.MagnetButt = new System.Windows.Forms.Button();
            this.DisplayLinesButt = new System.Windows.Forms.Button();
            this.TrianglesLabel = new System.Windows.Forms.Label();
            this.TrianglesTypeBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TrianglesBox = new System.Windows.Forms.ComboBox();
            this.GraphicBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DotsAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GraphicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // GenerateLabel
            // 
            this.GenerateLabel.AutoSize = true;
            this.GenerateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.GenerateLabel.Location = new System.Drawing.Point(5, 13);
            this.GenerateLabel.Name = "GenerateLabel";
            this.GenerateLabel.Size = new System.Drawing.Size(188, 24);
            this.GenerateLabel.TabIndex = 0;
            this.GenerateLabel.Text = "Колличество точек:";
            // 
            // DotsAmount
            // 
            this.DotsAmount.Location = new System.Drawing.Point(199, 13);
            this.DotsAmount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DotsAmount.Maximum = new decimal(new int[] {
            26,
            0,
            0,
            0});
            this.DotsAmount.Name = "DotsAmount";
            this.DotsAmount.Size = new System.Drawing.Size(67, 26);
            this.DotsAmount.TabIndex = 1;
            // 
            // GenerateButt
            // 
            this.GenerateButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.GenerateButt.Location = new System.Drawing.Point(272, 7);
            this.GenerateButt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GenerateButt.Name = "GenerateButt";
            this.GenerateButt.Size = new System.Drawing.Size(205, 38);
            this.GenerateButt.TabIndex = 2;
            this.GenerateButt.Text = "Сгенерировать";
            this.GenerateButt.UseVisualStyleBackColor = true;
            this.GenerateButt.Click += new System.EventHandler(this.GenerateButt_Click);
            // 
            // DisplayDotsButt
            // 
            this.DisplayDotsButt.Location = new System.Drawing.Point(8, 59);
            this.DisplayDotsButt.Name = "DisplayDotsButt";
            this.DisplayDotsButt.Size = new System.Drawing.Size(131, 54);
            this.DisplayDotsButt.TabIndex = 3;
            this.DisplayDotsButt.Text = "Точки";
            this.DisplayDotsButt.UseVisualStyleBackColor = true;
            this.DisplayDotsButt.Click += new System.EventHandler(this.DisplayDotsButt_Click);
            // 
            // MagnetButt
            // 
            this.MagnetButt.Location = new System.Drawing.Point(282, 59);
            this.MagnetButt.Name = "MagnetButt";
            this.MagnetButt.Size = new System.Drawing.Size(135, 54);
            this.MagnetButt.TabIndex = 4;
            this.MagnetButt.Text = "Магнит";
            this.MagnetButt.UseVisualStyleBackColor = true;
            this.MagnetButt.Click += new System.EventHandler(this.MagnetButt_Click);
            // 
            // DisplayLinesButt
            // 
            this.DisplayLinesButt.Location = new System.Drawing.Point(145, 59);
            this.DisplayLinesButt.Name = "DisplayLinesButt";
            this.DisplayLinesButt.Size = new System.Drawing.Size(131, 54);
            this.DisplayLinesButt.TabIndex = 5;
            this.DisplayLinesButt.Text = "Линии";
            this.DisplayLinesButt.UseVisualStyleBackColor = true;
            this.DisplayLinesButt.Click += new System.EventHandler(this.DisplayLinesButt_Click);
            // 
            // TrianglesLabel
            // 
            this.TrianglesLabel.AutoSize = true;
            this.TrianglesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.TrianglesLabel.Location = new System.Drawing.Point(638, 57);
            this.TrianglesLabel.Name = "TrianglesLabel";
            this.TrianglesLabel.Size = new System.Drawing.Size(136, 24);
            this.TrianglesLabel.TabIndex = 6;
            this.TrianglesLabel.Text = "Треугольники";
            // 
            // TrianglesTypeBox
            // 
            this.TrianglesTypeBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.TrianglesTypeBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.TrianglesTypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TrianglesTypeBox.Items.AddRange(new object[] {
            "Прямоугольные",
            "Равнобедренные",
            "Равносторонние"});
            this.TrianglesTypeBox.Location = new System.Drawing.Point(423, 84);
            this.TrianglesTypeBox.Name = "TrianglesTypeBox";
            this.TrianglesTypeBox.Size = new System.Drawing.Size(203, 28);
            this.TrianglesTypeBox.TabIndex = 7;
            this.TrianglesTypeBox.SelectedIndexChanged += new System.EventHandler(this.TrianglesTypeBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(419, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Тип";
            // 
            // TrianglesBox
            // 
            this.TrianglesBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TrianglesBox.Location = new System.Drawing.Point(642, 84);
            this.TrianglesBox.Name = "TrianglesBox";
            this.TrianglesBox.Size = new System.Drawing.Size(203, 28);
            this.TrianglesBox.Sorted = true;
            this.TrianglesBox.TabIndex = 9;
            this.TrianglesBox.SelectedIndexChanged += new System.EventHandler(this.TrianglesBox_SelectedIndexChanged);
            // 
            // GraphicBox
            // 
            this.GraphicBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GraphicBox.BackColor = System.Drawing.Color.White;
            this.GraphicBox.Location = new System.Drawing.Point(9, 120);
            this.GraphicBox.Name = "GraphicBox";
            this.GraphicBox.Size = new System.Drawing.Size(836, 379);
            this.GraphicBox.TabIndex = 10;
            this.GraphicBox.TabStop = false;
            this.GraphicBox.SizeChanged += new System.EventHandler(this.GraphicBox_SizeChanged);
            this.GraphicBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GraphicBox_MouseDown);
            this.GraphicBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.GraphicBox_MouseMove);
            this.GraphicBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.GraphicBox_MouseUp);
            // 
            // DotsLinesTriangles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 508);
            this.Controls.Add(this.GraphicBox);
            this.Controls.Add(this.TrianglesBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TrianglesTypeBox);
            this.Controls.Add(this.TrianglesLabel);
            this.Controls.Add(this.DisplayLinesButt);
            this.Controls.Add(this.MagnetButt);
            this.Controls.Add(this.DisplayDotsButt);
            this.Controls.Add(this.GenerateButt);
            this.Controls.Add(this.DotsAmount);
            this.Controls.Add(this.GenerateLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(875, 555);
            this.Name = "DotsLinesTriangles";
            this.Text = "DotsLinesTriangles";
            ((System.ComponentModel.ISupportInitialize)(this.DotsAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GraphicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label GenerateLabel;
        private System.Windows.Forms.NumericUpDown DotsAmount;
        private System.Windows.Forms.Button GenerateButt;
        private System.Windows.Forms.Button DisplayDotsButt;
        private System.Windows.Forms.Button MagnetButt;
        private System.Windows.Forms.Button DisplayLinesButt;
        private System.Windows.Forms.Label TrianglesLabel;
        private System.Windows.Forms.ComboBox TrianglesTypeBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox TrianglesBox;
        private System.Windows.Forms.PictureBox GraphicBox;
    }
}

