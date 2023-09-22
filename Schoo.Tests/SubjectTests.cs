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
    public class SubjectTests
    {
        public string? Name { get; set; }
        public int Id { get;  set; }

        [Test]
        public void TestSubjectName()
        {
            // Arrange
            SubjectTests subject = new SubjectTests
            {
                Name = "Science"
            };
            // Act
            string subjectName = subject.Name;
            // Assert
            Assert.That(subjectName, Is.EqualTo("Science"));
        }

        [Test]
        public void TestSubjectId()
        {
            // Arrange
            SubjectTests subject = new SubjectTests
            {
                Id = 2
            };
            // Act
            int subjectId = subject.Id;
            // Assert
            Assert.That(subjectId, Is.EqualTo(2));
        }
    }
}
