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

    class World
    {
        // This is my world. The world may exist beyond your view, but you need to trust that it still exists.
        // Things don't exist just because you believe in them! - Banjo
        List<CellNode> currentUniverse = new List<CellNode>();
        List<CellNode> futureUniverse = new List<CellNode>();

    }

    class CellNode
    {
        // Check all neighbors against rules.
        // Mark self as alive/dead based on outcome of rules.
        // For rule 4, neighbors need to be able to alter self and self needs to be able to alter neighbors
        public int[] position { get; set; }
        private bool isAlive { get; set; }
        public CellNode top { get; set; }
        public CellNode topRight { get; set; }
        public CellNode right { get; set; }
        public CellNode bottomRight { get; set; }
        public CellNode bottom { get; set; }
        public CellNode bottomLeft { get; set; }
        public CellNode left { get; set; }
        public CellNode topLeft { get; set; }

        public CellNode() { isAlive = true; }

        public void calculateLife()
        {
            int aliveNeighborCounter = 0;
            // replace with switch
            if (this.top != null)
            {
                aliveNeighborCounter++;
            }
            if (this.topRight != null)
            {
                aliveNeighborCounter++;
            }
            if (this.right != null)
            {
                aliveNeighborCounter++;
            }
            if (this.bottomRight != null)
            {
                aliveNeighborCounter++;
            }
            if (this.bottom != null)
            {
                aliveNeighborCounter++;
            }
            if (this.bottomLeft != null)
            {
                aliveNeighborCounter++;
            }
            if (this.left != null)
            {
                aliveNeighborCounter++;
            }
            if (this.topLeft != null)
            {
                aliveNeighborCounter++;
            }


            if (aliveNeighborCounter < 2)
            { // Any live cell with fewer than two live neighbours dies, as if caused by under-population.
                this.isAlive = false;
            } else if ()
            { // Any dead cell with exactly three live neighbours becomes a live cell, as if by reproduction.
                // For rule 4, neighbors need to be able to alter self and self needs to be able to alter neighbors
                this.makeNeighborsAlive();
            } else if (aliveNeighborCounter > 3)
            { // Any live cell with more than three live neighbours dies, as if by overcrowding.
                this.isAlive = false;
            } else if (aliveNeighborCounter == 2 || aliveNeighborCounter == 3)
            { // Any live cell with two or three live neighbours lives on to the next generation.
                this.isAlive = //continue to be alive
            }
        }
    }
}
