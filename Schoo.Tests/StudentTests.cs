using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using School;


namespace School.Tests
{
    [TestFixture]
    public class StudentTests
    {
        [Test]
        public void TestStudentName()
        {
            // Arrange
            Student student = new Student
            {
                Name = "John Doe"
            };
            // Act
            string studentName = student.Name;
            // Assert
            Assert.AreEqual("John Doe", studentName);
        }
        [Test]
        public void TestStudentAddress()
        {
            // Arrange
            Student student = new Student
            {
                Address = "123 Main St"
            };
            // Act
            string studentAddress = student.Address;
            // Assert
            Assert.AreEqual("123 Main St", studentAddress);
        }
    }
}

