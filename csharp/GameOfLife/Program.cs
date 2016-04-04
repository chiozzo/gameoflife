using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class World
    {
        // This is my world. The world may exist beyond your view, but you need to trust that it still exists.
        // Things don't exist just because you believe in them! - Banjo
        List<Cell> currentUniverse = new List<Cell>();
        List<Cell> futureUniverse = new List<Cell>();
    }

    public class Cell
    {
        public Cell(bool state)
        {
            this.isAlive = state;
        }

        public int[] position { get; set; }
        public bool isAlive { get; set; }

        // In order to check dead cells, I need to pass the coordiantes of the dead cell (derived from the live cell I started with)
        // and search my (sorted) list to find how many live neighbors that dead cell has.
        public void setFutureState(int aliveNeighbors)
        {
            if (this.isAlive == true)
            {
                if (aliveNeighbors > 1 && aliveNeighbors < 4)
                {
                    this.isAlive = true;
                }
                else
                {
                    this.isAlive = false;
                }
            }
            else
            {
                if (aliveNeighbors == 3)
                {
                    this.isAlive = true;
                }
                else
                {
                    this.isAlive = false;
                }
            }
        }
    }
}