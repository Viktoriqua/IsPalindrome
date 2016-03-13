using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using IsPalindrome;

namespace TestPalindrome
{
    [TestFixture]
    public class PalindromeTest
    {
        [Test]
        public void CheckForEasyCorrectString()
        {
            string stringForTest = "asdsa";
            bool expResult = true;
            bool result = CheckPalindrome.IsPalindrome(stringForTest);
            Assert.AreEqual(expResult, result);
        }
        [Test]
        public void CheckForEasyNotCorrectString()
        {
            string stringForTest = "asdfg";
            bool expResult = false;
            bool result = CheckPalindrome.IsPalindrome(stringForTest);
            Assert.AreEqual(expResult, result);
        }
        [Test]
        public void CheckForCorrectStringWithInCorrectChars()
        {
            string stringForTest = " t>< y+= t!";
            bool expResult = true;
            bool result = CheckPalindrome.IsPalindrome(stringForTest);
            Assert.AreEqual(expResult, result);
        }
        [Test]
        public void CheckForInCorrectStringWithInCorrectChars()
        {
            string stringForTest = "h>_e+l-)p!";
            bool expResult = false;
            bool result = CheckPalindrome.IsPalindrome(stringForTest);
            Assert.AreEqual(expResult, result);
        }
        [Test]
        public void CheckForCorrectStringWithRussianChars()
        {
            string stringForTest = "А роза упала на лапу Азора";
            bool expResult = true;
            bool result = CheckPalindrome.IsPalindrome(stringForTest);
            Assert.AreEqual(expResult, result);
        }
        [Test]
        public void CheckForInCorrectStringWithRussianChars()
        {
            string stringForTest = "А роза упала на лапу Кого-ТО";
            bool expResult = false;
            bool result = CheckPalindrome.IsPalindrome(stringForTest);
            Assert.AreEqual(expResult, result);
        }
        [Test]
        public void CheckForStringOfGaps()
        {
            string stringForTest = "     ";
            bool expResult = true;
            bool result = CheckPalindrome.IsPalindrome(stringForTest);
            Assert.AreEqual(expResult, result);
        }
        [Test]
        public void CheckForPalindromeWithDifferentRegisters()
        {
            string stringForTest = "IdOn'T'noDi";
            bool expResult = true;
            bool result = CheckPalindrome.IsPalindrome(stringForTest);
            Assert.AreEqual(expResult, result);
        }
        [Test]
        public void CheckForStringWithOneCorrectSymbol()
        {
            string stringForTest = " ,.  v?></';  ";
            bool expResult = true;
            bool result = CheckPalindrome.IsPalindrome(stringForTest);
            Assert.AreEqual(expResult, result);
        }
        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void CheckForEmptyString()
        {
            string stringForTest = String.Empty;
            bool expResult = true;
            bool result = CheckPalindrome.IsPalindrome(stringForTest);
            Assert.AreEqual(expResult, result);
        }
        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CheckForNullString()
        {
            string stringForTest = null;
            bool expResult = true;
            bool result = CheckPalindrome.IsPalindrome(stringForTest);
            Assert.AreEqual(expResult, result);
        }

    }
}

