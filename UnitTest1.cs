using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lesson5;

namespace Task1UnitTests
{
    [TestClass]
    public class Task1Tests
    {
       static private TestContext contextInstance;

        [ClassInitialize]
        public static void ClassInit(TestContext con)
        {
            contextInstance  = con;
        }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", 
                    "|DataDirectory|\\data.csv", "data#csv", DataAccessMethod.Sequential),
            DeploymentItem("data.csv"), TestMethod]
        public void AreDigitsDifferentTest()
        {
            //Arrange
            uint testnumber = uint.Parse(contextInstance.DataRow["number"].ToString());
            bool expected = bool.Parse(contextInstance.DataRow["result"].ToString());
            //Act
            bool actual = Task1.AreDigitsDifferent(testnumber);
            //Assert
            Assert.AreEqual(expected,actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ParseNaturalFromStringTestException()
        {
            //Arrange
            string text = "233f";
            //Act
            uint actual = 0;
            uint expected = Task1.ParseNaturalFromString(text);
            //
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AreDigitsDifferentTrue()
        {
            //Arrange
            uint testnumber = 12345;
            //Act
            bool expected = Task1.AreDigitsDifferent(testnumber);
            //
            Assert.IsTrue(expected);
        }

    }
}
