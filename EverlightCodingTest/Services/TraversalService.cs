using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EverlightCodingTest.Model;

namespace EverlightCodingTest.Services
{
    public class TraversalService
    {
        /// <summary>
        /// Simulize the balls traveral
        /// </summary>
        /// <param name="rootNode">Root Node</param>
        /// <param name="depth">Depth</param>
        /// <param name="ballNumber">Ball Number</param>
        /// <returns>Char list showing which containers are not hitted by balls</returns>
        public char[] FindNotHitContainer(BTreeNode rootNode, int depth,int ballNumber)
        {
            Dictionary<char, int> containerDictionary = CharDictionaryService.GetContainerDictionary((int)Math.Pow(2,4));

            for (int i = 0; i < ballNumber; i++)
            {
                int hitIndex = GetHitContainerIndex(rootNode, depth);
                char hitContainer=CharDictionaryService.GetCharFromIndex(hitIndex);
                containerDictionary[hitContainer]++;
            }

            char[] result = containerDictionary.Where(n=>n.Value<1).Select(n=>n.Key).ToArray();

            return result;

        }

        /// <summary>
        /// simulize one ball travesal 
        /// </summary>
        /// <param name="rootNode">Root node</param>
        /// <param name="depth">Depth</param>
        /// <returns>The index of the container which is hitted by the ball</returns>
        public int GetHitContainerIndex(BTreeNode rootNode, int depth)
        {

            BTreeNode currentNode = rootNode;
            BTreeNode lastNode = rootNode;
            for (int i = 0; i < depth; i++)
            {
                if (currentNode.GateStatus == 0)
                {
                    currentNode.GateStatus = 1;
                    currentNode = currentNode.LeftNode;
                }
                else
                {
                    currentNode.GateStatus = 0;
                    currentNode = currentNode.RightNode;
                }
            }

            return currentNode.Index;

        }
    }
}
