using System;
using System.Windows.Forms;
using System.Threading;

namespace GameLife
{
    internal class Game
    {
        int SLEEP = 100;
        public static ManualResetEvent mre = new ManualResetEvent(false);
        Field field;
        GroupBox groupCell;
        int size;
        bool state;
        bool[,] buff;

        public Game(int size, GroupBox groupCell, bool state = false)
        {
            this.size = size;
            this.groupCell = groupCell;
            this.state = state;
        }

        public void Enter()
        {
            field = new Field(size);
            int i = 0;
            foreach (Cell cell in Cells)
                try
                {
                    groupCell.Controls.Add(cell);
                    ++i;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine(i);
                    Environment.Exit(-1);
                }
        }

        public void Step()
        {
            CellChanger();
            Thread.Sleep(SLEEP);
        }

        private void CellChanger()
        {
            buff = field.CellBuff;

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

                    cell.Selection();
                }
            buff = null;
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
                if (buff[ki[i], lj[j]])
                    cell.Neighbor += 1;
            }
        }

        private void InnerState(int i, int j, Cell cell)
        {
            for (int k = i - 1; k < i + 2; ++k)
                for (int l = j - 1; l < j + 2; ++l)
                {
                    if (k == i && l == j)
                        continue;
                    if (buff[k, l])
                        cell.Neighbor += 1;
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
            for (int i = 0; i < size; ++i)
                for (int j = 0; j < size; ++j)
                {
                    field.Cells[i, j].State = r.NextDouble() < rand;
                }
        }

        public void Stop_Proceed()
        {
            state = !state;
        }

        public void Resize(int size)
        {
            groupCell.Controls.Clear();
            field.DeleteCells();

            this.size = size;
            Enter();
        }

        public Cell[,] Cells { get => field.Cells; }
        public bool State { get => state; set => state = value; }
    }
}
