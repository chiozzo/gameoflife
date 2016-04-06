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
        // The world only exists where life has once existed. It's a weird way to think about the world, but OK...
        // If a tree falls in the woods and no one is around to see it, does it even exist?
        List<WorldRow> currentUniverse = new List<WorldRow>();
        List<WorldRow> futureUniverse = new List<WorldRow>();
    }

    public class WorldRow
    {
        public List<Cell> Row = new List<Cell>();

        public int rowID { get; set; }

        public WorldRow(int cellCount, int y_position)
        {
            this.rowID = y_position;

            for (int i = 0; i < cellCount; i++)
            {
                // How can I programatically set life on a new Cell? Currently, all new cells are alive.
                this.Row.Add(new Cell(i, y_position, true));
            }
        }
    }

    public class Cell
    {
        public Cell(int x_position, int y_position, bool state)
        {
            this.isAlive = state;
        }

        public int x_position { get; set; }
        public int y_position { get; set; }
        public bool isAlive { get; set; }
        public int countOfAliveNeighbors { get; set; }

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