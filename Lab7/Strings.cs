using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab7
{
    public partial class Strings : Form
    {
        public Strings()
        {
            InitializeComponent();
            label3.Enabled = false;
            textBox1.Enabled = false;
            label4.Enabled = false;
            textBox2.Enabled = false;
            radioButton1.Checked = true;
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label3.Enabled = false;
            textBox1.Enabled = false;
            textBox1.Clear();
            label4.Enabled = false;
            textBox2.Enabled = false;
            textBox2.Clear();
            label1.Enabled = true;
            richTextBox1.Enabled = true;
            richTextBox1.Text = "Варкалось. Хливкие шорьки\r\nПырялись по наве,\r\nИ хрюкотали зелюки,\r\nКак мюмзики в мове.\r\nО бойся Бармаглота, сын!\r\nОн так свирлеп и дик,\r\nА в глуще рымит исполин -\r\nЗлопастный Брандашмыг.";
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label3.Enabled = false;
            textBox1.Enabled = false;
            textBox1.Clear();
            label4.Enabled = false;
            textBox2.Enabled = false;
            textBox2.Clear();
            label1.Enabled = true;
            richTextBox1.Enabled = true;
            richTextBox1.Text = "Варкалось. Хливкие шорьки\r\nПырялись по наве,\r\nИ хрюкотали зелюки,\r\nКак мюмзики в мове.\r\nО бойся Бармаглота, сын!\r\nОн так свирлеп и дик,\r\nА в глуще рымит исполин -\r\nЗлопастный Брандашмыг.";
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label1.Enabled = false;
            richTextBox1.Enabled = false;
            richTextBox1.Clear();
            label3.Enabled = true;
            textBox1.Enabled = true;
            textBox1.Text = "Быть может, вся Природа – мозаика цветов?";
            label4.Enabled = true;
            textBox2.Enabled = true;
            textBox2.Text = "Быть может, вся Природа – различность голосов?";
            richTextBox2.Clear();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if ((richTextBox1.Enabled) && (richTextBox1.Text == ""))
            {
                MessageBox.Show("Поле строки пустое, работа программы невозможна.", "Ошибка!");
            }
            else if ((!richTextBox1.Enabled) && ((textBox1.Text == "") || (textBox2.Text == "")))
            {
                MessageBox.Show("Поле одной или двух строк пустое, работа программы невозможна.", "Ошибка!");
            }
            else
            {
                if (radioButton1.Checked)
                {
                    LetterCounter(richTextBox1.Text);
                }
                else if (radioButton2.Checked)
                {
                    CasesCounter(richTextBox1.Text);
                }
                else if (radioButton3.Checked)
                {
                    Similarities(textBox1.Text, textBox2.Text);
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox2.Clear();
            textBox1.Clear();
            textBox2.Clear();
        }
        private void LetterCounter(string str)
        {
            string consonants = "бвгджзклмнпрстфхцчшщйъьБВГДЖЗКЛМНПРСТФХЦЧШЩЙЪЬ";
            string vowels = "аеёиоуэюяАЕЁИОУЭЮЯ";
            int consonantsCounter = 0;
            int vowelsCounter = 0;
            foreach (char ch in str)
            {
                if (consonants.Contains(ch))
                {
                    consonantsCounter++;
                }
                if (vowels.Contains(ch))
                {
                    vowelsCounter++;
                }
            }
            richTextBox2.Text = "Количество гласных букв: " + vowelsCounter.ToString() +
                ", согласных: " + consonantsCounter.ToString();
        }
        private void CasesCounter(string str)
        {
            string Cases = "Аа";
            int CasesCounter = 0;
            foreach (char ch in str)
            {
                if (Cases.Contains(ch))
                {
                    CasesCounter++;
                }
            }
            richTextBox2.Text = "Количество букв А(а): " + CasesCounter.ToString();
        }
        private void Similarities(string str1, string str2)
        {
            char[] equals = str1.ToCharArray();
            char[] equals1 = str2.ToCharArray();
            string symbols = "@#$%^&*()_+№;:?-=<>,./!|";
            int similar = 0;
            for (int i = 0; i < equals.Length; i++)
            {
                if (equals.Length > equals1.Length)
                {
                    if (char.IsLetter(equals[i]) || symbols.Contains(equals[i]))
                    {
                        if (equals[i] == equals1[i])
                        {
                            similar++;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                else
                {
                    if (char.IsLetter(equals1[i]) || symbols.Contains(equals1[i]))
                    {
                        if (equals1[i] == equals[i])
                        {
                            similar++;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }
            richTextBox2.Text = "Совпадает первых символов: " + similar.ToString();
        }
    }
}
