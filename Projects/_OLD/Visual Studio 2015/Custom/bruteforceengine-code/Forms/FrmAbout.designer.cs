    partial class FrmAbout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAbout));
            this.AboutImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.AboutImage)).BeginInit();
            this.SuspendLayout();
            // 
            // AboutImage
            // 
            this.AboutImage.BackColor = System.Drawing.Color.Transparent;
            this.AboutImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AboutImage.ErrorImage = global::Engine_Brute.Properties.Resources.loading;
            this.AboutImage.InitialImage = global::Engine_Brute.Properties.Resources.loading;
            this.AboutImage.Location = new System.Drawing.Point(0, 0);
            this.AboutImage.Name = "AboutImage";
            this.AboutImage.Size = new System.Drawing.Size(500, 287);
            this.AboutImage.TabIndex = 0;
            this.AboutImage.TabStop = false;
            this.AboutImage.LoadCompleted += new System.ComponentModel.AsyncCompletedEventHandler(this.AboutImage_Load);
            this.AboutImage.Click += new System.EventHandler(this.AboutImage_Click);
            // 
            // FrmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(500, 287);
            this.Controls.Add(this.AboutImage);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About";
            this.Load += new System.EventHandler(this.FrmAbout_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AboutImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox AboutImage;
    }
