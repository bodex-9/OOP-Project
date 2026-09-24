using System;
using System.IO;
using Exam0;
using Xunit;

namespace Project.Tests
{
    public class FinalExamTests
    {
        private static Question[] SampleQuestions() => new Question[]
        {
            new MCQQuestion("MCQ", "2+2=?", 5,
                new[] { new Answer(1, "3"), new Answer(2, "4") },
                new Answer(2, "4")),
            new TrueFalseQuestion("T/F", "C# is OOP", 10,
                new[] { new Answer(1, "True"), new Answer(2, "False") },
                new Answer(1, "True"))
        };

        [Fact]
        public void Constructor_SetsTimeNumberOfQuestionsAndQuestions()
        {
            var questions = SampleQuestions();

            var exam = new FinalExam(60, questions.Length, questions);

            Assert.Equal(60, exam.Time);
            Assert.Equal(questions.Length, exam.NumberOfQuestions);
            Assert.Same(questions, exam.Questions);
        }

        [Fact]
        public void ToString_ReturnsTimeAndNumberOfQuestions()
        {
            var exam = new FinalExam(45, 2, SampleQuestions());

            Assert.Equal("Time : 45\nNumberOfQuestions : 2\n ", exam.ToString());
        }

        [Fact]
        public void Clone_CreatesShallowCopy_SharingQuestionsArrayReference()
        {
            var questions = SampleQuestions();
            var exam = new FinalExam(60, questions.Length, questions);

            var clone = (FinalExam)exam.Clone();

            Assert.NotSame(exam, clone);
            Assert.Equal(exam.Time, clone.Time);
            Assert.Same(exam.Questions, clone.Questions);
        }

        [Theory]
        [InlineData(30, 60, -1)]
        [InlineData(60, 30, 1)]
        [InlineData(45, 45, 0)]
        public void CompareTo_ComparesByTime(int timeA, int timeB, int expectedSign)
        {
            var examA = new FinalExam(timeA, 0, Array.Empty<Question>());
            var examB = new FinalExam(timeB, 0, Array.Empty<Question>());

            Assert.Equal(expectedSign, Math.Sign(examA.CompareTo(examB)));
        }

        [Fact]
        public void CompareTo_Null_ReturnsOne()
        {
            var exam = new FinalExam(30, 0, Array.Empty<Question>());

            Assert.Equal(1, exam.CompareTo(null));
        }

        [Fact]
        public void CompareTo_NonExamObject_ThrowsArgumentException()
        {
            var exam = new FinalExam(30, 0, Array.Empty<Question>());

            Assert.Throws<ArgumentException>(() => exam.CompareTo("not an exam"));
        }

        [Fact]
        public void ShowExam_PrintsQuestionsAndTotalGrade()
        {
            var exam = new FinalExam(60, 2, SampleQuestions());
            var writer = new StringWriter();
            var originalOut = Console.Out;
            Console.SetOut(writer);

            try
            {
                exam.ShowExam();
            }
            finally
            {
                Console.SetOut(originalOut);
            }

            string output = writer.ToString();

            Assert.Contains("FINAL EXAM", output);
            Assert.Contains("2+2=?", output);
            Assert.Contains("C# is OOP", output);
            Assert.Contains("Grade: 15", output); // 5 + 10 marks
        }

        [Fact]
        public void ShowExam_WithNoQuestions_PrintsZeroGrade()
        {
            var exam = new FinalExam(30, 0, Array.Empty<Question>());
            var writer = new StringWriter();
            var originalOut = Console.Out;
            Console.SetOut(writer);

            try
            {
                exam.ShowExam();
            }
            finally
            {
                Console.SetOut(originalOut);
            }

            Assert.Contains("Grade: 0", writer.ToString());
        }
    }
}
