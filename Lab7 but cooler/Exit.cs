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
    public partial class Exit : Form
    {
        public Exit()
        {
            InitializeComponent();
        }

        private void ButtonNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonYes_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
