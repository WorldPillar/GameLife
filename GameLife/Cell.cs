using System;
using System.Windows.Forms;
using System.Drawing;

namespace GameLife
{
    internal class Cell : Button
    {
        private bool life;
        private int neighbors;

        public Cell(int i, int j, int size, bool life = false)
        {
            this.life = life;
            BackColor = Color.White;
            FlatStyle = FlatStyle.Flat;
            Location = new Point(j * size, i * size);
            Size = new Size(size, size);
        }

        public void Selection()
        {
            if (life)
            {
                if (!(neighbors == 2 || neighbors == 3))
                    ChangeState();
            }
            else if (neighbors == 3)
            {
                ChangeState();
            }
            neighbors = 0;
        }

        public void ChangeState()
        {
            life = !life;
            if (life)
                BackColor = Color.Red;
            else
                BackColor = Color.White;
        }

        public bool Life { get => life; set => life = value; }
        public int Neighbor { get => neighbors; set => neighbors = value; }
        public bool State
        {
            get { return life; }
            set
            {
                if (value)
                {
                    life = value;
                    BackColor = Color.Red;
                }
                else
                {
                    life = value;
                    BackColor = Color.White;
                }
            }
        }
    }
}
