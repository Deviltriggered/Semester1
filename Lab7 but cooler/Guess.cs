using ConsoleApp2;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace Lab7_but_cooler
{
    public partial class Guess : Form
    {
        private int a;
        private int b;
        private int tries = 3;
        private double answer;
        private double userAnswer;
        public Guess()
        {
            InitializeComponent();
            LabelAns.Enabled = false;
            BoxAns.Enabled = false;
            ButtonAB.Enabled = true;
            ButtonClear.Enabled = false;
            ButtonTry.Enabled = false;
        }
        private void ButtonAB_Click(object sender, EventArgs e)
        {
            bool readA = int.TryParse(BoxA.Text, out a);
            bool readB = int.TryParse(BoxB.Text, out b);
            if ((string.IsNullOrEmpty(BoxA.Text)) || (string.IsNullOrEmpty(BoxB.Text)))
            {
                MessageBox.Show("Значения переменных отсутствуют", "Ошибка!");
            }
            else if ((!readA) || (!readB))
            {
                MessageBox.Show("Произошла ошибка при вводе значений переменных", "Ошибка!");
            }
            else
            {
                LabelA.Enabled = false;
                LabelB.Enabled = false;
                LabelAns.Enabled = true;
                BoxA.Enabled = false;
                BoxB.Enabled = false;
                BoxAns.Enabled = true;
                BoxAns.Enabled = true;
                ButtonAB.Enabled = false;
                ButtonClear.Enabled = true;
                ButtonTry.Enabled = true;
                answer = FirstCase.Calculation(a, b);
            }
        }
        private void ButtonClear_Click(object sender, EventArgs e)
        {
            BoxA.Clear();
            BoxB.Clear();
            BoxAns.Clear();
            a = 0;
            b = 0;
            answer = 0;
            userAnswer = 0;
            tries = 3;
            LabelAns.Enabled = false;
            LabelA.Enabled = true;
            LabelB.Enabled = true;
            BoxAns.Enabled = false;
            BoxA.Enabled = true;
            BoxB.Enabled = true;
            ButtonAB.Enabled = true;
            ButtonClear.Enabled = false;
            ButtonTry.Enabled = false;
        }
        private void ButtonTry_Click(object sender, EventArgs e)
        {
            bool readUser = double.TryParse(BoxAns.Text, out userAnswer);
            if (!readUser)
            {
                MessageBox.Show("Произошла ошибка при вводе ответа", "Ошибка!");
            }
            else
            {
                if (userAnswer != answer)
                {
                    tries--;
                    MessageBox.Show("Ответ неправильный!\r\nОсталось попыток: " + tries, "Неудача!");
                }
                if (tries == 0)
                {
                    MessageBox.Show("Вы проиграли!\r\nПравильный ответ: " + answer, "Неудача!");
                    LabelAns.Enabled = false;
                    BoxAns.Enabled = false;
                    ButtonTry.Enabled = false;
                    ButtonClear.Enabled = true;
                }
                else if (userAnswer == answer)
                {
                    MessageBox.Show("Ответ верный!", "Успех!");
                    tries = 0;
                    LabelAns.Enabled = false;
                    BoxAns.Enabled = false;
                    ButtonTry.Enabled = false;
                    ButtonClear.Enabled = true;
                }
            }
        }
    }
}
