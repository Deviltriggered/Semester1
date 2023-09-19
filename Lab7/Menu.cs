using System.Net;

namespace Lab7
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            BackgroundImage = Image.FromStream(new WebClient().OpenRead("https://img2.reactor.cc/pics/post/full/faxdoc-Pixel-Art-Pixel-Gif-3249916.gif"));
            ImageAnimator.Animate(BackgroundImage, OnFrameChanged);
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult res =
                MessageBox.Show("Вы действительно хотите выйти?", "Подтверждение выхода", MessageBoxButtons.YesNo);
            if (res == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        private void OnFrameChanged(object sender, EventArgs e)
        {
            if (InvokeRequired)
            {
                BeginInvoke((Action)(() => OnFrameChanged(sender, e)));
                return;
            }
            ImageAnimator.UpdateFrames();
            Invalidate(false);
        }
        private void button1_click(object sender, EventArgs e)
        {
            MessageBox.Show("ФИО автора: Кудряшов Алексей Викторович\r\nГруппа: 6101-090301D", "Информация об авторе");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Minesweeper minesweeper = new Minesweeper();
            minesweeper.Show();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Strings strings = new Strings();
            strings.Show();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Arrays arrays = new Arrays();
            arrays.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Guesser guesser = new Guesser();
            guesser.Show();
        }
    }
}