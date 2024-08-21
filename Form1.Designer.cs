namespace SeaBattle
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            button1 = new Button();
            textBox1 = new TextBox();
            button2 = new Button();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            button63 = new Button();
            button64 = new Button();
            dataGridView1 = new DataGridView();
            А = new DataGridViewTextBoxColumn();
            Б = new DataGridViewTextBoxColumn();
            В = new DataGridViewTextBoxColumn();
            Г = new DataGridViewTextBoxColumn();
            Д = new DataGridViewTextBoxColumn();
            Е = new DataGridViewTextBoxColumn();
            Ж = new DataGridViewTextBoxColumn();
            З = new DataGridViewTextBoxColumn();
            И = new DataGridViewTextBoxColumn();
            К = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(723, 65);
            button1.Name = "button1";
            button1.Size = new Size(131, 40);
            button1.TabIndex = 0;
            button1.Text = "ход";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(500, 392);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(175, 37);
            textBox1.TabIndex = 1;
            // 
            // button2
            // 
            button2.Location = new Point(723, 111);
            button2.Name = "button2";
            button2.Size = new Size(131, 40);
            button2.TabIndex = 2;
            button2.Text = "генерация";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(500, 65);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(88, 34);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "Вниз";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(500, 105);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(119, 34);
            checkBox2.TabIndex = 5;
            checkBox2.Text = "Удалить";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(500, 171);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(60, 34);
            radioButton1.TabIndex = 6;
            radioButton1.TabStop = true;
            radioButton1.Text = "х1";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(500, 205);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(60, 34);
            radioButton2.TabIndex = 7;
            radioButton2.TabStop = true;
            radioButton2.Text = "х2";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(500, 242);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(60, 34);
            radioButton3.TabIndex = 8;
            radioButton3.TabStop = true;
            radioButton3.Text = "х3";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(500, 276);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(60, 34);
            radioButton4.TabIndex = 9;
            radioButton4.TabStop = true;
            radioButton4.Text = "х4";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // button63
            // 
            button63.Location = new Point(723, 165);
            button63.Name = "button63";
            button63.Size = new Size(131, 40);
            button63.TabIndex = 10;
            button63.Text = "поставить";
            button63.UseVisualStyleBackColor = true;
            button63.Click += button63_Click;
            // 
            // button64
            // 
            button64.Location = new Point(686, 211);
            button64.Name = "button64";
            button64.Size = new Size(202, 40);
            button64.TabIndex = 11;
            button64.Text = "перерисовать";
            button64.UseVisualStyleBackColor = true;
            button64.Click += button64_Click;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.428572F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { А, Б, В, Г, Д, Е, Ж, З, И, К });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.428572F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Location = new Point(29, 56);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 72;
            dataGridView1.Size = new Size(441, 500);
            dataGridView1.TabIndex = 12;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // А
            // 
            А.HeaderText = "А";
            А.MinimumWidth = 9;
            А.Name = "А";
            А.Resizable = DataGridViewTriState.False;
            А.Width = 35;
            // 
            // Б
            // 
            Б.HeaderText = "Б";
            Б.MinimumWidth = 9;
            Б.Name = "Б";
            Б.Resizable = DataGridViewTriState.False;
            Б.Width = 35;
            // 
            // В
            // 
            В.HeaderText = "В";
            В.MinimumWidth = 9;
            В.Name = "В";
            В.Resizable = DataGridViewTriState.False;
            В.Width = 35;
            // 
            // Г
            // 
            Г.HeaderText = "Г";
            Г.MinimumWidth = 9;
            Г.Name = "Г";
            Г.Resizable = DataGridViewTriState.False;
            Г.Width = 35;
            // 
            // Д
            // 
            Д.HeaderText = "Д";
            Д.MinimumWidth = 9;
            Д.Name = "Д";
            Д.Resizable = DataGridViewTriState.False;
            Д.Width = 35;
            // 
            // Е
            // 
            Е.HeaderText = "Е";
            Е.MinimumWidth = 9;
            Е.Name = "Е";
            Е.Resizable = DataGridViewTriState.False;
            Е.Width = 35;
            // 
            // Ж
            // 
            Ж.HeaderText = "Ж";
            Ж.MinimumWidth = 9;
            Ж.Name = "Ж";
            Ж.Resizable = DataGridViewTriState.False;
            Ж.Width = 35;
            // 
            // З
            // 
            З.HeaderText = "З";
            З.MinimumWidth = 9;
            З.Name = "З";
            З.Resizable = DataGridViewTriState.False;
            З.Width = 35;
            // 
            // И
            // 
            И.HeaderText = "И";
            И.MinimumWidth = 9;
            И.Name = "И";
            И.Resizable = DataGridViewTriState.False;
            И.Width = 35;
            // 
            // К
            // 
            К.HeaderText = "К";
            К.MinimumWidth = 9;
            К.Name = "К";
            К.Resizable = DataGridViewTriState.False;
            К.Width = 35;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1322, 921);
            Controls.Add(dataGridView1);
            Controls.Add(button64);
            Controls.Add(button63);
            Controls.Add(radioButton4);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private Button button2;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private Button button63;
        private Button button64;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn А;
        private DataGridViewTextBoxColumn Б;
        private DataGridViewTextBoxColumn В;
        private DataGridViewTextBoxColumn Г;
        private DataGridViewTextBoxColumn Д;
        private DataGridViewTextBoxColumn Е;
        private DataGridViewTextBoxColumn Ж;
        private DataGridViewTextBoxColumn З;
        private DataGridViewTextBoxColumn И;
        private DataGridViewTextBoxColumn К;
    }
}
