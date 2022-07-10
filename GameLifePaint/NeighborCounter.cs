using System;

namespace GameLifePaint
{
    internal class NeighborCounter
    {
        readonly Cell[,] cells;

        public NeighborCounter(Cell[,] cells)
        {
            this.cells = cells;
        }

        public void CountNeighbors(int row, int col, int size)
        {
            bool roof = row % (size - 1) == 0;
            bool wall = col % (size - 1) == 0;
            bool corner = roof && wall;
            bool inner = !roof && !wall;

            Cell cell = cells[row, col];
            if (inner)
                InnerState(row, col, cell);
            else if (!corner)
                WallState(row, col, size, cell);
            else
                CornerState(row, col, size, cell);

        }

        private void InnerState(int i, int j, Cell cell)
        {
            for (int k = i - 1; k < i + 2; ++k)
                for (int l = j - 1; l < j + 2; ++l)
                {
                    if (k == i && l == j)
                        continue;
                    if (cells[k, l].State)
                        cell.AddNeighbor();
                }
        }

        private void CornerState(int i, int j, int size, Cell cell)
        {
            int last = size - 1;
            int[] ki = { i, Math.Abs(i - 1) % last, Math.Abs(i - 1) % last };
            int[] lj = { Math.Abs(j - 1) % last, Math.Abs(j - 1) % last, j };

            CornerWall(ki, lj, cell);
        }

        private void WallState(int i, int j, int size, Cell cell)
        {
            int last = size - 1;
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
                if (cells[ki[i], lj[j]].State)
                    cell.AddNeighbor();
            }
        }
    }
}
