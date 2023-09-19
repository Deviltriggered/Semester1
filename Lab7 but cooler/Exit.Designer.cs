namespace Lab7_but_cooler
{
    partial class Exit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Exit));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonYes = new System.Windows.Forms.Button();
            this.ButtonNo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Lab7_but_cooler.Properties.Resources.Exit;
            this.pictureBox1.Location = new System.Drawing.Point(-61, -37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(396, 149);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Fixedsys Excelsior 3.01", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Image = global::Lab7_but_cooler.Properties.Resources.LabelBG;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выйти из программы?";
            // 
            // ButtonYes
            // 
            this.ButtonYes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ButtonYes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonYes.BackgroundImage")));
            this.ButtonYes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonYes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonYes.Font = new System.Drawing.Font("Fixedsys Excelsior 3.01", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonYes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ButtonYes.Image = global::Lab7_but_cooler.Properties.Resources.LabelBG;
            this.ButtonYes.Location = new System.Drawing.Point(12, 42);
            this.ButtonYes.Name = "ButtonYes";
            this.ButtonYes.Size = new System.Drawing.Size(133, 37);
            this.ButtonYes.TabIndex = 2;
            this.ButtonYes.Text = "Да";
            this.ButtonYes.UseVisualStyleBackColor = false;
            this.ButtonYes.Click += new System.EventHandler(this.ButtonYes_Click);
            // 
            // ButtonNo
            // 
            this.ButtonNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ButtonNo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonNo.BackgroundImage")));
            this.ButtonNo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonNo.Font = new System.Drawing.Font("Fixedsys Excelsior 3.01", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ButtonNo.Image = global::Lab7_but_cooler.Properties.Resources.LabelBG;
            this.ButtonNo.Location = new System.Drawing.Point(158, 42);
            this.ButtonNo.Name = "ButtonNo";
            this.ButtonNo.Size = new System.Drawing.Size(133, 37);
            this.ButtonNo.TabIndex = 3;
            this.ButtonNo.Text = "Нет";
            this.ButtonNo.UseVisualStyleBackColor = false;
            this.ButtonNo.Click += new System.EventHandler(this.ButtonNo_Click);
            // 
            // Exit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 96);
            this.Controls.Add(this.ButtonNo);
            this.Controls.Add(this.ButtonYes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Exit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выйти?";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Button ButtonYes;
        private Button ButtonNo;
    }
}