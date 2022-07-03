using System;
using System.Threading;

namespace GameLife
{
    public partial class Form : System.Windows.Forms.Form
    {
        Thread gamethread;
        Thread stepthread;
        Game game;
        double randval;

        public Form()
        {
            InitializeComponent();
            game = new Game(30,30);
            gamethread = new Thread(new ThreadStart(GameStart));
            stepthread = new Thread(new ThreadStart(StepStart));
            randval = 0.1;
        }

        private void Form_Load(object sender, EventArgs e)
        {
            game.Enter();
            foreach (Cell cell in game.Cells)
                this.Controls.Add(cell);
            gamethread.Start();
            stepthread.Start();
        }

        private void GameStart()
        {
            while (true)
            {
                Game.mre.WaitOne();
                game.Step();
            }
        }

        private void StepStart()
        {
            Game.mre.WaitOne();
            game.Step();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            if (game.State)
            {
                Game.mre.Reset();
                btnRun.Text = "Run";
            }
            else
            {
                Game.mre.Set();
                btnRun.Text = "Stop";
            }
            game.Stop_Proceed();
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
            game.Random(0.1);
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
    }
}
