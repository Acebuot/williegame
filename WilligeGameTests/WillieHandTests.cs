using Microsoft.VisualStudio.TestTools.UnitTesting;
using WilligeGame;
using System;
using System.Collections.Generic;
using System.Text;

namespace WilligeGame.Tests
{
    [TestClass()]
    public class WillieHandTests
    {
        /// <summary>
        /// Use Case A1 - 9, Jack expected Willie = 19
        /// </summary>
        [TestMethod()]
        public void WillieHandTestA1()
        {
            //arrange
            int CardOne = 9;
            int CardTwo = 11;
            WillieHand target = new WillieHand(CardOne, CardTwo);
            int expected = 19;

            //act
            int actual = target.Willie;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void WillieHandTestA2()
        {
            //arrange
            int CardOne = 1;
            int CardTwo = 12;
            WillieHand target = new WillieHand(CardOne, CardTwo);
            int expected = 11;

            //act
            int actual = target.Willie;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void WillieHandTestB1()
        {
            //arrange
            int CardOne = 11;
            int? CardTwo = null;
            WillieHand target = new WillieHand(CardOne, CardTwo);
            int expected = 10;

            //act
            int actual = target.Willie;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void WillieHandTestB3()
        {
            //arrange
            int CardOne = 9;
            int? CardTwo = null;
            WillieHand target = new WillieHand(CardOne, CardTwo);
            int expected = 9;

            //act
            int actual = target.Willie;

            //assert
            Assert.AreEqual(expected, actual);
        }

        public void WillieHandTestB3Second()
        {
            //arrange
            int CardOne = 9;
            WillieHand target = new WillieHand(CardOne);
            int expected = 9;

            //act
            int actual = target.Willie;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void WillieHand2TestA1()
        {
            //arrange
            int CardOne = 7;
            int CardTwo = -1;
            WillieHand target = new WillieHand(CardOne, CardTwo);
            int expected = 19;

            //act
            int actual = target.Willie;

            //assert
            Assert.Fail("Error: Expected Eception not raised... in a loving and caring household");
        }

        [TestMethod()]
        public void WillieHand2TestASecond1()
        {
            int CardOne = 7;
            int CardTwo = -1;

            try
            {
                WillieHand target = new WillieHand(CardOne, CardTwo);
            }
            catch(ArgumentOutOfRangeException e)
            {
                StringAssert.Contains(e.Message, WillieHand.cardcvalueTooLow);
                return;
            }
            Assert.Fail("Expected Exception not raised... in a lovind and caring household");
        }

    }//test class
}