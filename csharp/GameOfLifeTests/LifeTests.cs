using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GameOfLife;

namespace GameOfLifeTests
{
    [TestClass]
    public class LifeTests
    {
        // INITIALLY ALIVE

        [TestMethod]
        public void EnsureZeroNeighborsCauseDeath()
        {
            // Arrange - create cell
            Cell testCell = new Cell(1,1,true);
            // Act - get future state of cell and assign to current state of cell
            testCell.setFutureState(0);
            // Assert
            Assert.AreEqual(testCell.isAlive, false);
        }

        [TestMethod]
        public void EnsureOneNeighborCausesDeath()
        {
            // Arrange - create cell
            Cell testCell = new Cell(1,1,true);
            // Act - get future state of cell and assign to current state of cell
            testCell.setFutureState(1);
            // Assert
            Assert.AreEqual(testCell.isAlive, false);
        }

        [TestMethod]
        public void EnsureTwoNeighborsPerpetuatesLife()
        {
            Cell testCell = new Cell(1,1,true);
            testCell.setFutureState(2);
            Assert.AreEqual(testCell.isAlive, true);
        }

        [TestMethod]
        public void EnsureThreeNeighborsPerpetuatesLife()
        {
            Cell testCell = new Cell(1,1,true);
            testCell.setFutureState(3);
            Assert.AreEqual(testCell.isAlive, true);
        }

        [TestMethod]
        public void EnsureFourNeighborsCausesDeath()
        {
            Cell testCell = new Cell(1,1,true);
            testCell.setFutureState(4);
            Assert.AreEqual(testCell.isAlive, false);
        }

        [TestMethod]
        public void EnsureFiveNeighborsCausesDeath()
        {
            Cell testCell = new Cell(1,1,true);
            testCell.setFutureState(5);
            Assert.AreEqual(testCell.isAlive, false);
        }

        [TestMethod]
        public void EnsureSixNeighborsCausesDeath()
        {
            Cell testCell = new Cell(1,1,true);
            testCell.setFutureState(6);
            Assert.AreEqual(testCell.isAlive, false);
        }

        [TestMethod]
        public void EnsureSevenNeighborsCausesDeath()
        {
            Cell testCell = new Cell(1,1,true);
            testCell.setFutureState(7);
            Assert.AreEqual(testCell.isAlive, false);
        }

        [TestMethod]
        public void EnsureEightNeighborsCausesDeath()
        {
            Cell testCell = new Cell(1,1,true);
            testCell.setFutureState(8);
            Assert.AreEqual(testCell.isAlive, false);
        }

        // INITIALLY DEAD

        [TestMethod]
        public void EnsureZeroNeighborsPerpetuatesDeath()
        {
            Cell testCell = new Cell(1,1,false);
            testCell.setFutureState(0);
            Assert.AreEqual(testCell.isAlive, false);
        }

        [TestMethod]
        public void EnsureOneNeighborPerpetuatesDeath()
        {
            Cell testCell = new Cell(1,1,false);
            testCell.setFutureState(1);
            Assert.AreEqual(testCell.isAlive, false);
        }

        [TestMethod]
        public void EnsureTwoNeighborsPerpetuatesDeath()
        {
            Cell testCell = new Cell(1,1,false);
            testCell.setFutureState(2);
            Assert.AreEqual(testCell.isAlive, false);
        }

        [TestMethod]
        public void EnsureThreeNeighborsCauseRebirth()
        {
            Cell testCell = new Cell(1,1,false);
            testCell.setFutureState(3);
            Assert.AreEqual(testCell.isAlive, true);
        }

        [TestMethod]
        public void EnsureFourNeighborsPerpetuatesDeath()
        {
            Cell testCell = new Cell(1,1,false);
            testCell.setFutureState(4);
            Assert.AreEqual(testCell.isAlive, false);
        }

        [TestMethod]
        public void EnsureFiveNeighborsPerpetuatesDeath()
        {
            Cell testCell = new Cell(1,1,false);
            testCell.setFutureState(5);
            Assert.AreEqual(testCell.isAlive, false);
        }

        [TestMethod]
        public void EnsureSixNeighborsPerpetuatesDeath()
        {
            Cell testCell = new Cell(1,1,false);
            testCell.setFutureState(6);
            Assert.AreEqual(testCell.isAlive, false);
        }

        [TestMethod]
        public void EnsureSevenNeighborsPerpetuatesDeath()
        {
            Cell testCell = new Cell(1,1,false);
            testCell.setFutureState(7);
            Assert.AreEqual(testCell.isAlive, false);
        }

        [TestMethod]
        public void EnsureEightNeighborsPerpetuatesDeath()
        {
            Cell testCell = new Cell(1,1,false);
            testCell.setFutureState(8);
            Assert.AreEqual(testCell.isAlive, false);
        }
    }
}
