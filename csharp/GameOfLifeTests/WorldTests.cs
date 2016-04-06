using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GameOfLife;

namespace GameOfLifeTests
{
    [TestClass]
    public class WorldTests
    {
        [TestMethod]
        public void EnsureInstantiateNewRow()
        {
            WorldRow test = new WorldRow(5, 0);
            Assert.AreEqual(test.Row.Count, 5);
        }

        [TestMethod]
        public void TestAliveStatusOfNewRowCells()
        {
            WorldRow test = new WorldRow(5, 0);
            for (int i = 0; i < test.Row.Count; i++)
            {
                Assert.AreEqual(test.Row[i].isAlive, true);
            }
        }
    }
}
