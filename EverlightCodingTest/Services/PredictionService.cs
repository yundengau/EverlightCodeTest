using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EverlightCodingTest.Model;
using EverlightCodingTest.Services;

namespace EverlightCodingTest.Services
{
    public class PredictionService
    {
        /// <summary>
        /// Predict the which containers are not hitted by balls
        /// </summary>
        /// <param name="bTree">Btree</param>
        /// <param name="depth">Depth of the Btree</param>
        /// <param name="ballNumber">Ball number</param>
        /// <returns>Char chains showing which containers are not hitted by balls</returns>
        public char[] Predict(BTreeNode[][] bTree, int depth, int ballNumber)
        {
            if (bTree.Length != (depth + 1)) return null;

            char[] results=bTree[depth].Where(n => n.PrifixStatusSum > (ballNumber - 1)).Select(n => CharDictionaryService.GetCharFromIndex(n.Index)).ToArray();
            return results;
        }
    }
}
