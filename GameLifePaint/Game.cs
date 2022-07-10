using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace GameLifePaint
{
    internal class Game
    {
        private int tick = 100;
        public static ManualResetEvent mre = new ManualResetEvent(false);

        Field field;
        NeighborCounter nbcounter;

        Bitmap bmp;
        readonly PictureBox gameBox;

        int size;
        bool state;

        public Game(int size, PictureBox gameBox)
        {
            this.size = size;
            this.gameBox = gameBox;
            state = false;
            bmp = new Bitmap(gameBox.Width, gameBox.Height);
        }

        public void BuildGame()
        {
            field = new Field(size, bmp.Width);
            nbcounter = new NeighborCounter(field.Cells);

            bmp = field.CreateField();
            UpdatePictureBox();
        }

        public void Step()
        {
            CellChanger();
            UpdatePictureBox();
            Thread.Sleep(tick);
        }

        private void CellChanger()
        {
            for (int i = 0; i < size; ++i)
                for (int j = 0; j < size; ++j)
                {
                    nbcounter.CountNeighbors(i, j, size);
                }

            field.UpdateStep(bmp);
        }

        public void Clean()
        {
            foreach (Cell cell in field.Cells)
                cell.State = false;

            bmp.Dispose();
            bmp = field.CreateField();
            UpdatePictureBox();
        }

        public void Random(double rand)
        {
            Random r = new Random();
            for (int i = 0; i < size; ++i)
                for (int j = 0; j < size; ++j)
                {
                    field.Cells[i, j].State = r.NextDouble() < rand;
                }
            field.UpdateRandom(bmp);
            UpdatePictureBox();
        }

        public void InvertState()
        {
            state = !state;
        }

        public void Resize(int size)
        {
            this.size = size;
            BuildGame();
        }

        public void ClickEvent(int X, int Y)
        {
            field.CellClick(X, Y, bmp);
            UpdatePictureBox();
        }

        private void UpdatePictureBox()
        {
            gameBox.Image = bmp;
        }

        public int SIZE { get => size; }
        public int TICK { get => tick; set => tick = value; }
        public bool State { get => state; set => state = value; }
        public Bitmap Bitmap { get => bmp; set => bmp = value; }
    }
}
