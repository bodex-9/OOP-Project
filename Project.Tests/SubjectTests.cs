using System;
using Exam0;
using Xunit;

namespace Project.Tests
{
    public class SubjectTests
    {
        [Fact]
        public void Constructor_SetsIdAndName_AndExamStartsNull()
        {
            var subject = new Subject(1, "C# OOP");

            Assert.Equal(1, subject.SubjectId);
            Assert.Equal("C# OOP", subject.SubjectName);
            Assert.Null(subject.Exam);
        }

        [Fact]
        public void CreateExam_AssignsExamToSubject()
        {
            var subject = new Subject(1, "C# OOP");
            var exam = new FinalExam(60, 0, Array.Empty<Question>());

            subject.CreateExam(exam);

            Assert.Same(exam, subject.Exam);
        }

        [Fact]
        public void ToString_ReturnsIdAndName()
        {
            var subject = new Subject(2, "Math");

            Assert.Equal("Subject Id: 2\nSubject Name: Math", subject.ToString());
        }
    }
}
