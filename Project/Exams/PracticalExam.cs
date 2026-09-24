using Exam0;
using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;

namespace Exam0
{
    /// <summary>
    ///  Represents a practical exam.
    /// </summary>
    public class PracticalExam : Exam
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PracticalExam"/> class
        /// </summary>
        /// <param name="time">The duration of the exam in minutes.</param>
        /// <param name="numberofQuestion">The number of questions in the exam.</param>
        /// <param name="questions">The questions included in the exam.</param>
        public PracticalExam(int time, int numberofQuestion, Question[] questions) : base(time, numberofQuestion, questions)
        {

        }
        /// <summary>
        /// Displays the practical exam questions, answers, and correct answers.
        /// </summary>
        public override void ShowExam()
        {
            Console.WriteLine("========== PRACTICAL EXAM ==========");
            Console.WriteLine($"Time: {Time} minutes");
            Console.WriteLine($"Number Of Questions: {NumberOfQuestions}");
            Console.WriteLine();

            for (int i = 0; i < Questions.Length; i++)
            {
                Console.WriteLine($"Question {i + 1}");
                Console.WriteLine(Questions[i]);
                Console.WriteLine("Answers");

                for (int j = 0; j < Questions[i].Answers.Length; j++)
                {
                    Console.WriteLine(Questions[i].Answers[j]);
                }

                Console.WriteLine($"RightAnswers: {Questions[i].RightAnswer}");
                Console.WriteLine("------------------------------");
            }
            Console.WriteLine();
            Console.WriteLine("Exam Finished!");
            Console.WriteLine("Correct Answers:");
            for (int i = 0; i < Questions.Length; i++)
            {
                Console.WriteLine($"{Questions[i]} : {Questions[i].RightAnswer}");
            }
        }
    }
}
