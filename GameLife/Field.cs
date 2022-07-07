using System;

namespace GameLife
{
    internal class Field
    {
        private Cell[,] cells;
        private int rows;
        private int cols;

        public Field(int rows, int cols)
        {
            this.rows = rows;
            this.cols = cols;
            cells = new Cell[rows, cols];

            for (int i = 0; i < rows; ++i)
                for (int j = 0; j < cols; ++j)
                {
                    cells[i, j] = new Cell();
                }
        }

        public void Draw()
        {
            int size = 900 / Math.Min(cols, rows);
            for (int i = 0; i < cells.GetLength(0); ++i)
                for (int j = 0; j < cells.GetLength(1); ++j)
                {
                    cells[i, j].Draw(i, j, size);
                }
        }

        public Cell[,] Cells { get => cells; }
        public (int, int) Size { get => (rows, cols); }
    }
}
