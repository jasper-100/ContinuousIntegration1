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
    public class GradeConvertertests
    {
        [Test]
        public void GradeConverter_input100_expectA()
        {
            //Arrange
            decimal input = 100m;
            string expected = "Grade is A";

            //Act
            string actual = Grades.GradeConverter(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
