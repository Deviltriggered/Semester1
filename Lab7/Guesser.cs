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
    public partial class Guesser : Form
    {
        private double a;
        private double b;
        private double answer;
        private double userAnswer;
        private int tries = 3;
        public Guesser()
        {
            InitializeComponent();
            label3.Enabled = false;
            label4.Enabled = false;
            label5.Visible = false;
            textBox3.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            bool readA = double.TryParse(textBox1.Text, out a);
            bool readB = double.TryParse(textBox2.Text, out b);
            if ((string.IsNullOrEmpty(textBox1.Text)) || (string.IsNullOrEmpty(textBox2.Text)))
            {
                MessageBox.Show("Значения переменных отсутствуют, работа программы невозможна.", "Ошибка!");
            }
            else if ((!readA) || (!readB))
            {
                MessageBox.Show("Произошла ошибка при вводе значений переменных, работа программы невозможна.", "Ошибка!");
            }
            else if (b == 0)
            {
                MessageBox.Show("Значение переменной b не может быть равно 0.", "Ошибка!");
            }
            else
            {
                label1.Enabled = false;
                label2.Enabled = false;
                label3.Enabled = true;
                label4.Enabled = true;
                label5.Visible = false;
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                textBox3.Enabled = true;
                button1.Enabled = false;
                button2.Enabled = true;
                button3.Enabled = true;
                answer = Guess.Maths(a, b);
                label5.Text = "Правильный ответ: " + answer;
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            a = 0;
            b = 0;
            answer = 0;
            userAnswer = 0;
            tries = 3;
            label1.Enabled = true;
            label2.Enabled = true;
            label3.Enabled = false;
            label4.Enabled = false;
            label5.Visible = false;
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = false;
            button1.Enabled = true;
            button2.Enabled = false;
            button3.Enabled = false;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            label4.Text = "Осталось попыток: " + tries;
            bool readUser = double.TryParse(textBox3.Text, out userAnswer);
            if (!readUser)
            {
                MessageBox.Show("Произошла ошибка при вводе ответа.", "Ошибка!");
            }
            else
            {
                if (userAnswer != answer)
                {
                    MessageBox.Show("Ответ неправильный!", "Неудача!");
                    tries--;
                    label4.Text = "Осталось попыток: " + tries;
                }
                if (tries == 0)
                {
                    MessageBox.Show("У Вас не получилось отгадать ответ :(", "Неудача");
                    label4.Visible = false;
                    label5.Visible = true;
                    label3.Enabled = false;
                    textBox3.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = true;
                }
                else if (userAnswer == answer)
                {
                    MessageBox.Show("Ответ правильный!", "Успех!");
                    tries = 0;
                    label4.Visible = false;
                    label5.Visible = true;
                    label3.Enabled = false;
                    textBox3.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = true;
                }
            }
        }
    }
}
