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
    public class ClassTests
    {
        public int Id { get; set; }
        public string? Name { get;  set; }

        [Test]
        public void TestClassName()
        {
            // Arrange
            ClassTests myClass = new ClassTests
            {
                Name = "Math"
            };
            // Act
            string className = myClass.Name;
            // Assert
            Assert.That(className, Is.EqualTo("Math"));
        }
        [Test]
        public void TestClassId()
        {
            // Arrange
            ClassTests myClass = new ClassTests
            {
                Id = 1
            };
            // Act
            int classId = myClass.Id;
            // Assert
            Assert.That(classId, Is.EqualTo(1));
        }
    }
}

