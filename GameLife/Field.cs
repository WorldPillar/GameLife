using System;

namespace GameLife
{
    internal class Field
    {
        private Cell[,] cells;
        private int size;

        public Field(int size)
        {
            this.size = size;
            int step = 900 / size;
            cells = new Cell[size, size];

            for (int i = 0; i < size; ++i)
                for (int j = 0; j < size; ++j)
                {
                    cells[i, j] = new Cell(i, j, step);
                    cells[i, j].Click += new EventHandler(OnClick);
                }
        }

        private void OnClick(object sender, EventArgs e)
        {
            if (sender is Cell cell)
                cell.ChangeState();
        }

        public void DeleteCells()
        {
            for (int i = 0; i < size; ++i)
                for (int j = 0; j < size; ++j)
                    cells[i, j].Dispose();
        }

        public Cell[,] Cells { get => cells; }

        public bool[,] CellBuff
        {
            get
            {
                bool[,] buf = new bool[size, size];
                for (int i = 0; i < size; ++i)
                    for (int j = 0; j < size; ++j)
                        buf[i, j] = cells[i, j].Life;
                return buf;
            }
        }

        public int Size { get => size; }
    }
}
