namespace Lab7_but_cooler
{
    partial class Strings
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GroupTasks = new System.Windows.Forms.GroupBox();
            this.LabelTask3 = new System.Windows.Forms.Label();
            this.ButtonTask3 = new System.Windows.Forms.RadioButton();
            this.ButtonTask2 = new System.Windows.Forms.RadioButton();
            this.ButtonTask1 = new System.Windows.Forms.RadioButton();
            this.BoxStr = new System.Windows.Forms.RichTextBox();
            this.LabelStr = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BoxResult = new System.Windows.Forms.TextBox();
            this.ButtonSolve = new System.Windows.Forms.Button();
            this.ButtonClear = new System.Windows.Forms.Button();
            this.LabelStr1 = new System.Windows.Forms.Label();
            this.BoxStr1 = new System.Windows.Forms.TextBox();
            this.BoxStr2 = new System.Windows.Forms.TextBox();
            this.LabelStr2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.GroupTasks.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Lab7_but_cooler.Properties.Resources.Strings;
            this.pictureBox1.Location = new System.Drawing.Point(-33, -5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(733, 374);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // GroupTasks
            // 
            this.GroupTasks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.GroupTasks.BackgroundImage = global::Lab7_but_cooler.Properties.Resources.ButtonBGbig;
            this.GroupTasks.Controls.Add(this.LabelTask3);
            this.GroupTasks.Controls.Add(this.ButtonTask3);
            this.GroupTasks.Controls.Add(this.ButtonTask2);
            this.GroupTasks.Controls.Add(this.ButtonTask1);
            this.GroupTasks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GroupTasks.Font = new System.Drawing.Font("Fixedsys Excelsior 3.01", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GroupTasks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.GroupTasks.Location = new System.Drawing.Point(257, 54);
            this.GroupTasks.Name = "GroupTasks";
            this.GroupTasks.Size = new System.Drawing.Size(383, 117);
            this.GroupTasks.TabIndex = 1;
            this.GroupTasks.TabStop = false;
            this.GroupTasks.Text = "Выбор задания";
            // 
            // LabelTask3
            // 
            this.LabelTask3.AutoSize = true;
            this.LabelTask3.Font = new System.Drawing.Font("Fixedsys Excelsior 3.01", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelTask3.Image = global::Lab7_but_cooler.Properties.Resources.LabelBG;
            this.LabelTask3.Location = new System.Drawing.Point(21, 94);
            this.LabelTask3.Name = "LabelTask3";
            this.LabelTask3.Size = new System.Drawing.Size(81, 20);
            this.LabelTask3.TabIndex = 3;
            this.LabelTask3.Text = "символов";
            this.LabelTask3.Click += new System.EventHandler(this.ButtonTask3_CheckedChanged);
            // 
            // ButtonTask3
            // 
            this.ButtonTask3.AutoSize = true;
            this.ButtonTask3.BackgroundImage = global::Lab7_but_cooler.Properties.Resources.LabelBG;
            this.ButtonTask3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonTask3.Font = new System.Drawing.Font("Fixedsys Excelsior 3.01", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonTask3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ButtonTask3.Location = new System.Drawing.Point(6, 74);
            this.ButtonTask3.Name = "ButtonTask3";
            this.ButtonTask3.Size = new System.Drawing.Size(332, 24);
            this.ButtonTask3.TabIndex = 2;
            this.ButtonTask3.TabStop = true;
            this.ButtonTask3.Text = "Посчитать кол-во первых одинаковых";
            this.ButtonTask3.UseVisualStyleBackColor = true;
            this.ButtonTask3.CheckedChanged += new System.EventHandler(this.ButtonTask3_CheckedChanged);
            // 
            // ButtonTask2
            // 
            this.ButtonTask2.AutoSize = true;
            this.ButtonTask2.BackgroundImage = global::Lab7_but_cooler.Properties.Resources.LabelBG;
            this.ButtonTask2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonTask2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ButtonTask2.Location = new System.Drawing.Point(6, 48);
            this.ButtonTask2.Name = "ButtonTask2";
            this.ButtonTask2.Size = new System.Drawing.Size(215, 24);
            this.ButtonTask2.TabIndex = 1;
            this.ButtonTask2.TabStop = true;
            this.ButtonTask2.Text = "Посчитать кол-во цифр";
            this.ButtonTask2.UseVisualStyleBackColor = true;
            this.ButtonTask2.CheckedChanged += new System.EventHandler(this.ButtonTask2_CheckedChanged);
            // 
            // ButtonTask1
            // 
            this.ButtonTask1.AutoSize = true;
            this.ButtonTask1.BackgroundImage = global::Lab7_but_cooler.Properties.Resources.LabelBG;
            this.ButtonTask1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonTask1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ButtonTask1.Location = new System.Drawing.Point(6, 22);
            this.ButtonTask1.Name = "ButtonTask1";
            this.ButtonTask1.Size = new System.Drawing.Size(215, 24);
            this.ButtonTask1.TabIndex = 0;
            this.ButtonTask1.TabStop = true;
            this.ButtonTask1.Text = "Посчитать кол-во слов";
            this.ButtonTask1.UseVisualStyleBackColor = true;
            this.ButtonTask1.CheckedChanged += new System.EventHandler(this.ButtonTask1_CheckedChanged);
            // 
            // BoxStr
            // 
            this.BoxStr.BackColor = System.Drawing.Color.Black;
            this.BoxStr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BoxStr.Font = new System.Drawing.Font("Fixedsys Excelsior 3.01", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BoxStr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BoxStr.Location = new System.Drawing.Point(12, 32);
            this.BoxStr.Name = "BoxStr";
            this.BoxStr.Size = new System.Drawing.Size(214, 255);
            this.BoxStr.TabIndex = 2;
            this.BoxStr.Text = "";
            // 
            // LabelStr
            // 
            this.LabelStr.AutoSize = true;
            this.LabelStr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.LabelStr.Font = new System.Drawing.Font("Fixedsys Excelsior 3.01", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelStr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.LabelStr.Image = global::Lab7_but_cooler.Properties.Resources.LabelBG;
            this.LabelStr.Location = new System.Drawing.Point(12, 9);
            this.LabelStr.Name = "LabelStr";
            this.LabelStr.Size = new System.Drawing.Size(72, 20);
            this.LabelStr.TabIndex = 3;
            this.LabelStr.Text = "Строка:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Fixedsys Excelsior 3.01", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Image = global::Lab7_but_cooler.Properties.Resources.LabelBG;
            this.label1.Location = new System.Drawing.Point(257, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Результат:";
            // 
            // BoxResult
            // 
            this.BoxResult.BackColor = System.Drawing.Color.Black;
            this.BoxResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BoxResult.Font = new System.Drawing.Font("Fixedsys Excelsior 3.01", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BoxResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BoxResult.Location = new System.Drawing.Point(257, 32);
            this.BoxResult.Name = "BoxResult";
            this.BoxResult.ReadOnly = true;
            this.BoxResult.Size = new System.Drawing.Size(383, 16);
            this.BoxResult.TabIndex = 5;
            // 
            // ButtonSolve
            // 
            this.ButtonSolve.BackgroundImage = global::Lab7_but_cooler.Properties.Resources.ButtonBG;
            this.ButtonSolve.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonSolve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSolve.Font = new System.Drawing.Font("Fixedsys Excelsior 3.01", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonSolve.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ButtonSolve.Location = new System.Drawing.Point(257, 177);
            this.ButtonSolve.Name = "ButtonSolve";
            this.ButtonSolve.Size = new System.Drawing.Size(175, 25);
            this.ButtonSolve.TabIndex = 6;
            this.ButtonSolve.Text = "Выполнить";
            this.ButtonSolve.UseVisualStyleBackColor = true;
            this.ButtonSolve.Click += new System.EventHandler(this.ButtonSolve_Click);
            // 
            // ButtonClear
            // 
            this.ButtonClear.BackgroundImage = global::Lab7_but_cooler.Properties.Resources.ButtonBG;
            this.ButtonClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonClear.Font = new System.Drawing.Font("Fixedsys Excelsior 3.01", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ButtonClear.Location = new System.Drawing.Point(465, 177);
            this.ButtonClear.Name = "ButtonClear";
            this.ButtonClear.Size = new System.Drawing.Size(175, 25);
            this.ButtonClear.TabIndex = 7;
            this.ButtonClear.Text = "Очистить";
            this.ButtonClear.UseVisualStyleBackColor = true;
            this.ButtonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // LabelStr1
            // 
            this.LabelStr1.AutoSize = true;
            this.LabelStr1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.LabelStr1.Font = new System.Drawing.Font("Fixedsys Excelsior 3.01", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelStr1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.LabelStr1.Image = global::Lab7_but_cooler.Properties.Resources.LabelBG;
            this.LabelStr1.Location = new System.Drawing.Point(257, 205);
            this.LabelStr1.Name = "LabelStr1";
            this.LabelStr1.Size = new System.Drawing.Size(90, 20);
            this.LabelStr1.TabIndex = 8;
            this.LabelStr1.Text = "Строка 1:";
            // 
            // BoxStr1
            // 
            this.BoxStr1.BackColor = System.Drawing.Color.Black;
            this.BoxStr1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BoxStr1.Font = new System.Drawing.Font("Fixedsys Excelsior 3.01", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BoxStr1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BoxStr1.Location = new System.Drawing.Point(257, 229);
            this.BoxStr1.Name = "BoxStr1";
            this.BoxStr1.Size = new System.Drawing.Size(383, 16);
            this.BoxStr1.TabIndex = 9;
            // 
            // BoxStr2
            // 
            this.BoxStr2.BackColor = System.Drawing.Color.Black;
            this.BoxStr2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BoxStr2.Font = new System.Drawing.Font("Fixedsys Excelsior 3.01", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BoxStr2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BoxStr2.Location = new System.Drawing.Point(257, 271);
            this.BoxStr2.Name = "BoxStr2";
            this.BoxStr2.Size = new System.Drawing.Size(383, 16);
            this.BoxStr2.TabIndex = 11;
            // 
            // LabelStr2
            // 
            this.LabelStr2.AutoSize = true;
            this.LabelStr2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.LabelStr2.Font = new System.Drawing.Font("Fixedsys Excelsior 3.01", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelStr2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.LabelStr2.Image = global::Lab7_but_cooler.Properties.Resources.LabelBG;
            this.LabelStr2.Location = new System.Drawing.Point(257, 248);
            this.LabelStr2.Name = "LabelStr2";
            this.LabelStr2.Size = new System.Drawing.Size(90, 20);
            this.LabelStr2.TabIndex = 10;
            this.LabelStr2.Text = "Строка 2:";
            // 
            // Strings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 306);
            this.Controls.Add(this.BoxStr2);
            this.Controls.Add(this.LabelStr2);
            this.Controls.Add(this.BoxStr1);
            this.Controls.Add(this.LabelStr1);
            this.Controls.Add(this.ButtonClear);
            this.Controls.Add(this.ButtonSolve);
            this.Controls.Add(this.BoxResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LabelStr);
            this.Controls.Add(this.BoxStr);
            this.Controls.Add(this.GroupTasks);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Strings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Работа со строками";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.GroupTasks.ResumeLayout(false);
            this.GroupTasks.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private GroupBox GroupTasks;
        private RadioButton ButtonTask1;
        private RadioButton ButtonTask2;
        private Label LabelTask3;
        private RadioButton ButtonTask3;
        private RichTextBox BoxStr;
        private Label LabelStr;
        private Label label1;
        private TextBox BoxResult;
        private Button ButtonSolve;
        private Button ButtonClear;
        private Label LabelStr1;
        private TextBox BoxStr1;
        private TextBox BoxStr2;
        private Label LabelStr2;
    }
}