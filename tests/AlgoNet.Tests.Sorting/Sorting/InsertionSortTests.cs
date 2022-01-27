﻿// Adam Dernis © 2022

using AlgoNet.Tests.Sorting.DataSets;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using IS = AlgoNet.Sorting.InsertionSort;

namespace AlgoNet.Tests.Sorting.Methods
{
    [TestClass]
    public class InsertionSortTests
    {
        private static void RunTest<T>(T[] data)
            where T : IComparable
        {
            IS.Sort(data);
            Common.VerifySorted(data);
        }

        [TestMethod]
        public void PresortedTests()
        {
            foreach (var set in PresortedSets.All)
            {
                RunTest(set);
            }
        }

        [TestMethod]
        public void ReverseOrderTests()
        {
            foreach (var set in ReverseOrderSets.All)
            {
                RunTest(set);
            }
        }

        [TestMethod]
        public void RandomizedTests()
        {
            foreach (var set in RandomizedSets.All)
            {
                RunTest(set);
            }
        }
    }
}
