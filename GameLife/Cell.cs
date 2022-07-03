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

        public bool Selection()
        {
            if (life)
            {
                if (neighbors == 2 || neighbors == 3)
                    return false;
                else
                    ChangeState();
            }
            else if (neighbors == 3)
            {
                ChangeState();
            }
            else
                return false;
            return true;
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
