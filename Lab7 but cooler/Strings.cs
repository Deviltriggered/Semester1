using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab7_but_cooler
{
    public partial class Strings : Form
    {
        public Strings()
        {
            InitializeComponent();
            LabelStr1.Enabled = false;
            BoxStr1.Enabled = false;
            BoxStr1.Clear();
            LabelStr2.Enabled = false;
            BoxStr2.Enabled = false;
            BoxStr2.Clear();
            ButtonTask1.Checked = true;
        }
        private void ButtonTask1_CheckedChanged(object sender, EventArgs e)
        {
            LabelStr1.Enabled = false;
            BoxStr1.Enabled = false;
            BoxStr1.Clear();
            LabelStr2.Enabled = false;
            BoxStr2.Enabled = false;
            BoxStr2.Clear();
            LabelStr.Enabled = true;
            BoxStr.Enabled = true;
            BoxStr.Text = "Варкалось. Хливкие шорьки\r\nПырялись по наве,\r\nИ хрюкотали зелюки,\r\nКак мюмзики в мове.\r\nО бойся Бармаглота, сын!\r\nОн так свирлеп и дик,\r\nА в глуще рымит исполин -\r\nЗлопастный Брандашмыг.";
        }
        private void ButtonTask2_CheckedChanged(object sender, EventArgs e)
        {
            LabelStr2.Enabled = false;
            BoxStr2.Enabled = false;
            BoxStr2.Clear();
            LabelStr1.Enabled = false;
            BoxStr1.Enabled = false;
            BoxStr1.Clear();
            LabelStr.Enabled = true;
            BoxStr.Enabled = true;
            BoxStr.Text = "Вот 1 (иль единица),\r\nОчень тонкая, как спица,\r\nА вот это цифра 2.\r\nПолюбуйся, какова:\r\nВыгибает двойка шею,\r\nВолочится хвост за нею.\r\nА за двойкой - посмотри -\r\nВыступает цифра 3.\r\nТройка - третий из значков -\r\nСостоит из двух крючков.";
        }
        private void ButtonTask3_CheckedChanged(object sender, EventArgs e)
        {
            LabelStr.Enabled = false;
            BoxStr.Enabled = false;
            BoxStr.Clear();
            LabelStr1.Enabled = true;
            BoxStr1.Enabled = true;
            BoxStr1.Text = "Быть может, вся Природа – мозаика цветов?";
            LabelStr2.Enabled = true;
            BoxStr2.Enabled = true;
            BoxStr2.Text = "Быть может, вся Природа – различность голосов?";
            BoxResult.Clear();
        }
        private void ButtonSolve_Click(object sender, EventArgs e)
        {
            if ((BoxStr.Enabled) && (BoxStr.Text == ""))
            {
                MessageBox.Show("Поле строки пустое", "Ошибка!");
            }
            else if ((!BoxStr.Enabled) && ((BoxStr1.Text == "") || (BoxStr2.Text == "")))
            {
                MessageBox.Show("Поле одной или двух строк пустое", "Ошибка!");
            }
            else
            {
                if (ButtonTask1.Checked)
                {
                    CountWords(BoxStr.Text);
                }
                else if (ButtonTask2.Checked)
                {
                    SumNumbers(BoxStr.Text);
                }
                else if (ButtonTask3.Checked)
                {
                    Coincidence(BoxStr1.Text, BoxStr2.Text);
                }
            }
        }
        private void ButtonClear_Click(object sender, EventArgs e)
        {
            BoxResult.Clear();
            BoxStr.Clear();
            BoxStr2.Clear();
            BoxStr1.Clear();
        }
        private void CountWords(string str)
        {
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (i < str.Length - 1)
                {
                    bool a = char.IsLetter(str[i]);
                    bool b = char.IsLetter(str[i + 1]);
                    bool c = char.IsWhiteSpace(str[i + 1]);
                    if (a && (!b || c))
                    {
                        count++;
                    }
                }
            }
            BoxResult.Text = "Количество слов в строке: " + count;
        }
        private void SumNumbers(string str)
        {
            int sum = 0;
            string nums = "0123456789";
            for (int i = 0; i < str.Length; i++)
            {
                if (nums.Contains(str[i]))
                {
                    sum++;
                }
            }
            BoxResult.Text = "Количество цифр в строке: " + sum;
        }
        private void Coincidence(string str1, string str2)
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
            BoxResult.Text = "Совпадает первых символов: " + similar.ToString();
        }
    }
}
