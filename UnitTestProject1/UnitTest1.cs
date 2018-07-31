using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDChallenge2;
namespace UnitTestProject1
{
    [TestClass]
    public class ArraySort_Test
    {
        [TestMethod]
        public void ArraySort_Is_Sorted()
        {
            //given
            int[] toTest = new int[20] { 4, 8, 3, 7, 90, 11, 5, 0, 2, 5, 2, 5, 8, 1, 46, 1, 8, 3, 1, 56 };
            int[] expectedResult = new int[20] { 0, 1, 1, 1, 2, 2, 3, 3, 4, 5, 5, 5, 7, 8, 8, 8, 11, 46, 56, 90 };
            //when
            int[] resultFromFunction = ArraySort.Sort(toTest);
            //then
            Assert.IsNotNull(resultFromFunction);
            CollectionAssert.AreEqual(resultFromFunction, expectedResult);
        }
        [TestMethod]
        public void ArraySort_Empty()
        {
            //given
            int[] toTest = new int[0] {};
            int[] expectedResult = new int[0] {};
            int[] resultFromFunction = ArraySort.Sort(toTest);
            //then
            Assert.IsNotNull(resultFromFunction);
            CollectionAssert.AreEqual(resultFromFunction, expectedResult);

        }
        [TestMethod]
        [ExpectedException(typeof(System.NullReferenceException))]
        public void ArraySort_Null()
        {
            //given
            int[] toTest = null;
            //when
            int[] resultFromFunction = ArraySort.Sort(toTest);
            //then

        }
    }
}
