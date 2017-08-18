using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace RemoveMethodUnitTests
{
    [TestClass]
    public class RemoveMethodUnitTests
    {
        [TestMethod]
        public void OneRemove()
        {
            //Arrange
            CList<int> custom = new CList<int>();

            int? expectedResult = null;

            //Act
            custom.Add(67);
            custom.Remove(67);
            //Assert
            Assert.AreEqual(expectedResult, custom[0]);
        }
        [TestMethod]
        public void OneOfThreeRemove()
        {
            //Arrange
            CList<string> custom = new CList<string>();
            string expectedResult = "goose";

            //Act
            custom.Add("duck");
            custom.Add("duck");
            custom.Add("goose");
            custom.Remove("duck");
            //Assert
            Assert.AreEqual(expectedResult, custom[1]);
        }
        [TestMethod]
        public void TwoOfThreeRemove()
        {
            //Arrange
            CList<string> custom = new CList<string>();
            string expectedResult = "goose";

            //Act
            custom.Add("duck");
            custom.Add("duck");
            custom.Add("goose");
            custom.Remove("duck");
            custom.Remove("duck");
            //Assert
            Assert.AreEqual(expectedResult, custom[0]);
        }
        [TestMethod]
        public void ThirteenOfFifteenRemove()
        {
            //Arrange
            CList<int> custom = new CList<int>();
            int expectedResult = 14;

            //Act
            custom.Add(1);
            custom.Add(2);
            custom.Add(3);
            custom.Add(4);
            custom.Add(5);
            custom.Add(6);
            custom.Add(7);
            custom.Add(8);
            custom.Add(9);
            custom.Add(10);
            custom.Add(11);
            custom.Add(12);
            custom.Add(13);
            custom.Add(14);
            custom.Add(15);
            custom.Remove(13);
            //Assert
            Assert.AreEqual(expectedResult, custom[12]);
        }
        [TestMethod]
        public void TweleveOfThirteenRemove()
        {
            //Arrange
            CList<int> custom = new CList<int>();
            int expectedResult = 13;

            //Act
            custom.Add(1);
            custom.Add(2);
            custom.Add(3);
            custom.Add(4);
            custom.Add(5);
            custom.Add(6);
            custom.Add(7);
            custom.Add(8);
            custom.Add(9);
            custom.Add(10);
            custom.Add(11);
            custom.Add(12);
            custom.Add(13);
            custom.Remove(12);
            //Assert
            Assert.AreEqual(expectedResult, custom[11]);
        }
    }
}
