using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EverlightCodingTest.Services;
using EverlightCodingTest.Model;

namespace EverlightCodingTest.Tests
{
    [TestClass]
    public class FullBinaryTreeServiceTests
    {
        [TestMethod]
        public void TestBuildFullBinaryTree_ReturnFullBinaryTreeWithData()
        {
            BTreeNode rootNode = new BTreeNode();
            FullBinaryTreeService service = new FullBinaryTreeService();
            int depth = 4;

            BTreeNode[][] bTree = service.BuildFullBinaryTree(ref rootNode, depth);
            //Check if the generated array has the correct depth.
            Assert.AreEqual(depth + 1, bTree.Length);

            for(int i = 0; i < bTree.Length-1; i++)
            {
                for(int j = 0; j < bTree[i].Length; j++)
                {
                    Assert.IsNotNull(bTree[i][j].LeftNode);
                    Assert.IsNotNull(bTree[i][j].RightNode);
                    Assert.IsTrue(bTree[i][j].GateStatus >= 0 && bTree[i][j].GateStatus <= 1);
                    Assert.IsTrue(bTree[i][j].PrifixStatusSum < bTree[i].Length);
                }

            }

            //Test if the leaf nodes are created.
            int length = bTree.Length - 1;
            for (int j = 0; j < bTree[length].Length; j++)
            {
                Assert.IsNull(bTree[length][j].LeftNode);
                Assert.IsNull(bTree[length][j].RightNode);
                Assert.IsTrue(bTree[length][j].GateStatus >= 0 && bTree[length][j].GateStatus <= 1);
                Assert.IsTrue(bTree[length][j].PrifixStatusSum < bTree[length].Length);
            }


        }
    }
}
