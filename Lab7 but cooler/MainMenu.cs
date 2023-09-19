using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7_but_cooler
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void GuessButton_Click(object sender, EventArgs e)
        {
            Guess guess = new Guess();
            guess.Show();
        }
        private void ArraysButton_Click(object sender, EventArgs e)
        {
            Arrays arrays = new Arrays();
            arrays.Show();
        }
        private void GameButton_Click(object sender, EventArgs e)
        {
            Game game = new Game();
            game.Show();
        }
        private void StringButton_Click(object sender, EventArgs e)
        {
            Strings strings = new Strings();
            strings.Show();
        }
        private void AuthorButton_Click(object sender, EventArgs e)
        {
            Author author = new Author();
            author.Show();
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Exit exit = new Exit();
            exit.Show();
        }
    }
}
