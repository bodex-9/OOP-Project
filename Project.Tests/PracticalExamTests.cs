using System;
using System.IO;
using Exam0;
using Xunit;

namespace Project.Tests
{
    public class PracticalExamTests
    {
        private static Question[] SampleQuestions() => new Question[]
        {
            new MCQQuestion("MCQ", "Pick the odd one", 5,
                new[] { new Answer(1, "Dog"), new Answer(2, "Cat"), new Answer(3, "Car") },
                new Answer(3, "Car"))
        };

        [Fact]
        public void Constructor_SetsProperties()
        {
            var questions = SampleQuestions();

            var exam = new PracticalExam(90, questions.Length, questions);

            Assert.Equal(90, exam.Time);
            Assert.Equal(1, exam.NumberOfQuestions);
            Assert.Same(questions, exam.Questions);
        }

        [Fact]
        public void ShowExam_PrintsHeaderQuestionsAndFinishedMessage()
        {
            var exam = new PracticalExam(90, 1, SampleQuestions());
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

            Assert.Contains("PRACTICAL EXAM", output);
            Assert.Contains("Pick the odd one", output);
            Assert.Contains("Exam Finished!", output);
            Assert.Contains("Correct Answers:", output);
            Assert.Contains("3:Car", output);
        }

        [Fact]
        public void ExamPolymorphism_ShowExamCallsCorrectOverride()
        {
            // Declared as the abstract base type, but the concrete PracticalExam
            // override must run (tests the abstract Exam.ShowExam contract).
            Exam exam = new PracticalExam(30, 0, Array.Empty<Question>());
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

            Assert.Contains("PRACTICAL EXAM", writer.ToString());
        }
    }
}
