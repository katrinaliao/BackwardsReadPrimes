using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BackwardsReadPrimes
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void Input1_ReturnFalse()
        {
            var input = 1;
            var result = BackwardsReadPrimes.IsPrime(input);;
            var expect = false;
            Assert.AreEqual(expect, result);
        }

        [TestMethod]
        public void Input2_ReturnTrue()
        {
            var input = 2;
            var result = BackwardsReadPrimes.IsPrime(input); ;
            var expect = true;
            Assert.AreEqual(expect, result);
        }

        [TestMethod]
        public void Input3_ReturnTrue()
        {
            var input = 3;
            var result = BackwardsReadPrimes.IsPrime(input); ;
            var expect = true;
            Assert.AreEqual(expect, result);
        }

        [TestMethod]
        public void Input4_ReturnFalse()
        {
            var input = 4;
            var result = BackwardsReadPrimes.IsPrime(input); ;
            var expect = false;
            Assert.AreEqual(expect, result);
        }

        [TestMethod]
        public void Input11_ReturnTrue()
        {
            var input = 11;
            var result = BackwardsReadPrimes.IsPrime(input); ;
            var expect = true;
            Assert.AreEqual(expect, result);
        }

        [TestMethod]
        public void Input1_and_1_Return1()
        {
            var input1 = 1;
            var input2 = 1;
            var result = BackwardsReadPrimes.Numers(input1, input2); ;
            var expect = new List<int>(){1};
            CollectionAssert.AreEqual(expect, result);
        }

        [TestMethod]
        public void Input1_and_2_Return1and2()
        {
            var input1 = 1;
            var input2 = 2;
            var result = BackwardsReadPrimes.Numers(input1, input2); ;
            var expect = new List<int>() { 1, 2 };
            CollectionAssert.AreEqual(expect, result);
        }

        [TestMethod]
        public void Input1_and_4_Return1to4()
        {
            var input1 = 1;
            var input2 = 4;
            var result = BackwardsReadPrimes.Numers(input1, input2); ;
            var expect = new List<int>() { 1, 2, 3, 4 };
            CollectionAssert.AreEqual(expect, result);
        }
    }

    public class BackwardsReadPrimes
    {
        //找出一個區間所有的 prime，而且這個 prime 正反的數字都要是 prime 並且不可以是回文
        public static List<int> Numers(int start, int end)
        {
            var numbers = new List<int>();
            for (int i = start; i <= end; i++)
            {
                numbers.Add(i);
            }
            return numbers;
        }

        public static bool IsPrime(int param)
        {
            if (param == 1)
                return false;
            if (param == 2)
                return true;

            for (int i = 2; i <= Math.Ceiling(Math.Sqrt(param)); ++i)
            {
                if (param % i == 0) return false;
            }

            return true;
        }
    }
}
