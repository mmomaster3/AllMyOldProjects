namespace teachers2
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Names = new System.Windows.Forms.RadioButton();
            this.withOutNames = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Start = new System.Windows.Forms.Button();
            this.BadTB = new System.Windows.Forms.TextBox();
            this.LoadPass = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.BadCounter = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.GoodCounter = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Stop = new System.Windows.Forms.Button();
            this.GoodsTB = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.withOutNames);
            this.groupBox1.Controls.Add(this.Names);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(132, 70);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // Names
            // 
            this.Names.AutoSize = true;
            this.Names.Checked = true;
            this.Names.Location = new System.Drawing.Point(18, 19);
            this.Names.Name = "Names";
            this.Names.Size = new System.Drawing.Size(58, 17);
            this.Names.TabIndex = 0;
            this.Names.TabStop = true;
            this.Names.Text = "Names";
            this.Names.UseVisualStyleBackColor = true;
            this.Names.CheckedChanged += new System.EventHandler(this.Names_CheckedChanged);
            // 
            // withOutNames
            // 
            this.withOutNames.AutoSize = true;
            this.withOutNames.Location = new System.Drawing.Point(18, 42);
            this.withOutNames.Name = "withOutNames";
            this.withOutNames.Size = new System.Drawing.Size(94, 17);
            this.withOutNames.TabIndex = 1;
            this.withOutNames.Text = "withOutNames";
            this.withOutNames.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Items.AddRange(new object[] {
            "Ржеутская Н.В.",
            "Дьячкова М.В.",
            "Василенко Е.Н.",
            "Багласова Е.B.",
            "Рагунович И.М.",
            "Вязович Е.А.",
            "Фалей Е.В.",
            "Борисова Т.И.",
            "Крюк Е.А.",
            "Герасимович Ю.А.",
            "Шеавярновская Я.И.",
            "Копытова А.Н.",
            "Клеменко Д.Ф.",
            "Каминская Л.А.",
            "Дудак В.Н.",
            "Ильина Т.С.",
            "Малец А.Н.",
            "Гальцова О.В.",
            "Суворова И.А.",
            "Лапченко Д.П."});
            this.comboBox1.Location = new System.Drawing.Point(150, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(30, 88);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(75, 23);
            this.Start.TabIndex = 2;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.button1_Click);
            // 
            // BadTB
            // 
            this.BadTB.Location = new System.Drawing.Point(150, 39);
            this.BadTB.Multiline = true;
            this.BadTB.Name = "BadTB";
            this.BadTB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.BadTB.Size = new System.Drawing.Size(269, 207);
            this.BadTB.TabIndex = 3;
            // 
            // LoadPass
            // 
            this.LoadPass.Location = new System.Drawing.Point(30, 137);
            this.LoadPass.Name = "LoadPass";
            this.LoadPass.Size = new System.Drawing.Size(75, 23);
            this.LoadPass.TabIndex = 4;
            this.LoadPass.Text = "LoadPass";
            this.LoadPass.UseVisualStyleBackColor = true;
            this.LoadPass.Click += new System.EventHandler(this.LoadPass_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Threads";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Txt|*.txt";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(79, 166);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(41, 20);
            this.numericUpDown1.TabIndex = 7;
            // 
            // BadCounter
            // 
            this.BadCounter.AutoSize = true;
            this.BadCounter.Location = new System.Drawing.Point(68, 203);
            this.BadCounter.Name = "BadCounter";
            this.BadCounter.Size = new System.Drawing.Size(13, 13);
            this.BadCounter.TabIndex = 8;
            this.BadCounter.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Bad:";
            // 
            // GoodCounter
            // 
            this.GoodCounter.AutoSize = true;
            this.GoodCounter.Location = new System.Drawing.Point(68, 221);
            this.GoodCounter.Name = "GoodCounter";
            this.GoodCounter.Size = new System.Drawing.Size(13, 13);
            this.GoodCounter.TabIndex = 10;
            this.GoodCounter.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Good:";
            // 
            // Stop
            // 
            this.Stop.Location = new System.Drawing.Point(30, 113);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(75, 23);
            this.Stop.TabIndex = 12;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // GoodsTB
            // 
            this.GoodsTB.Location = new System.Drawing.Point(425, 39);
            this.GoodsTB.Multiline = true;
            this.GoodsTB.Name = "GoodsTB";
            this.GoodsTB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.GoodsTB.Size = new System.Drawing.Size(269, 207);
            this.GoodsTB.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 258);
            this.Controls.Add(this.GoodsTB);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.GoodCounter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BadCounter);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoadPass);
            this.Controls.Add(this.BadTB);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton withOutNames;
        private System.Windows.Forms.RadioButton Names;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.TextBox BadTB;
        private System.Windows.Forms.Button LoadPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label BadCounter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label GoodCounter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.TextBox GoodsTB;
    }
}

