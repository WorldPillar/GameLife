using System;
using System.Windows.Forms;
using System.Drawing;

namespace GameLife
{
    internal class Cell : Button
    {
        private bool life;
        private int neighbors;

        public Cell(bool life = false)
        {
            this.life = life;
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

        public void ChangeState(object sender = null, EventArgs e = null)
        {
            life = !life;
            if (life)
                BackColor = Color.Red;
            else
                BackColor = Color.White;
        }

        public void Draw(int i, int j, int size)
        {
            if (life)
                BackColor = Color.Red;
            else
                BackColor = Color.White;
            FlatAppearance.BorderSize = 1;
            FlatStyle = FlatStyle.Flat;
            Location = new Point(j * size, i * size);
            Margin = new Padding(0);
            Size = new Size(size, size);
            TabIndex = 1;
            UseVisualStyleBackColor = true;
            Click += new EventHandler(ChangeState);
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
