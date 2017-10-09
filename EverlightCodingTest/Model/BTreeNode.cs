using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EverlightCodingTest.Services;

namespace EverlightCodingTest.Model
{
    public class BTreeNode
    {
        /// <summary>
        /// Save the Gate status, 0 means the gate is open to left, 1 means the gate open to right
        /// </summary>
        public int GateStatus { get; set; }

        /// <summary>
        /// Save the all the 
        /// </summary>
        public int PrifixStatusSum { get; set; }

        /// <summary>
        /// Point to the left child node of the current node
        /// </summary>
        public BTreeNode LeftNode { get; set; }

        /// <summary>
        /// Point to the right child node of the current node
        /// </summary>
        public BTreeNode RightNode { get; set; }

        /// <summary>
        /// Save the information for the Alphabetic index.
        /// </summary>
        public int Index { get; set; }


       
    }
}
