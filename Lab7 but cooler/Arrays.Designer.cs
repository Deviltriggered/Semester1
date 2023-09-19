namespace Lab7_but_cooler
{
    partial class Arrays
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Unsorted = new System.Windows.Forms.DataGridView();
            this.LabelUnsorted = new System.Windows.Forms.Label();
            this.ButtonSort = new System.Windows.Forms.Button();
            this.ButtonReset = new System.Windows.Forms.Button();
            this.LabelSorted = new System.Windows.Forms.Label();
            this.LabelBubble = new System.Windows.Forms.Label();
            this.LabelInsert = new System.Windows.Forms.Label();
            this.LabelLength = new System.Windows.Forms.Label();
            this.BoxLength = new System.Windows.Forms.TextBox();
            this.ButtonCreate = new System.Windows.Forms.Button();
            this.Sorted = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Unsorted)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sorted)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Lab7_but_cooler.Properties.Resources.Arrays;
            this.pictureBox1.Location = new System.Drawing.Point(1, -107);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(708, 420);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Unsorted
            // 
            this.Unsorted.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Unsorted.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Unsorted.BackgroundColor = System.Drawing.Color.Black;
            this.Unsorted.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Unsorted.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Fixedsys Excelsior 3.01", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Unsorted.DefaultCellStyle = dataGridViewCellStyle1;
            this.Unsorted.GridColor = System.Drawing.Color.Black;
            this.Unsorted.Location = new System.Drawing.Point(199, 37);
            this.Unsorted.Name = "Unsorted";
            this.Unsorted.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Fixedsys Excelsior 3.01", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Unsorted.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Unsorted.RowHeadersVisible = false;
            this.Unsorted.RowTemplate.Height = 25;
            this.Unsorted.Size = new System.Drawing.Size(312, 23);
            this.Unsorted.TabIndex = 1;
            // 
            // LabelUnsorted
            // 
            this.LabelUnsorted.AutoSize = true;
            this.LabelUnsorted.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.LabelUnsorted.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LabelUnsorted.Font = new System.Drawing.Font("Fixedsys Excelsior 3.01", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelUnsorted.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.LabelUnsorted.Image = global::Lab7_but_cooler.Properties.Resources.LabelBG;
            this.LabelUnsorted.Location = new System.Drawing.Point(199, 9);
            this.LabelUnsorted.Name = "LabelUnsorted";
            this.LabelUnsorted.Size = new System.Drawing.Size(312, 25);
            this.LabelUnsorted.TabIndex = 2;
            this.LabelUnsorted.Text = "Неотсортированный массив:";
            // 
            // ButtonSort
            // 
            this.ButtonSort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ButtonSort.BackgroundImage = global::Lab7_but_cooler.Properties.Resources.ButtonBG;
            this.ButtonSort.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSort.Font = new System.Drawing.Font("Fixedsys Excelsior 3.01", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonSort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ButtonSort.Location = new System.Drawing.Point(199, 77);
            this.ButtonSort.Name = "ButtonSort";
            this.ButtonSort.Size = new System.Drawing.Size(143, 35);
            this.ButtonSort.TabIndex = 3;
            this.ButtonSort.Text = "Отсортировать";
            this.ButtonSort.UseVisualStyleBackColor = false;
            this.ButtonSort.Click += new System.EventHandler(this.ButtonSort_Click);
            // 
            // ButtonReset
            // 
            this.ButtonReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ButtonReset.BackgroundImage = global::Lab7_but_cooler.Properties.Resources.ButtonBG;
            this.ButtonReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonReset.Font = new System.Drawing.Font("Fixedsys Excelsior 3.01", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ButtonReset.Location = new System.Drawing.Point(368, 77);
            this.ButtonReset.Name = "ButtonReset";
            this.ButtonReset.Size = new System.Drawing.Size(143, 35);
            this.ButtonReset.TabIndex = 4;
            this.ButtonReset.Text = "Сбросить";
            this.ButtonReset.UseVisualStyleBackColor = false;
            this.ButtonReset.Click += new System.EventHandler(this.ButtonReset_Click);
            // 
            // LabelSorted
            // 
            this.LabelSorted.AutoSize = true;
            this.LabelSorted.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.LabelSorted.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LabelSorted.Font = new System.Drawing.Font("Fixedsys Excelsior 3.01", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelSorted.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.LabelSorted.Image = global::Lab7_but_cooler.Properties.Resources.LabelBG;
            this.LabelSorted.Location = new System.Drawing.Point(199, 131);
            this.LabelSorted.Name = "LabelSorted";
            this.LabelSorted.Size = new System.Drawing.Size(312, 25);
            this.LabelSorted.TabIndex = 6;
            this.LabelSorted.Text = " Отсортированный массив: ";
            // 
            // LabelBubble
            // 
            this.LabelBubble.AutoSize = true;
            this.LabelBubble.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.LabelBubble.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LabelBubble.Font = new System.Drawing.Font("Fixedsys Excelsior 3.01", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelBubble.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.LabelBubble.Image = global::Lab7_but_cooler.Properties.Resources.LabelBGbig;
            this.LabelBubble.Location = new System.Drawing.Point(536, 9);
            this.LabelBubble.Name = "LabelBubble";
            this.LabelBubble.Size = new System.Drawing.Size(162, 20);
            this.LabelBubble.TabIndex = 7;
            this.LabelBubble.Text = "Время \"пузырька\":";
            // 
            // LabelInsert
            // 
            this.LabelInsert.AutoSize = true;
            this.LabelInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.LabelInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LabelInsert.Font = new System.Drawing.Font("Fixedsys Excelsior 3.01", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelInsert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.LabelInsert.Image = global::Lab7_but_cooler.Properties.Resources.LabelBGbig;
            this.LabelInsert.Location = new System.Drawing.Point(536, 131);
            this.LabelInsert.Name = "LabelInsert";
            this.LabelInsert.Size = new System.Drawing.Size(153, 20);
            this.LabelInsert.TabIndex = 8;
            this.LabelInsert.Text = "Время \"вставок\":";
            // 
            // LabelLength
            // 
            this.LabelLength.AutoSize = true;
            this.LabelLength.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LabelLength.Font = new System.Drawing.Font("Fixedsys Excelsior 3.01", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelLength.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.LabelLength.Image = global::Lab7_but_cooler.Properties.Resources.LabelBG;
            this.LabelLength.Location = new System.Drawing.Point(10, 9);
            this.LabelLength.Name = "LabelLength";
            this.LabelLength.Size = new System.Drawing.Size(164, 22);
            this.LabelLength.TabIndex = 9;
            this.LabelLength.Text = "Длина массива:";
            // 
            // BoxLength
            // 
            this.BoxLength.BackColor = System.Drawing.Color.Black;
            this.BoxLength.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BoxLength.Font = new System.Drawing.Font("Fixedsys Excelsior 3.01", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BoxLength.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BoxLength.Location = new System.Drawing.Point(10, 34);
            this.BoxLength.Name = "BoxLength";
            this.BoxLength.Size = new System.Drawing.Size(164, 21);
            this.BoxLength.TabIndex = 10;
            // 
            // ButtonCreate
            // 
            this.ButtonCreate.BackgroundImage = global::Lab7_but_cooler.Properties.Resources.ButtonBG;
            this.ButtonCreate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCreate.Font = new System.Drawing.Font("Fixedsys Excelsior 3.01", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonCreate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ButtonCreate.Location = new System.Drawing.Point(12, 61);
            this.ButtonCreate.Name = "ButtonCreate";
            this.ButtonCreate.Size = new System.Drawing.Size(164, 35);
            this.ButtonCreate.TabIndex = 12;
            this.ButtonCreate.Text = "Создать массив";
            this.ButtonCreate.UseVisualStyleBackColor = true;
            this.ButtonCreate.Click += new System.EventHandler(this.ButtonCreate_Click);
            // 
            // Sorted
            // 
            this.Sorted.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Sorted.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Sorted.BackgroundColor = System.Drawing.Color.Black;
            this.Sorted.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Sorted.ColumnHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Fixedsys Excelsior 3.01", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Sorted.DefaultCellStyle = dataGridViewCellStyle3;
            this.Sorted.GridColor = System.Drawing.Color.Black;
            this.Sorted.Location = new System.Drawing.Point(199, 159);
            this.Sorted.Name = "Sorted";
            this.Sorted.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Fixedsys Excelsior 3.01", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Sorted.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.Sorted.RowHeadersVisible = false;
            this.Sorted.RowTemplate.Height = 25;
            this.Sorted.Size = new System.Drawing.Size(312, 23);
            this.Sorted.TabIndex = 13;
            // 
            // Arrays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 201);
            this.Controls.Add(this.Sorted);
            this.Controls.Add(this.ButtonCreate);
            this.Controls.Add(this.BoxLength);
            this.Controls.Add(this.LabelLength);
            this.Controls.Add(this.LabelInsert);
            this.Controls.Add(this.LabelBubble);
            this.Controls.Add(this.LabelSorted);
            this.Controls.Add(this.ButtonReset);
            this.Controls.Add(this.ButtonSort);
            this.Controls.Add(this.LabelUnsorted);
            this.Controls.Add(this.Unsorted);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Arrays";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Работа с массивами";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Unsorted)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sorted)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private DataGridView Unsorted;
        private Label LabelUnsorted;
        private Button ButtonSort;
        private Button ButtonReset;
        private Label LabelSorted;
        private Label LabelBubble;
        private Label LabelInsert;
        private Label LabelLength;
        private TextBox BoxLength;
        private Button ButtonCreate;
        private DataGridView Sorted;
    }
}