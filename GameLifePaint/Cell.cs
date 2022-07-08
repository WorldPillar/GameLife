using System;
using System.Windows.Forms;
using System.Drawing;

namespace GameLifePaint
{
    internal class Cell
    {
        private bool life;
        private int neighbors;
        private Point position;

        public Cell(Point position, bool life = false)
        {
            this.position = position;
            this.life = life;
        }

        public bool Selection()
        {
            if (life)
            {
                if (!(neighbors == 2 || neighbors == 3))
                {
                    ChangeState();
                    neighbors = 0;
                    return true;
                }
            }
            else if (neighbors == 3)
            {
                ChangeState();
                neighbors = 0;
                return true;
            }
            neighbors = 0;
            return false;
        }

        public void ChangeState()
        {
            life = !life;
        }

        public bool Life { get => life; set => life = value; }
        public int Neighbor { get => neighbors; set => neighbors = value; }
        public bool State
        {
            get { return life; }
            set { life = value; }
        }
        public Point Position { get => position; }
    }
}
