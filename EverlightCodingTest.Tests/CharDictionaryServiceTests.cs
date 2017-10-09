using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EverlightCodingTest.Services;
using EverlightCodingTest.Model;
using System.Collections;
using System.Collections.Generic;

namespace EverlightCodingTest.Tests
{
    [TestClass]
    public class CharDictionaryServiceTest
    {
        [TestMethod]
        public void TestGetCharFromIndex_ReturnAlphabetAccordingToItsIndex()
        {
            int i = 0;
            for(char c='A'; c<'Z'; c++)
            {
                Assert.AreEqual(c, CharDictionaryService.GetCharFromIndex(i));
                i++;
            }
        }

        [TestMethod]
        public void TestGetContainerDictionary_ReturnRangedDictionary()
        {
            int range = 16;
            Dictionary<char, int> dictionary = CharDictionaryService.GetContainerDictionary(range);
            Assert.IsTrue(dictionary.Count == range);
            for (char c = 'A'; c < 'Q'; c++)
            {
                Assert.IsTrue(dictionary.ContainsKey(c));
            }

        }


    }
}
