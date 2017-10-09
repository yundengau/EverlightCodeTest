using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EverlightCodingTest.Model;

namespace EverlightCodingTest.Services
{
    /// <summary>
    /// Generate random data for node,and also save the alphabetic index in the node
    /// </summary>
    /// <typeparam name="T">BTreeNode or potientially its derives</typeparam>
    public class ArrayService<T> where T:BTreeNode, new()
    {
        public static void Populate(ref T[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new T() {
                    Index = i ,
                    GateStatus = RandomGenerateService.GetRandomBinary()
                };
            }
        }
    }
}
