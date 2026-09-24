using System;
using Exam0;
using Xunit;

namespace Project.Tests
{
    public class AnswerTests
    {
        [Fact]
        public void Constructor_SetsAnswerIdAndAnswerText()
        {
            var answer = new Answer(1, "C#");

            Assert.Equal(1, answer.AnswerId);
            Assert.Equal("C#", answer.AnswerText);
        }

        [Fact]
        public void ToString_ReturnsIdColonText()
        {
            var answer = new Answer(2, "Java");

            Assert.Equal("2:Java", answer.ToString());
        }

        [Fact]
        public void Clone_ReturnsDifferentInstanceWithSameValues()
        {
            var original = new Answer(3, "Python");

            var clone = (Answer)original.Clone();

            Assert.NotSame(original, clone);
            Assert.Equal(original.AnswerId, clone.AnswerId);
            Assert.Equal(original.AnswerText, clone.AnswerText);
        }

        [Theory]
        [InlineData(1, 2, -1)] // smaller id -> negative
        [InlineData(2, 1, 1)]  // larger id -> positive
        [InlineData(3, 3, 0)]  // equal ids -> zero
        public void CompareTo_ComparesByAnswerId(int idA, int idB, int expectedSign)
        {
            var a = new Answer(idA, "A");
            var b = new Answer(idB, "B");

            int result = a.CompareTo(b);

            Assert.Equal(expectedSign, Math.Sign(result));
        }

        [Fact]
        public void CompareTo_Null_ReturnsOne()
        {
            var answer = new Answer(1, "A");

            Assert.Equal(1, answer.CompareTo(null));
        }

        [Fact]
        public void CompareTo_NonAnswerObject_ThrowsArgumentException()
        {
            var answer = new Answer(1, "A");

            Assert.Throws<ArgumentException>(() => answer.CompareTo("not an answer"));
        }
    }
}
