using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EverlightCodingTest.Services
{
    public class CharDictionaryService
    {
        /// <summary>
        /// Static alphabetic dictionary
        /// </summary>
        public static char[] ContainerDictionary = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K',  'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

        /// <summary>
        /// Get the Alphabet char according to the index.
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public static char GetCharFromIndex(int index)
        {
            return ContainerDictionary[index];
        }

        /// <summary>
        /// Create Dictionary with the key within the range, initial value to 0
        /// </summary>
        /// <param name="range">range index</param>
        /// <returns>Dictionary</returns>
        public static Dictionary<char, int> GetContainerDictionary(int range)
        {
            Dictionary<char, int> containerDictionary = new Dictionary<char, int>();

            int i = 0;
            for (char c = 'A'; c < 'Z'; c++)
            {
                i++;
                if (i > range) break;

                containerDictionary.Add(c, 0);
               
            }

            return containerDictionary;
        }
    }
}
