using System.Drawing;

namespace GameLifePaint
{
    internal class Cell
    {
        private bool life;
        private int neighbors;
        private readonly Point position;

        public Cell(Point position, bool life = false)
        {
            this.position = position;
            this.life = life;
        }

        public bool Selection()
        {
            bool willdie = life && !(neighbors == 2 || neighbors == 3);
            bool willalife = !life && neighbors == 3;
            neighbors = 0;

            if (willdie || willalife)
            {
                InvertState();
                return true;
            }
            return false;
        }

        public void InvertState()
        {
            life = !life;
        }

        public void AddNeighbor()
        {
            neighbors++;
        }

        public bool State { get => life; set => life = value; }
        public Point Position { get => position; }
    }
}
