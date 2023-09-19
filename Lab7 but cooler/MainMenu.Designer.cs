namespace Lab7_but_cooler
{
    partial class MainMenu
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
            this.GuessButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.AuthorButton = new System.Windows.Forms.Button();
            this.StringButton = new System.Windows.Forms.Button();
            this.GameButton = new System.Windows.Forms.Button();
            this.ArraysButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Lab7_but_cooler.Properties.Resources.MainMenu;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(802, 451);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // GuessButton
            // 
            this.GuessButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.GuessButton.BackgroundImage = global::Lab7_but_cooler.Properties.Resources.ButtonBG;
            this.GuessButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GuessButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GuessButton.Font = new System.Drawing.Font("Fixedsys Excelsior 3.01", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GuessButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.GuessButton.Location = new System.Drawing.Point(12, 35);
            this.GuessButton.Name = "GuessButton";
            this.GuessButton.Size = new System.Drawing.Size(229, 46);
            this.GuessButton.TabIndex = 1;
            this.GuessButton.Text = "Угадай ответ";
            this.GuessButton.UseVisualStyleBackColor = false;
            this.GuessButton.Click += new System.EventHandler(this.GuessButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ExitButton.BackgroundImage = global::Lab7_but_cooler.Properties.Resources.ButtonBG;
            this.ExitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Fixedsys Excelsior 3.01", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ExitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ExitButton.Location = new System.Drawing.Point(12, 365);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(229, 48);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "Выход";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // AuthorButton
            // 
            this.AuthorButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.AuthorButton.BackgroundImage = global::Lab7_but_cooler.Properties.Resources.ButtonBG;
            this.AuthorButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AuthorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AuthorButton.Font = new System.Drawing.Font("Fixedsys Excelsior 3.01", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AuthorButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.AuthorButton.Location = new System.Drawing.Point(12, 299);
            this.AuthorButton.Name = "AuthorButton";
            this.AuthorButton.Size = new System.Drawing.Size(229, 48);
            this.AuthorButton.TabIndex = 3;
            this.AuthorButton.Text = "Об авторе";
            this.AuthorButton.UseVisualStyleBackColor = false;
            this.AuthorButton.Click += new System.EventHandler(this.AuthorButton_Click);
            // 
            // StringButton
            // 
            this.StringButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.StringButton.BackgroundImage = global::Lab7_but_cooler.Properties.Resources.ButtonBG;
            this.StringButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.StringButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StringButton.Font = new System.Drawing.Font("Fixedsys Excelsior 3.01", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StringButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.StringButton.Location = new System.Drawing.Point(12, 233);
            this.StringButton.Name = "StringButton";
            this.StringButton.Size = new System.Drawing.Size(229, 48);
            this.StringButton.TabIndex = 4;
            this.StringButton.Text = "Строки";
            this.StringButton.UseVisualStyleBackColor = false;
            this.StringButton.Click += new System.EventHandler(this.StringButton_Click);
            // 
            // GameButton
            // 
            this.GameButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.GameButton.BackgroundImage = global::Lab7_but_cooler.Properties.Resources.ButtonBG;
            this.GameButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GameButton.Font = new System.Drawing.Font("Fixedsys Excelsior 3.01", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GameButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.GameButton.Location = new System.Drawing.Point(12, 167);
            this.GameButton.Name = "GameButton";
            this.GameButton.Size = new System.Drawing.Size(229, 48);
            this.GameButton.TabIndex = 5;
            this.GameButton.Text = "Крестики-нолики";
            this.GameButton.UseVisualStyleBackColor = false;
            this.GameButton.Click += new System.EventHandler(this.GameButton_Click);
            // 
            // ArraysButton
            // 
            this.ArraysButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ArraysButton.BackgroundImage = global::Lab7_but_cooler.Properties.Resources.ButtonBG;
            this.ArraysButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ArraysButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ArraysButton.Font = new System.Drawing.Font("Fixedsys Excelsior 3.01", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ArraysButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ArraysButton.Location = new System.Drawing.Point(12, 101);
            this.ArraysButton.Name = "ArraysButton";
            this.ArraysButton.Size = new System.Drawing.Size(229, 48);
            this.ArraysButton.TabIndex = 6;
            this.ArraysButton.Text = "Массивы";
            this.ArraysButton.UseVisualStyleBackColor = false;
            this.ArraysButton.Click += new System.EventHandler(this.ArraysButton_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ArraysButton);
            this.Controls.Add(this.GameButton);
            this.Controls.Add(this.StringButton);
            this.Controls.Add(this.AuthorButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.GuessButton);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MainMenu";
            this.Text = "Лабораторная работа №8";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBox1;
        private Button GuessButton;
        private Button ExitButton;
        private Button AuthorButton;
        private Button StringButton;
        private Button GameButton;
        private Button ArraysButton;
    }
}