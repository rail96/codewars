using System;
using System.Collections.Generic;
using Codewars;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace TestsForCodeWars
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void EmptyTest()
        {
            Assert.AreEqual("Thi1s is2 3a T4est", Kata.Order("is2 Thi1s T4est 3a"));
            Assert.AreEqual("Fo1r the2 g3ood 4of th5e pe6ople", Kata.Order("4of Fo1r pe6ople g3ood th5e the2"));
            Assert.AreEqual("", Kata.Order(""));
        }

        [TestMethod]
        public void ConvertingTest()
        {
            Assert.AreEqual(1, Kata.Converting(new int[]{ 0, 0, 0, 1 }));
            Assert.AreEqual(2, Kata.Converting(new int[]{ 0, 0, 1, 0 }));
            Assert.AreEqual(5, Kata.Converting(new int[]{ 0, 1, 0, 1 }));
            Assert.AreEqual(9, Kata.Converting(new int[]{ 1, 0, 0, 1 }));
            Assert.AreEqual(2, Kata.Converting(new int[]{ 0, 0, 1, 0 }));
            Assert.AreEqual(6, Kata.Converting(new int[]{ 0, 1, 1, 0 }));
            Assert.AreEqual(15, Kata.Converting(new int[]{ 1, 1, 1, 1 }));
            Assert.AreEqual(11, Kata.Converting(new int[]{ 1, 0, 1, 1 }));
        }

        [TestMethod]
        public void LikesTest()
        {
            Assert.AreEqual("no one likes this", Kata.Likes(new string[0]));
            Assert.AreEqual("Peter likes this", Kata.Likes(new string[] { "Peter" }));
            Assert.AreEqual("Jacob and Alex like this", Kata.Likes(new string[] { "Jacob", "Alex" }));
            Assert.AreEqual("Max, John and Mark like this", Kata.Likes(new string[] { "Max", "John", "Mark" }));
            Assert.AreEqual("Alex, Jacob and 2 others like this", Kata.Likes(new string[] { "Alex", "Jacob", "Mark", "Max" }));
        }

        [TestMethod]
        public void SquareTest()
        {
            Assert.AreEqual(-1, Kata.FindNextSquare(155));
            Assert.AreEqual(144, Kata.FindNextSquare(121));
            Assert.AreEqual(676, Kata.FindNextSquare(625));
            Assert.AreEqual(320356, Kata.FindNextSquare(319225));
            Assert.AreEqual(15241630849, Kata.FindNextSquare(15241383936));
        }

       /* [TestMethod]
        public void MoveZeroesTest()
        {
            Assert.AreEqual(new int[] { 1, 2, 1, 1, 3, 1, 0, 0, 0, 0 }, Kata.MoveZeroes(new int[] { 1, 2, 0, 1, 0, 1, 0, 3, 0, 1 }));
        }
        */
        [TestCase(new[] { 1, 2, 2, 2 }, ExpectedResult = 1)]
        [TestCase(new[] { -2, 2, 2, 2 }, ExpectedResult = -2)]
        [TestCase(new[] { 11, 11, 14, 11, 11 }, ExpectedResult = 14)]
        public int BaseTest(IEnumerable<int> numbers)
        {
            return Kata.GetUnique(numbers);
        }

        public void BasicTests()
        {
            Assert.AreEqual("4 2/3", Kata.MixedFraction("42/9"));
            Assert.AreEqual("2", Kata.MixedFraction("6/3"));
            Assert.AreEqual("1", Kata.MixedFraction("1/1"));
            Assert.AreEqual("1", Kata.MixedFraction("11/11"));
            Assert.AreEqual("2/3", Kata.MixedFraction("4/6"));
            Assert.AreEqual("0", Kata.MixedFraction("0/18891"));
            Assert.AreEqual("-1 3/7", Kata.MixedFraction("-10/7"));
            Assert.AreEqual("3 1/7", Kata.MixedFraction("-22/-7"));
            Assert.AreEqual("-195595/564071", Kata.MixedFraction("-195595/564071"));

            Assert.Throws(typeof(DivideByZeroException), delegate { Kata.MixedFraction("0/0"); });
            Assert.Throws(typeof(DivideByZeroException), delegate { Kata.MixedFraction("3/0"); });
        }
    }
}
