using System;
using Exam0;
using Xunit;

namespace Project.Tests
{
    public class QuestionTests
    {
        private static Answer[] SampleAnswers() => new[]
        {
            new Answer(1, "A1"),
            new Answer(2, "A2")
        };

        [Fact]
        public void Constructor_SetsAllProperties()
        {
            var answers = SampleAnswers();
            var right = answers[0];

            var question = new Question("Header", "Body", 5, answers, right);

            Assert.Equal("Header", question.Header);
            Assert.Equal("Body", question.Body);
            Assert.Equal(5, question.Mark);
            Assert.Same(answers, question.Answers);
            Assert.Same(right, question.RightAnswer);
        }

        [Fact]
        public void ToString_ReturnsHeaderBodyAndMark()
        {
            var question = new Question("H", "B", 10, SampleAnswers(), SampleAnswers()[0]);

            Assert.Equal("H\nB\n(10 Marks)", question.ToString());
        }

        [Fact]
        public void Clone_CreatesShallowCopy_SharingAnswersArrayReference()
        {
            var answers = SampleAnswers();
            var original = new Question("H", "B", 5, answers, answers[0]);

            var clone = (Question)original.Clone();

            Assert.NotSame(original, clone);
            Assert.Equal(original.Header, clone.Header);
            // MemberwiseClone is a shallow copy: reference-type members are shared.
            Assert.Same(original.Answers, clone.Answers);
        }

        [Theory]
        [InlineData(5, 10, -1)]
        [InlineData(10, 5, 1)]
        [InlineData(7, 7, 0)]
        public void CompareTo_ComparesByMark(int markA, int markB, int expectedSign)
        {
            var q1 = new Question("H1", "B1", markA, SampleAnswers(), SampleAnswers()[0]);
            var q2 = new Question("H2", "B2", markB, SampleAnswers(), SampleAnswers()[0]);

            Assert.Equal(expectedSign, Math.Sign(q1.CompareTo(q2)));
        }

        [Fact]
        public void CompareTo_Null_ReturnsOne()
        {
            var question = new Question("H", "B", 1, SampleAnswers(), SampleAnswers()[0]);

            Assert.Equal(1, question.CompareTo(null));
        }

        [Fact]
        public void CompareTo_NonQuestionObject_ThrowsArgumentException()
        {
            var question = new Question("H", "B", 1, SampleAnswers(), SampleAnswers()[0]);

            Assert.Throws<ArgumentException>(() => question.CompareTo(42));
        }
    }
}
