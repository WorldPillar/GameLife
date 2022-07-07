using System.Drawing;

namespace GameLifePaint
{
    internal class Field
    {
        private Cell[,] cells;
        private int size;
        private int area;

        public Field(int size, int area)
        {
            this.size = size;
            this.area = area;
            cells = new Cell[size, size];

            for (int i = 0; i < size; ++i)
                for (int j = 0; j < size; ++j)
                {
                    cells[i, j] = new Cell(new Point(i, j));
                }
        }

        public Bitmap CreateField()
        {
            Bitmap bmp = new Bitmap(area, area);
            int step = area / size;
            Graphics g = Graphics.FromImage(bmp);
            Pen pen = new Pen(Color.Black, 0.1f);
            for (int i = 0; i <= size; ++i)
            {
                g.DrawLine(pen, step * i, 0, step * i, area);
                g.DrawLine(pen, 0, step * i, area, step * i);
            }
            g.Dispose();
            return bmp;
        }

        public Bitmap UpdateCells(Bitmap bmp)
        {
            int step = area / size;

            Graphics g = Graphics.FromImage(bmp);
            SolidBrush redBrush = new SolidBrush(Color.Red);
            SolidBrush whiteBrush = new SolidBrush(Color.White);

            foreach (Cell cell in cells)
            {
                Rectangle r = new Rectangle(cell.Position.X * step + 1, cell.Position.Y * step + 1, step - 1, step - 1);
                if (cell.Life)
                    g.FillRectangle(redBrush, r);
                else
                    g.FillRectangle(whiteBrush, r);
            }
            g.Dispose();
            return bmp;
        }

        public void CellClick(int X, int Y, Bitmap bmp)
        {
            int step = area / size;
            int x = X / step;
            int y = Y / step;
            Rectangle r = new Rectangle(x * step + 1, y * step + 1, step - 1, step - 1);

            Graphics g = Graphics.FromImage(bmp);
            SolidBrush redBrush = new SolidBrush(Color.Red);
            SolidBrush whiteBrush = new SolidBrush(Color.White);

            cells[x, y].ChangeState();
            if (!cells[x, y].Life)
            {
                g.FillRectangle(whiteBrush, r);
            }
            else
            {
                g.FillRectangle(redBrush, r);
            }
            g.Dispose();
        }

        public Cell[,] Cells { get => cells; }
        public int Size { get => size; }
    }
}
