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

        public Form()
        {
            InitializeComponent();
            game = new Game(10, pBox);
            gamethread = new Thread(new ThreadStart(GameStart));
        }

        private void Form_Load(object sender, EventArgs e)
        {
            game.Enter();
            gamethread.Start();
            sizeBox.SelectedIndex = 0;
        }

        private void GameStart()
        {
            while (true)
            {
                Game.mre.WaitOne();
                game.Step();
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
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            Interrupt();
            game.Clean();
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            Interrupt();
            game.Random(0.2);
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

            string strsize = sizeBox.SelectedItem.ToString();
            int size = int.Parse(strsize);
            game.Resize(size);
        }

        public void pBox_MouseClick(object sender, MouseEventArgs e)
        {
            game.ClickEvent(e.X, e.Y);
        }

        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            gamethread.Abort();
            Environment.Exit(-1);
        }
    }
}
