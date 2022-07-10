using System;
using System.Drawing;

namespace GameLifePaint
{
    internal class Field
    {
        readonly Cell[,] cells;
        readonly int size;
        readonly int area;

        readonly SolidBrush redBrush = new SolidBrush(Color.Red);
        readonly SolidBrush whiteBrush = new SolidBrush(Color.White);

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
            Pen pen = new Pen(Color.Gray, 1);
            for (int i = 0; i <= size; ++i)
            {
                g.DrawLine(pen, step * i, 0, step * i, area);
                g.DrawLine(pen, 0, step * i, area, step * i);
            }
            pen.Dispose();
            g.Dispose();
            return bmp;
        }

        public void UpdateStep(Bitmap bmp)
        {
            try
            {
                Graphics g = Graphics.FromImage(bmp);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + " when step");
            }
            finally
            {
                Graphics g = Graphics.FromImage(bmp);
                int step = area / size;
                foreach (Cell cell in Cells)
                {
                    if (cell.Selection())
                        DrawRect(cell.Position.X, cell.Position.Y, step, cell.State, g);
                }
                g.Dispose();
            }
        }

        public void UpdateRandom(Bitmap bmp)
        {
            int step = area / size;

            Graphics g = Graphics.FromImage(bmp);

            foreach (Cell cell in cells)
            {
                DrawRect(cell.Position.X, cell.Position.Y, step, cell.State, g);
            }
            g.Dispose();
        }

        public void CellClick(int X, int Y, Bitmap bmp)
        {
            int step = area / size;
            int x = X / step;
            int y = Y / step;

            Cell cell = cells[x, y];
            cell.InvertState();

            try
            {
                Graphics g = Graphics.FromImage(bmp);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + " when click");
            }
            finally
            {
                Graphics g = Graphics.FromImage(bmp);
                DrawRect(x, y, step, cell.State, g);
                g.Dispose();
            }
        }

        private void DrawRect(int X, int Y, int step, bool life, Graphics g)
        {
            if (life)
                g.FillRectangle(redBrush, X * step + 1, Y * step + 1, step - 1, step - 1);
            else
                g.FillRectangle(whiteBrush, X * step + 1, Y * step + 1, step - 1, step - 1);
        }

        public Cell[,] Cells { get => cells; }
        public int Size { get => size; }
    }
}
