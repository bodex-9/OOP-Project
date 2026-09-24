using Exam0;
using Xunit;

namespace Project.Tests
{
    public class TrueFalseQuestionTests
    {
        [Fact]
        public void Constructor_PassesValuesToBaseQuestion()
        {
            var trueAnswer = new Answer(1, "True");
            var falseAnswer = new Answer(2, "False");
            var answers = new[] { trueAnswer, falseAnswer };

            var tf = new TrueFalseQuestion("T/F", "C# is OOP.", 5, answers, trueAnswer);

            Assert.IsAssignableFrom<Question>(tf);
            Assert.Equal("T/F", tf.Header);
            Assert.Equal("C# is OOP.", tf.Body);
            Assert.Equal(5, tf.Mark);
            Assert.Same(answers, tf.Answers);
            Assert.Same(trueAnswer, tf.RightAnswer);
        }
    }
}
