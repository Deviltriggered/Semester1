using ConsoleApp2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab7_but_cooler
{
    public partial class Arrays : Form
    {
        MassivesWork massive = new MassivesWork();
        private int[] arr;
        private int[] arr1;
        private int[] arr2;
        Stopwatch timer = new Stopwatch();
        Stopwatch timeBubble = new Stopwatch();
        Stopwatch timeInsert = new Stopwatch();
        public Arrays()
        {
            InitializeComponent();
            OffSort();
            OffSorted();
            OffUnsorted();
            BoxLength.Text = "10";
            ButtonSort.Enabled = false;
            ButtonReset.Enabled = false;
        }
        private void BoxLength_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((!char.IsControl(e.KeyChar)) && (!char.IsDigit(e.KeyChar))) || (e.KeyChar == '.'))
            {
                e.Handled = true;
            }
        }
        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            ResetTimers();
            Unsorted.Columns.Clear();
            Unsorted.Refresh();
            Sorted.Columns.Clear();
            Sorted.Refresh();
            arr = massive.CreateArray(int.Parse(BoxLength.Text));
            arr1 = massive.CopyArray(arr);
            arr2 = massive.CopyArray(arr);
            LabelBubble.Text = "Время \"Пузырька\":\r\n";
            LabelInsert.Text = "Время \"Вставок\":\r\n";
            if (int.Parse(BoxLength.Text) > 14)
            {
                MessageBox.Show("Массив слишком длинный, вывод отключен\r\nСортировка остаётся доступной", "Предупреждение");
                OffSorted();
                OffUnsorted();
                ButtonReset.Enabled = false;
                OnSort();
            }
            else
            {
                OnUnsorted();
                OnSort();
                ButtonReset.Enabled = true;
                Unsorted.RowCount = 1;
                Unsorted.ColumnCount = arr.Length;
                for (int i = 0; i < arr.Length; i++)
                {
                    Unsorted.Rows[0].Cells[i].Value = arr[i];
                }
            }
        }
        private void ButtonReset_Click(object sender, EventArgs e)
        {
            ResetTimers();
            OffUnsorted();
            OffSorted();
            OffSort();
            Unsorted.Columns.Clear();
            Unsorted.Refresh();
            Sorted.Columns.Clear();
            Sorted.Refresh();
            ButtonReset.Enabled = false;
            LabelBubble.Text = "Время \"Пузырька\":\r\n";
            LabelInsert.Text = "Время \"Вставок\":\r\n";
        }
        private void ButtonSort_Click(object sender, EventArgs e)
        {
            ButtonSort.Enabled = false;
            timeBubble.Start();
            massive.Bubble(arr1);
            timeBubble.Stop();
            timeInsert.Start();
            massive.Insert(arr2);
            timeInsert.Stop();
            LabelBubble.Text = "Время \"Пузырька\":\r\n"+ timeBubble.Elapsed.ToString();
            LabelInsert.Text = "Время \"Вставок\":\r\n" + timeInsert.Elapsed.ToString();
            if (arr.Length < 15)
            {
                OnSorted();
                Sorted.RowCount = 1;
                Sorted.ColumnCount = arr.Length;
                for (int i = 0; i < arr.Length; i++)
                {
                    Sorted.Rows[0].Cells[i].Value = arr2[i];
                }
            }
            if (timeInsert.Elapsed < timeBubble.Elapsed)
            {
                MessageBox.Show("Для данного массива сортировка вставками работает быстрее", "Результат");
            }
            else
            {
                MessageBox.Show("Для данного массива сортировка пузырьком работает быстрее", "Результат");
            }
        }
        private void OffSort()
        {
            ButtonSort.Enabled = false;
            LabelBubble.Enabled = false;
            LabelInsert.Enabled = false;
        }
        private void OffUnsorted()
        {
            Unsorted.Enabled = false;
            LabelUnsorted.Enabled = false;
        }
        private void OffSorted()
        {
            Sorted.Enabled = false;
            LabelSorted.Enabled = false;
        }
        private void OnSort()
        {
            ButtonSort.Enabled = true;
            LabelBubble.Enabled = true;
            LabelInsert.Enabled = true;
        }
        private void OnUnsorted()
        {
            Unsorted.Enabled = true;
            LabelUnsorted.Enabled = true;
        }
        private void OnSorted()
        {
            Sorted.Enabled = true;
            LabelSorted.Enabled = true;
        }
        private void ResetTimers()
        {
            timeInsert.Reset();
            timeBubble.Reset();
        }
    }
}
