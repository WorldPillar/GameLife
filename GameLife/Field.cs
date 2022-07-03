using System;
using System.Drawing;

namespace GameLife
{
    internal class Field
    {
        private Cell[,] cells;
        private (int, int) point;

        public Field((int, int) point, int rows, int cols)
        {
            this.point = point;
            cells = new Cell[rows, cols];
        }

        public void Draw()
        {
            for (int i = 0; i < cells.GetLength(0); ++i)
                for (int j = 0; j < cells.GetLength(1); ++j)
                {
                    Cell cell = cells[i, j];

                    if (cell.Life)
                        cell.BackColor = Color.Red;
                    else
                        cell.BackColor = Color.White;
                    cell.FlatAppearance.BorderSize = 1;
                    cell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    cell.Location = new System.Drawing.Point(j * 20 + point.Item1, i * 20 + point.Item2);
                    cell.Margin = new System.Windows.Forms.Padding(0);
                    cell.Size = new System.Drawing.Size(20, 20);
                    cell.Name = $"{cell.Life}";
                    cell.Text = cell.Name;
                    cell.TabIndex = 1;
                    cell.UseVisualStyleBackColor = true;
                    cell.Click += new EventHandler(this.Cell_Click);
                }
        }

        private void Cell_Click(object sender, EventArgs e)
        {
            if (sender is Cell cell)
            {
                cell.ChangeState();
                if (cell.Life)
                    cell.BackColor = Color.Red;
                else
                    cell.BackColor = Color.White;
                cell.Text = $"{cell.Life}";
            }
        }

        public Cell[,] Cells { get => cells; }
    }
}
