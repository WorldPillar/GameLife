using System;
using System.Threading;

namespace GameLife
{
    public partial class Form : System.Windows.Forms.Form
    {
        Thread gamethread;
        Game game;

        public Form()
        {
            InitializeComponent();
            game = new Game(10,10);
            gamethread = new Thread(new ThreadStart(GameStart));
        }

        private void Form_Load(object sender, EventArgs e)
        {
            game.Enter();
            foreach (Cell cell in game.Cells)
                groupCell.Controls.Add(cell);
            gamethread.Start();
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
            groupCell.Controls.Clear();

            int size = int.Parse(sizeBox.SelectedItem.ToString());
            game.ReSize(size, size);

            foreach (Cell cell in game.Cells)
                groupCell.Controls.Add(cell);
        }

        private void Form_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            gamethread.Abort();
            Environment.Exit(-1);
        }
    }
}
