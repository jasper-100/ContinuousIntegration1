using MidtermPractice;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGradeConverter
{
    [TestFixture]
    public class GradeConverterTests
    {
        [Test]
        public void GradeConverter_input101_expectInvalidInput()
        {
            //3"a" Arrange
            decimal input = 101.00M;
            string expected = "It is a invalid input, please retry";

            //Act
            string actual = Grades.GradeConverter(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GradeConverter_inputLessThan0_expectInvalidInput()
        {
            //3"a" Arrange
            decimal input = -5.00M;
            string expected = "It is a invalid input, please retry";

            //Act
            string actual = Grades.GradeConverter(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GradeConverter_input100_expectA()
        {
            //3"a" Arrange
            decimal input = 100.00M;
            string expected = "Grade is A";

            //Act
            string actual = Grades.GradeConverter(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GradeConverter_input80_expectA()
        {
            //3"a" Arrange
            decimal input = 80.00M;
            string expected = "Grade is A";

            //Act
            string actual = Grades.GradeConverter(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GradeConverter_input95_expectA()
        {
            //3"a" Arrange
            decimal input = 95.50M;
            string expected = "Grade is A";

            //Act
            string actual = Grades.GradeConverter(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GradeConverter_input79_expectB()
        {
            //3"a" Arrange
            decimal input = 79.90M;
            string expected = "Grade is B";

            //Act
            string actual = Grades.GradeConverter(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GradeConverter_input75_expectB()
        {
            //3"a" Arrange
            decimal input = 75.00M;
            string expected = "Grade is B";

            //Act
            string actual = Grades.GradeConverter(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GradeConverter_input70_expectB()
        {
            //3"a" Arrange
            decimal input = 70.00M;
            string expected = "Grade is B";

            //Act
            string actual = Grades.GradeConverter(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GradeConverter_input69_expectC()
        {
            //3"a" Arrange
            decimal input = 69.90M;
            string expected = "Grade is C";

            //Act
            string actual = Grades.GradeConverter(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GradeConverter_input63_expectC()
        {
            //3"a" Arrange
            decimal input = 63.50M;
            string expected = "Grade is C";

            //Act
            string actual = Grades.GradeConverter(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GradeConverter_input60_expectC()
        {
            //3"a" Arrange
            decimal input = 60.00M;
            string expected = "Grade is C";

            //Act
            string actual = Grades.GradeConverter(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GradeConverter_input59_expectD()
        {
            //3"a" Arrange
            decimal input = 59.90M;
            string expected = "Grade is D";

            //Act
            string actual = Grades.GradeConverter(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GradeConverter_input55_expectD()
        {
            //3"a" Arrange
            decimal input = 55.00M;
            string expected = "Grade is D";

            //Act
            string actual = Grades.GradeConverter(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GradeConverter_input0_expectF()
        {
            //3"a" Arrange
            decimal input = 0.00M;
            string expected = "Grade is Fail";

            //Act
            string actual = Grades.GradeConverter(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GradeConverter_input54_expectF()
        {
            //3"a" Arrange
            decimal input = 54.90M;
            string expected = "Grade is Fail";

            //Act
            string actual = Grades.GradeConverter(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
