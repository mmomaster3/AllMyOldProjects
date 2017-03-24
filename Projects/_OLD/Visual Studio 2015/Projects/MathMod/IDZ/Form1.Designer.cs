namespace IDZ
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
            this.button1 = new System.Windows.Forms.Button();
            this.GoodLabel = new System.Windows.Forms.Label();
            this.BedLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(529, 389);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GoodLabel
            // 
            this.GoodLabel.AutoSize = true;
            this.GoodLabel.Location = new System.Drawing.Point(495, 9);
            this.GoodLabel.Name = "GoodLabel";
            this.GoodLabel.Size = new System.Drawing.Size(35, 13);
            this.GoodLabel.TabIndex = 1;
            this.GoodLabel.Text = "label1";
            // 
            // BedLabel
            // 
            this.BedLabel.AutoSize = true;
            this.BedLabel.Location = new System.Drawing.Point(495, 46);
            this.BedLabel.Name = "BedLabel";
            this.BedLabel.Size = new System.Drawing.Size(35, 13);
            this.BedLabel.TabIndex = 2;
            this.BedLabel.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 424);
            this.Controls.Add(this.BedLabel);
            this.Controls.Add(this.GoodLabel);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label GoodLabel;
        private System.Windows.Forms.Label BedLabel;
    }
}

