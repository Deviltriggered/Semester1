using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7
{
    public partial class Arrays : Form
    {
        Array array = new Array();
        private int[] arr;
        private int[] arr1;
        private int[] arr2;
        private int[] arr3;
        Stopwatch timer = new Stopwatch();
        Stopwatch timeBubble = new Stopwatch();
        Stopwatch timeShell = new Stopwatch();
        public Arrays()
        {
            InitializeComponent();
            OffShell();
            OffBubble();
            OffSorted();
            OffUnsorted();
            textBox1.Text = "10";
            button2.Enabled = false;
            button5.Enabled = false;
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((!char.IsControl(e.KeyChar)) && (!char.IsDigit(e.KeyChar))) || (e.KeyChar == '.'))
            {
                e.Handled = true;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ResetTimers();
            textBox2.Clear();
            textBox3.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.Refresh();
            dataGridView2.Columns.Clear();
            dataGridView2.Refresh();
            OffShell();
            OffBubble();
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            arr = array.CreateArray(int.Parse(textBox1.Text));
            arr1 = array.CopyArray(arr);
            arr2 = array.CopyArray(arr);
            arr3 = array.CopyArray(arr);
            if (int.Parse(textBox1.Text) > 20)
            {
                MessageBox.Show("Массив слишком длинный, вывод невозможен.\r\nСортировка остаётся доступной.", "Предупреждение");
                OffSorted();
                OffUnsorted();
                button2.Enabled = false;
            }
            else
            {
                OnUnsorted();
                button2.Enabled = true;
                dataGridView1.RowCount = 1;
                dataGridView1.ColumnCount = arr.Length;
                for (int i = 0; i < arr.Length; i++)
                {
                    dataGridView1.Rows[0].Cells[i].Value = arr[i];
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            ResetTimers();
            textBox2.Clear();
            textBox3.Clear();
            OffBubble();
            OffShell();
            OffUnsorted();
            OffSorted();
            button5.Enabled = false;
            dataGridView1.Columns.Clear();
            dataGridView1.Refresh();
            dataGridView2.Columns.Clear();
            dataGridView2.Refresh();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            OffShell();
            OnBubble();
            button3.Enabled = false;
            button5.Enabled = true;
            timer.Start();
            array.BubbleSort(arr1);
            timer.Stop();
            if (arr1.Length < 21)
            {
                OnSorted();
                dataGridView2.RowCount = 1;
                dataGridView2.ColumnCount = arr.Length;
                for (int i = 0; i < arr1.Length; i++)
                {
                    dataGridView2.Rows[0].Cells[i].Value = arr1[i];
                }
            }
            textBox3.Text = timer.Elapsed.ToString();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            OffBubble();
            OnShell();
            button4.Enabled = false;
            button5.Enabled = true;
            timer.Start();
            array.ShellSort(arr1);
            timer.Stop();
            if (arr1.Length < 21)
            {
                OnSorted();
                dataGridView2.RowCount = 1;
                dataGridView2.ColumnCount = arr.Length;
                for (int i = 0; i < arr1.Length; i++)
                {
                    dataGridView2.Rows[0].Cells[i].Value = arr1[i];
                }
            }
            textBox2.Text = timer.Elapsed.ToString();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            OnShell();
            OnBubble();
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            if (!string.IsNullOrEmpty(textBox2.Text))
            {
                timeBubble.Start();
                array.BubbleSort(arr2);
                timeBubble.Stop();
                textBox3.Text = timeBubble.Elapsed.ToString();
                if (timer.Elapsed < timeBubble.Elapsed)
                {
                    MessageBox.Show("Для данного массива сортировка Шелла работает быстрее.", "Результат");
                }
                else
                {
                    MessageBox.Show("Для данного массива сортировка пузырьком работает быстрее.", "Результат");
                }
            }
            else if (!string.IsNullOrEmpty(textBox3.Text))
            {
                timeShell.Start();
                array.ShellSort(arr2);
                timeShell.Stop();
                textBox2.Text = timeShell.Elapsed.ToString();
                if (timer.Elapsed > timeShell.Elapsed)
                {
                    MessageBox.Show("Для данного массива сортировка Шелла работает быстрее.", "Результат");
                }
                else
                {
                    MessageBox.Show("Для данного массива сортировка пузырьком работает быстрее.", "Результат");
                }
            }
            else
            {
                timeBubble.Start();
                array.BubbleSort(arr2);
                timeBubble.Stop();
                timeShell.Start();
                array.ShellSort(arr3);
                timeShell.Stop();
                textBox2.Text = timeShell.Elapsed.ToString();
                textBox3.Text = timeBubble.Elapsed.ToString();
                if (arr2.Length < 21)
                {
                    OnSorted();
                    dataGridView2.RowCount = 1;
                    dataGridView2.ColumnCount = arr2.Length;
                    for (int i = 0; i < arr2.Length; i++)
                    {
                        dataGridView2.Rows[0].Cells[i].Value = arr2[i];
                    }
                }
                if (timeShell.Elapsed < timeBubble.Elapsed)
                {
                    MessageBox.Show("Для данного массива сортировка Шелла работает быстрее.", "Результат");
                }
                else
                {
                    MessageBox.Show("Для данного массива сортировка пузырьком работает быстрее.", "Результат");
                }
            }
        }
        private void OffShell()
        {
            button4.Enabled = false;
            label4.Enabled = false;
            textBox2.Enabled = false;
        }
        private void OffBubble()
        {
            button3.Enabled = false;
            label5.Enabled = false;
            textBox3.Enabled = false;
        }
        private void OffUnsorted()
        {
            dataGridView1.Enabled = false;
            label2.Enabled = false;
        }
        private void OffSorted()
        {
            dataGridView2.Enabled = false;
            label3.Enabled = false;
        }
        private void OnShell()
        {
            button4.Enabled = true;
            label4.Enabled = true;
            textBox2.Enabled = true;
        }
        private void OnBubble()
        {
            button3.Enabled = true;
            label5.Enabled = true;
            textBox3.Enabled = true;
        }
        private void OnUnsorted()
        {
            dataGridView1.Enabled = true;
            label2.Enabled = true;
        }
        private void OnSorted()
        {
            dataGridView2.Enabled = true;
            label3.Enabled = true;
        }
        private void ResetTimers()
        {
            timer.Reset();
            timeBubble.Reset();
            timeShell.Reset();
        }
    }
}
