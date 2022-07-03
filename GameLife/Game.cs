using System;
using System.Threading;

namespace GameLife
{
    internal class Game
    {
        public static ManualResetEvent mre = new ManualResetEvent(false);
        Field field;
        int rows, cols;
        bool state;

        public Game(int rows, int cols, bool state = false)
        {
            this.rows = rows;
            this.cols = cols;
            this.state = state;
        }

        public void Enter()
        {
            field = new Field((0, 30), rows, cols);
            Random r = new Random();
            for (int i = 0; i < rows; ++i)
                for (int j = 0; j < cols; ++j)
                {
                    field.Cells[i, j] = new Cell();
                }
            field.Draw();
        }

        public void Step()
        {
            int rows = field.Cells.GetLength(0);
            int cols = field.Cells.GetLength(1);

            CellChanger(rows, cols);
            Thread.Sleep(100);
        }

        private void CellChanger(int rows, int cols)
        {
            for (int i = 0; i < rows; ++i)
                for (int j = 0; j < cols; ++j)
                {
                    bool roof = i % (rows - 1) == 0;
                    bool wall = j % (cols - 1) == 0;
                    bool corner = roof && wall;
                    bool inner = !roof && !wall;

                    Cell cell = field.Cells[i, j];
                    cell.Neighbor = 0;
                    if (inner)
                        InnerState(i, j, cell);
                    else if (!corner)
                        WallState(i, j, cell);
                    else
                        CornerState(i, j, cell);
                }
            foreach (Cell cell in field.Cells)
                cell.Selection();
        }

        private void CornerState(int i, int j, Cell cell)
        {
            int[] ki = { i, Math.Abs(i - 1) % 29, Math.Abs(i - 1) % 29 };
            int[] lj = { Math.Abs(j - 1) % 29, Math.Abs(j - 1) % 29, j };

            CornerWall(ki, lj, cell);
        }

        private void WallState(int i, int j, Cell cell)
        {
            if (i % 29 == 0)
            {
                int k = Math.Abs(i - 1) % 29;
                int[] ki = { i, k, k, k, i };
                int[] lj = { j - 1, j - 1, j, j + 1, j + 1 };
                CornerWall(ki, lj, cell);
            }
            else
            {
                int l = Math.Abs(j - 1) % 29;
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
        }

        public void Random(double rand)
        {
            Random r = new Random();
            for (int i = 0; i < rows; ++i)
                for (int j = 0; j < cols; ++j)
                {
                    field.Cells[i, j].State = r.NextDouble() < rand;
                }
        }

        public void Stop_Proceed()
        {
            this.state = !state;
        }

        public void ReSize(int rows, int cols)
        {
            this.rows = rows;
            this.cols = cols;
        }

        public Cell[,] Cells { get => field.Cells; }
        public bool State { get => state; set => state = value; }
    }
}
