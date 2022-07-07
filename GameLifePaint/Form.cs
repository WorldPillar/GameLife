using System;
using System.Threading;
using System.Windows.Forms;
using System.Drawing;

namespace GameLifePaint
{
    public partial class Form : System.Windows.Forms.Form
    {
        Thread gamethread;
        Game game;
        Bitmap bmp;

        public Form()
        {
            InitializeComponent();
            bmp = new Bitmap(pBox.Width, pBox.Height);
            game = new Game(10, bmp);
            gamethread = new Thread(new ThreadStart(GameStart));
        }

        private void Form_Load(object sender, EventArgs e)
        {
            game.Enter();
            pBox.Image = game.Bitmap;
            gamethread.Start();
        }

        private void GameStart()
        {
            PictureBox threadBox = new PictureBox();
            threadBox.Name = "threadBox";
            while (true)
            {
                Game.mre.WaitOne();
                game.Step();
                pBox.Image = game.Bitmap;
            }
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            game.Stop_Proceed();
            if (!game.State)
            {
                Game.mre.Reset();
                btnRun.Text = "Run";
            }
            else
            {
                Game.mre.Set();
                btnRun.Text = "Stop";
            }
        }

        private void btnStep_Click(object sender, EventArgs e)
        {
            Interrupt();
            game.Step();
            pBox.Image = game.Bitmap;
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            Interrupt();
            game.Clean();
            pBox.Image = game.Bitmap;
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            Interrupt();
            game.Random(0.2);
            pBox.Image = game.Bitmap;
        }

        private void Interrupt()
        {
            if (game.State)
            {
                Game.mre.Reset();
                btnRun.Text = "Run";
                game.Stop_Proceed();
            }
        }

        private void sizeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Interrupt();

            int size = int.Parse(sizeBox.SelectedItem.ToString());
            game.ReSize(size);
            pBox.Image = game.Bitmap;
        }

        public void pBox_MouseClick(object sender, MouseEventArgs e)
        {
            game.ClickEvent(e.X, e.Y);
            pBox.Image = game.Bitmap;
        }

        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            gamethread.Abort();
            Environment.Exit(-1);
        }
    }
}
