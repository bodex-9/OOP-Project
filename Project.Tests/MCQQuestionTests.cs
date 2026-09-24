using Exam0;
using Xunit;

namespace Project.Tests
{
    public class MCQQuestionTests
    {
        [Fact]
        public void Constructor_PassesValuesToBaseQuestion()
        {
            var answers = new[] { new Answer(1, "C++"), new Answer(2, "C#") };
            var right = answers[1];

            var mcq = new MCQQuestion("MCQ", "Which language?", 5, answers, right);

            Assert.IsAssignableFrom<Question>(mcq);
            Assert.Equal("MCQ", mcq.Header);
            Assert.Equal("Which language?", mcq.Body);
            Assert.Equal(5, mcq.Mark);
            Assert.Same(answers, mcq.Answers);
            Assert.Same(right, mcq.RightAnswer);
        }
    }
}
