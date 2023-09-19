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
    public partial class Game : Form
    {
        TicTacToe ttt = new TicTacToe();
        public Game()
        {
            InitializeComponent();
            ResetBtn.Enabled = false;
        }
        private void СrossZeroBtn_Click(object sender, EventArgs e)
        {
            ResetBtn.Enabled = true;
            if (sender is PictureBox pb)
            {
                int cell = int.Parse(pb.Name[12..]);

                PictureBox? crossZeroImg = Controls[(ttt.step % 2 == 1 ? "crossImg" : "zeroImg") + cell] as PictureBox;

                if (crossZeroImg is not null)
                {
                    ttt.MakeMove(cell);
                    crossZeroImg.Visible = true;
                    pb.Visible = false;
                    label1.Text = ttt.CheckEnd();
                }
            }
        }
        private void ResetBtn_Click(object sender, EventArgs e)
        {
            ttt = new();
            ResetBtn.Enabled = false;
            label1.Text = "Крестики-Нолики";
            for (int i = 1; i < 10; i++)
            {
                PictureBox? cell = Controls["zeroImg" + i] as PictureBox;
                if (cell is not null)
                    cell.Visible = false;

                cell = Controls["crossImg" + i] as PictureBox;
                if (cell is not null)
                    cell.Visible = false;

                cell = Controls["crossZeroBtn" + i] as PictureBox;
                if (cell is not null)
                    cell.Visible = true;
            }
        }
    }
}
