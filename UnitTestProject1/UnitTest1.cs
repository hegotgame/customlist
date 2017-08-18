using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;
using System.Linq;

namespace MethodUnitTests
{
    [TestClass]
    public class Add
    {
        [TestMethod]
        public void OneAdd()
        {
            //Arrange
            CList<int> custom = new CList<int>();
            int expectedResult = 3;

            //Act
            custom.Add(3);
            //Assert
            Assert.AreEqual(expectedResult, custom[0]);
        }
        [TestMethod]
        public void ThreeOfThreeAdd()
        {
            //Arrange
            CList<string> custom = new CList<string>();
            string expectedResult = "goose";

            //Act
            custom.Add("duck");
            custom.Add("duck");
            custom.Add("goose");
            //Assert
            Assert.AreEqual(expectedResult, custom[2]);
        }
        [TestMethod]
        public void TwoOfThreeAdd()
        {
            //Arrange
            CList<string> custom = new CList<string>();
            string expectedResult = "duck";

            //Act
            custom.Add("duck");
            custom.Add("duck");
            custom.Add("goose");
            //Assert
            Assert.AreEqual(expectedResult, custom[1]);
        }
        [TestMethod]
        public void OneOfThreeAdd()
        {
            //Arrange
            CList<string> custom = new CList<string>();
            string expectedResult = "duck";

            //Act
            custom.Add("duck");
            custom.Add("duck");
            custom.Add("goose");
            //Assert
            Assert.AreEqual(expectedResult, custom[0]);
        }
        [TestMethod]
        public void ThirteenOfFifteenAdd()
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
            custom.Add(14);
            custom.Add(15);
            //Assert
            Assert.AreEqual(expectedResult, custom[12]);
        }
        [TestMethod]
        public void TweleveOfThirteenAdd()
        {
            //Arrange
            CList<int> custom = new CList<int>();
            int expectedResult = 12;

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
            //Assert
            Assert.AreEqual(expectedResult, custom[11]);

        }
    }
        public class Zip
        {
        [TestMethod]
        public void ZipCheck1()
        {
            //Arrange

            CList<string> custom = new CList<string>();
            int[] numbers = { 1, 2, 3, 4 };
            string[] words = { "one", "two", "three" };
            var numbersANDwords = numbers.Zip(words, (first, second) => first + " " + second);
            string expectedResult = "1";

            //Act
            custom.Add(numbersANDwords);

            //Assert
            Assert.AreEqual(expectedResult, custom[0]);
        }

            [TestMethod]
        public void ZipCheck2()
        {
            //Arrange

            CList<string> custom = new CList<string>();
            int[] numbers = { 1, 2, 3, 4 };
            string[] words = { "one", "two", "three" };
            var numbersANDwords = numbers.Zip(words, (first, second) => first + " " + second);
            string expectedResult = "one";

            //Act
            custom.Add(numbersANDwords);

            //Assert
            Assert.AreEqual(expectedResult, custom[1]);
        }
        public void ZipCheck3()
        {
            //Arrange

            CList<string> custom = new CList<string>();
            int[] numbers = { 1, 2, 3, 4 };
            string[] words = { "one", "two", "three" };
            var numbersANDwords = numbers.Zip(words, (first, second) => first + " " + second);
            string expectedResult = "2";

            //Act
            custom.Add(numbersANDwords);

            //Assert
            Assert.AreEqual(expectedResult, custom[2]);
        }
        public void ZipCheck4()
        {
            //Arrange

            CList<string> custom = new CList<string>();
            int[] numbers = { 1, 2, 3, 4 };
            string[] words = { "one", "two", "three" };
            var numbersANDwords = numbers.Zip(words, (first, second) => first + " " + second);
            string expectedResult = "two";

            //Act
            custom.Add(numbersANDwords);

            //Assert
            Assert.AreEqual(expectedResult, custom[3]);
        }
        public void ZipCheck5()
        {
            //Arrange

            CList<string> custom = new CList<string>();
            int[] numbers = { 1, 2, 3, 4 };
            string[] words = { "one", "two", "three" };
            var numbersANDwords = numbers.Zip(words, (first, second) => first + " " + second);
            string expectedResult = "3";

            //Act
            custom.Add(numbersANDwords);

            //Assert
            Assert.AreEqual(expectedResult, custom[4]);
        }
        public void ZipCheck6()
        {
            //Arrange

            CList<string> custom = new CList<string>();
            int[] numbers = { 1, 2, 3, 4 };
            string[] words = { "one", "two", "three" };
            var numbersANDwords = numbers.Zip(words, (first, second) => first + " " + second);
            string expectedResult = "three";

            //Act
            custom.Add(numbersANDwords);

            //Assert
            Assert.AreEqual(expectedResult, custom[5]);
        }
        public void ZipCheck7()
        {
            //Arrange

            CList<string> custom = new CList<string>();
            int[] numbers = { 1, 2, 3, 4 };
            string[] words = { "one", "two", "three" };
            var numbersANDwords = numbers.Zip(words, (first, second) => first + " " + second);
            string expectedResult = "4";

            //Act
            custom.Add(numbersANDwords);

            //Assert
            Assert.AreEqual(expectedResult, custom[6]);
        }
    }
    public class ToString
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

    }
    public class OverloadPlus
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
    }
    public class OverloadMinus
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
    }
}
