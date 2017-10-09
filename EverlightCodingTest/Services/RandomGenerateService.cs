using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EverlightCodingTest.Services
{
    public class RandomGenerateService
    {
        /// <summary>
        /// Get the random int number between 0 and 1
        /// </summary>
        /// <returns>random int number, 0 or 1</returns>
        public static int GetRandomBinary()
        {
            Random random = new Random();
            return random.Next(0, 2);
        }

    }
}
