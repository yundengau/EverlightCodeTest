using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EverlightCodingTest.Services;
using EverlightCodingTest.Model;
using System.Linq;

namespace EverlightCodingTest.Tests
{
    [TestClass]
    public class PredictionServiceTests
    {
        
        [TestMethod]
        public void TestPredict_ReturnPredictedResultCharArray()
        {
            PredictionService service = new PredictionService();
            FullBinaryTreeService buildTreeService = new FullBinaryTreeService();
            BTreeNode rootNode = new BTreeNode();
            int depth = 4;
            BTreeNode[][] bTree = buildTreeService.BuildFullBinaryTree(ref rootNode, depth);
            int ballNumber = 13;
            char[] result=service.Predict(bTree, depth, ballNumber);

            Assert.AreEqual((1 << depth) - ballNumber, result.Length);

            BTreeNode[] leafList = bTree[depth];
            var orderedLeafList = leafList.OrderByDescending(n => n.PrifixStatusSum).ToArray();

            for (int i = 0; i < result.Length; i++)
            {
                //the sorted array of the certain number of nodes should match the out come of simulation
                Assert.IsTrue(Array.IndexOf(result, CharDictionaryService.GetCharFromIndex(orderedLeafList[i].Index)) > -1);
            }


        }
    }
}
