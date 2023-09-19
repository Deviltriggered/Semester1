using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7
{
    public partial class Minesweeper : Form
    {
        Game game = new Game();
        private string[,] mask = new string[10, 10];
        private int[,] grid = new int[10, 10];
        public Minesweeper()
        {
            InitializeComponent();
            game.MaskGrid(mask);
            game.GenerateGrid(grid);
            game.FormatGrid(grid);
            dataGridView1.RowCount = 12;
            dataGridView1.ColumnCount = 12;
            for (int i = 1; i < 11; i++)
            {
                dataGridView1.Rows[0].Cells[i + 1].Value = i;
            }
            for (int j = 1; j < 11; j++)
            {
                dataGridView1.Rows[j + 1].Cells[0].Value = j;
            }
            for (int x = 0; x < 10; x++)
            {
                for (int y = 0; y < 10; y++)
                {
                    dataGridView1.Rows[x + 2].Cells[y + 2].Value = mask[x, y];
                }
            }
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((!char.IsControl(e.KeyChar)) && (!char.IsDigit(e.KeyChar))) || (e.KeyChar == '.'))
            {
                e.Handled = true;
            }
        }
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((!char.IsControl(e.KeyChar)) && (!char.IsDigit(e.KeyChar))) || (e.KeyChar == '.'))
            {
                e.Handled = true;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            game.MaskGrid(mask);
            game.GenerateGrid(grid);
            game.FormatGrid(grid);
            dataGridView1.RowCount = 12;
            dataGridView1.ColumnCount = 12;
            for (int i = 1; i < 11; i++)
            {
                dataGridView1.Rows[0].Cells[i + 1].Value = i;
            }
            for (int j = 1; j < 11; j++)
            {
                dataGridView1.Rows[j + 1].Cells[0].Value = j;
            }
            for (int x = 0; x < 10; x++)
            {
                for (int y = 0; y < 10; y++)
                {
                    dataGridView1.Rows[x + 2].Cells[y + 2].Value = mask[x, y];
                }
            }
            textBox1.Clear();
            textBox1.Enabled = true;
            textBox2.Clear();
            textBox2.Enabled = true;
            button1.Enabled = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "") || (textBox2.Text == ""))
            {
                MessageBox.Show("Значения хода отсутствуют или введены неполностью.", "Ошибка!");
            }
            else
            {
                int x = int.Parse(textBox1.Text);
                int y = int.Parse(textBox2.Text);
                if (((x < 1) || (x > 10)) || ((y < 1) || (y > 10)))
                {
                    MessageBox.Show("Значения хода выходят за пределы игрового поля.", "Ошибка!");
                }
                else
                {
                    if (grid[y - 1, x - 1] != 9)
                    {
                        dataGridView1.Rows[y + 1].Cells[x + 1].Value = grid[y - 1, x - 1].ToString();
                        textBox1.Clear();
                        textBox2.Clear();
                    }
                    else
                    {
                        dataGridView1.Rows[y + 1].Cells[x + 1].Value = grid[y - 1, x - 1].ToString();
                        MessageBox.Show("Вы попали на клетку с миной! Попробуйте снова!", "Проигрыш!");
                        textBox1.Clear();
                        textBox1.Enabled = false;
                        textBox2.Clear();
                        textBox2.Enabled = false;
                        button1.Enabled = false;
                    }
                }
            }
        }
    }
}
