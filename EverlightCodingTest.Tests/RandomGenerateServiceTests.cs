using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EverlightCodingTest.Services;
using EverlightCodingTest.Model;

namespace EverlightCodingTest.Tests
{
    [TestClass]
    public class RandomGenerateServiceTests
    {
        [TestMethod]
        public void RandomGenerateServiceTest_ReturnRandom0or1()
        {
            for(int i = 0; i < 1000; i++)
            {
                int random = RandomGenerateService.GetRandomBinary();
                if (random != 1) Assert.IsTrue(random == 0);
                if (random != 0) Assert.IsTrue(random == 1);
                
            }
        }
    }
}
