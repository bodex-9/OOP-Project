namespace Exam0
{
    /// <summary>
    /// Contains the entry point of the application.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">Command-line arguments passed to the application.</param>
        static void Main(string[] args)
        {
            // Create Subject
            Subject subject = new Subject(1, "C# OOP");

            // Answers for MCQ
            Answer a1 = new Answer(1, "C++");
            Answer a2 = new Answer(2, "C#");
            Answer a3 = new Answer(3, "Java");
            Answer a4 = new Answer(4, "Python");

            Answer[] mcqAnswers =
            {
                a1,
                a2,
                a3,
                a4
            };

            // MCQ Question
            MCQQuestion q1 = new MCQQuestion(
                "MCQ",
                "Which language is developed by Microsoft?",
                5,
                mcqAnswers,
                a2
            );

            // Answers for True / False
            Answer trueAnswer = new Answer(1, "True");
            Answer falseAnswer = new Answer(2, "False");

            Answer[] trueFalseAnswers =
            {
                trueAnswer,
                falseAnswer
            };

            // True / False Question
            TrueFalseQuestion q2 = new TrueFalseQuestion(
                "True / False",
                "C# is an object-oriented programming language.",
                5,
                trueFalseAnswers,
                trueAnswer
            );

            // Questions Array
            Question[] questions =
            {
                q1,
                q2
            };

            // Create Final Exam
            FinalExam finalExam = new FinalExam(
                60,
                questions.Length,
                questions
            );

            // Assign exam to subject
            subject.CreateExam(finalExam);

            // Show Subject
            Console.WriteLine(subject);
            Console.WriteLine();

            // Show Exam
            subject.Exam.ShowExam();

            Console.ReadKey();
        }
    }
}
