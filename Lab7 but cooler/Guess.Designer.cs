namespace Lab7_but_cooler
{
    partial class Guess
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Guess));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.LabelA = new System.Windows.Forms.Label();
            this.BoxA = new System.Windows.Forms.TextBox();
            this.BoxB = new System.Windows.Forms.TextBox();
            this.LabelB = new System.Windows.Forms.Label();
            this.LabelAns = new System.Windows.Forms.Label();
            this.BoxAns = new System.Windows.Forms.TextBox();
            this.ButtonAB = new System.Windows.Forms.Button();
            this.ButtonClear = new System.Windows.Forms.Button();
            this.ButtonTry = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-6, -105);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(715, 325);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.BackgroundImage = global::Lab7_but_cooler.Properties.Resources.ButtonBGbig;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Image = global::Lab7_but_cooler.Properties.Resources.Function;
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(317, 150);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // LabelA
            // 
            this.LabelA.AutoSize = true;
            this.LabelA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.LabelA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LabelA.Font = new System.Drawing.Font("Fixedsys Excelsior 3.01", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.LabelA.Image = global::Lab7_but_cooler.Properties.Resources.LabelBG;
            this.LabelA.Location = new System.Drawing.Point(335, 12);
            this.LabelA.Name = "LabelA";
            this.LabelA.Size = new System.Drawing.Size(252, 22);
            this.LabelA.TabIndex = 2;
            this.LabelA.Text = "Значение переменной a:";
            // 
            // BoxA
            // 
            this.BoxA.BackColor = System.Drawing.Color.Black;
            this.BoxA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BoxA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BoxA.Location = new System.Drawing.Point(335, 37);
            this.BoxA.Name = "BoxA";
            this.BoxA.Size = new System.Drawing.Size(252, 16);
            this.BoxA.TabIndex = 3;
            // 
            // BoxB
            // 
            this.BoxB.BackColor = System.Drawing.Color.Black;
            this.BoxB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BoxB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BoxB.Location = new System.Drawing.Point(335, 88);
            this.BoxB.Name = "BoxB";
            this.BoxB.Size = new System.Drawing.Size(252, 16);
            this.BoxB.TabIndex = 5;
            // 
            // LabelB
            // 
            this.LabelB.AutoSize = true;
            this.LabelB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.LabelB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LabelB.Font = new System.Drawing.Font("Fixedsys Excelsior 3.01", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.LabelB.Image = global::Lab7_but_cooler.Properties.Resources.LabelBG;
            this.LabelB.Location = new System.Drawing.Point(335, 63);
            this.LabelB.Name = "LabelB";
            this.LabelB.Size = new System.Drawing.Size(252, 22);
            this.LabelB.TabIndex = 4;
            this.LabelB.Text = "Значение переменной b:";
            // 
            // LabelAns
            // 
            this.LabelAns.AutoSize = true;
            this.LabelAns.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.LabelAns.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LabelAns.Font = new System.Drawing.Font("Fixedsys Excelsior 3.01", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelAns.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.LabelAns.Image = global::Lab7_but_cooler.Properties.Resources.LabelBG;
            this.LabelAns.Location = new System.Drawing.Point(335, 114);
            this.LabelAns.Name = "LabelAns";
            this.LabelAns.Size = new System.Drawing.Size(120, 22);
            this.LabelAns.TabIndex = 6;
            this.LabelAns.Text = "Ваш ответ:";
            // 
            // BoxAns
            // 
            this.BoxAns.BackColor = System.Drawing.Color.Black;
            this.BoxAns.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BoxAns.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BoxAns.Location = new System.Drawing.Point(335, 139);
            this.BoxAns.Name = "BoxAns";
            this.BoxAns.Size = new System.Drawing.Size(120, 16);
            this.BoxAns.TabIndex = 7;
            // 
            // ButtonAB
            // 
            this.ButtonAB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ButtonAB.BackgroundImage = global::Lab7_but_cooler.Properties.Resources.ButtonBGbig;
            this.ButtonAB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ButtonAB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAB.Font = new System.Drawing.Font("Fixedsys Excelsior 3.01", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonAB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ButtonAB.Location = new System.Drawing.Point(605, 12);
            this.ButtonAB.Name = "ButtonAB";
            this.ButtonAB.Size = new System.Drawing.Size(91, 48);
            this.ButtonAB.TabIndex = 8;
            this.ButtonAB.Text = "Посчитать";
            this.ButtonAB.UseVisualStyleBackColor = false;
            this.ButtonAB.Click += new System.EventHandler(this.ButtonAB_Click);
            // 
            // ButtonClear
            // 
            this.ButtonClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ButtonClear.BackgroundImage = global::Lab7_but_cooler.Properties.Resources.ButtonBGbig;
            this.ButtonClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ButtonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonClear.Font = new System.Drawing.Font("Fixedsys Excelsior 3.01", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ButtonClear.Location = new System.Drawing.Point(605, 63);
            this.ButtonClear.Name = "ButtonClear";
            this.ButtonClear.Size = new System.Drawing.Size(91, 48);
            this.ButtonClear.TabIndex = 9;
            this.ButtonClear.Text = "Сбросить";
            this.ButtonClear.UseVisualStyleBackColor = false;
            this.ButtonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // ButtonTry
            // 
            this.ButtonTry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ButtonTry.BackgroundImage = global::Lab7_but_cooler.Properties.Resources.ButtonBGbig;
            this.ButtonTry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ButtonTry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonTry.Font = new System.Drawing.Font("Fixedsys Excelsior 3.01", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonTry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ButtonTry.Location = new System.Drawing.Point(605, 114);
            this.ButtonTry.Name = "ButtonTry";
            this.ButtonTry.Size = new System.Drawing.Size(91, 48);
            this.ButtonTry.TabIndex = 10;
            this.ButtonTry.Text = "Отгадать";
            this.ButtonTry.UseVisualStyleBackColor = false;
            this.ButtonTry.Click += new System.EventHandler(this.ButtonTry_Click);
            // 
            // Guess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 181);
            this.Controls.Add(this.ButtonTry);
            this.Controls.Add(this.ButtonClear);
            this.Controls.Add(this.ButtonAB);
            this.Controls.Add(this.BoxAns);
            this.Controls.Add(this.LabelAns);
            this.Controls.Add(this.BoxB);
            this.Controls.Add(this.LabelB);
            this.Controls.Add(this.BoxA);
            this.Controls.Add(this.LabelA);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Guess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Угадай ответ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label LabelA;
        private TextBox BoxA;
        private TextBox BoxB;
        private Label LabelB;
        private Label LabelAns;
        private TextBox BoxAns;
        private Button ButtonAB;
        private Button ButtonClear;
        private Button ButtonTry;
    }
}