using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EverlightCodingTest.Model;


namespace EverlightCodingTest.Services
{
    public class FullBinaryTreeService
    {

        /// <summary>
        /// Build full binary tree
        /// </summary>
        /// <param name="rootNode">Root node</param>
        /// <param name="depth">Depth of the btree</param>
        /// <returns>Created btree</returns>
        public BTreeNode[][] BuildFullBinaryTree(ref BTreeNode rootNode, int depth)
        {
            BTreeNode[][] BTree = new BTreeNode[depth+1][];
            BTree[0] = new BTreeNode[1];
            BTree[0][0] = rootNode;
            rootNode.GateStatus = RandomGenerateService.GetRandomBinary();
            rootNode.PrifixStatusSum = 0;

            if (depth == 1) return null;

            for(int i = 1; i <=depth; i++)
            {
                Int32 arrayLengh = 1 << i;
                BTree[i]  = new BTreeNode[arrayLengh];
                
                ArrayService<BTreeNode>.Populate(ref BTree[i]);

                for(int j = 0; j < BTree[i - 1].Length; j++)
                {
                    BTree[i - 1][j].LeftNode  = BTree[i][2 * j];
                    if (BTree[i - 1][j].GateStatus == 1) BTree[i][2 * j].PrifixStatusSum = BTree[i - 1][j].PrifixStatusSum + (1<<(i-1));
                    else BTree[i][2 * j].PrifixStatusSum= BTree[i - 1][j].PrifixStatusSum;

                    BTree[i - 1][j].RightNode = BTree[i][2 * j + 1];
                    if (BTree[i - 1][j].GateStatus == 0) BTree[i][2 * j + 1].PrifixStatusSum = BTree[i - 1][j].PrifixStatusSum + (1<<(i-1));
                    else BTree[i][2 * j + 1].PrifixStatusSum = BTree[i - 1][j].PrifixStatusSum;
                }
                
            }

            return BTree;

        }

       
    }
}
