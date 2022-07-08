using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace GameLifePaint
{
    internal class Game
    {
        int SLEEP = 10;
        public static ManualResetEvent mre = new ManualResetEvent(false);
        Field field;
        Bitmap bmp;
        PictureBox pBox;
        int size;
        bool state;

        public Game(int size, PictureBox pBox, bool state = false)
        {
            this.size = size;
            this.state = state;
            this.pBox = pBox;
            bmp = new Bitmap(pBox.Width, pBox.Height); ;
        }

        public void Enter()
        {
            field = new Field(size, bmp.Width);

            bmp = field.CreateField();
            UpdatePictureBox();
        }

        public void Step()
        {
            CellChanger();
            UpdatePictureBox();
            Thread.Sleep(SLEEP);
        }

        private void CellChanger()
        {
            for (int i = 0; i < size; ++i)
                for (int j = 0; j < size; ++j)
                {
                    bool roof = i % (size - 1) == 0;
                    bool wall = j % (size - 1) == 0;
                    bool corner = roof && wall;
                    bool inner = !roof && !wall;

                    Cell cell = field.Cells[i, j];
                    if (inner)
                        InnerState(i, j, cell);
                    else if (!corner)
                        WallState(i, j, cell);
                    else
                        CornerState(i, j, cell);
                }

            UpdatetoStep();
        }

        private void UpdatetoStep()
        {
            SolidBrush redBrush = new SolidBrush(Color.Red);
            SolidBrush whiteBrush = new SolidBrush(Color.White);
            try
            {
                Graphics g = Graphics.FromImage(bmp);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Graphics g = Graphics.FromImage(bmp);
                int step = Bitmap.Width / size;
                foreach (Cell cell in field.Cells)
                {
                    if (cell.Selection())
                    {
                        if (cell.Life)
                            g.FillRectangle(redBrush, cell.Position.X * step + 1, cell.Position.Y * step + 1, step - 1, step - 1);
                        else
                            g.FillRectangle(whiteBrush, cell.Position.X * step + 1, cell.Position.Y * step + 1, step - 1, step - 1);
                    }
                }
                g.Dispose();
                redBrush.Dispose();
                whiteBrush.Dispose();
            }
        }

        private void CornerState(int i, int j, Cell cell)
        {
            int last = field.Size - 1;
            int[] ki = { i, Math.Abs(i - 1) % last, Math.Abs(i - 1) % last };
            int[] lj = { Math.Abs(j - 1) % last, Math.Abs(j - 1) % last, j };

            CornerWall(ki, lj, cell);
        }

        private void WallState(int i, int j, Cell cell)
        {
            int last = field.Size - 1;
            if (i % last == 0)
            {
                int k = Math.Abs(i - 1) % last;
                int[] ki = { i, k, k, k, i };
                int[] lj = { j - 1, j - 1, j, j + 1, j + 1 };
                CornerWall(ki, lj, cell);
            }
            else
            {
                int l = Math.Abs(j - 1) % last;
                int[] lj = { j, l, l, l, j };
                int[] ki = { i - 1, i - 1, i, i + 1, i + 1 };
                CornerWall(ki, lj, cell);
            }
        }

        private void CornerWall(int[] ki, int[] lj, Cell cell)
        {
            for (int i = 0, j = 0; i < ki.Length; ++i, ++j)
            {
                if (field.Cells[ki[i], lj[j]].Life)
                    cell.Neighbor = ++cell.Neighbor;
            }
        }

        private void InnerState(int i, int j, Cell cell)
        {
            for (int k = i - 1; k < i + 2; ++k)
                for (int l = j - 1; l < j + 2; ++l)
                {
                    if (k == i && l == j)
                        continue;
                    if (field.Cells[k, l].Life)
                        cell.Neighbor = ++cell.Neighbor;
                }
        }

        public void Clean()
        {
            foreach (Cell cell in field.Cells)
                cell.State = false;
            bmp = null;
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
            field.UpdateCells(bmp);
            UpdatePictureBox();
        }

        public void Stop_Proceed()
        {
            state = !state;
        }

        public void Resize(int size)
        {
            this.size = size;
            Enter();
        }

        public void ClickEvent(int X, int Y)
        {
            field.CellClick(X, Y, bmp);
            UpdatePictureBox();
        }

        private void UpdatePictureBox()
        {
            pBox.Image = bmp;
        }

        public Cell[,] Cells { get => field.Cells; }
        public bool State { get => state; set => state = value; }
        public Bitmap Bitmap { get => bmp; set => bmp = value; }
    }
}
