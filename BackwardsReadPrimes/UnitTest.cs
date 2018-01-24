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
    }

    public class BackwardsReadPrimes
    {
        public static List<int> Numers()
        {
            return new List<int>();
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
