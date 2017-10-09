using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EverlightCodingTest.Services;
using EverlightCodingTest.Model;

namespace EverlightCodingTest.Tests
{
    [TestClass]
    public class ArrayServiceTests
    {
        [TestMethod]
        public void TestPopulate_ReturnFullFilledArray()
        {
            BTreeNode[] bTree = new BTreeNode[10];

            ArrayService<BTreeNode>.Populate(ref bTree);

            Assert.AreEqual(bTree.Length, 10);
            for(int i = 0; i < bTree.Length; i++)
            {
                Assert.AreEqual(i, bTree[i].Index);
                Assert.IsTrue(bTree[i].GateStatus >= 0&& bTree[i].GateStatus <= 1);
                
            }

        }
    }
}
