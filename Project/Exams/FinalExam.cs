using System;
using System.Collections.Generic;
using System.Text;

namespace Exam0
{
    /// <summary>
    /// Represent a final exam
    /// </summary>
     public class FinalExam:Exam
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FinalExam"/> class
        /// </summary>
        /// <param name="time">The duration of the exam in minutes.</param>
        /// <param name="numberofQuestion">The number of questions in the exam.</param>
        /// <param name="questions">The questions included in the exam.</param>
        public FinalExam(int time, int numberofQuestion, Question[] questions):base(time,numberofQuestion,questions)
        {
            
        }
        /// <summary>
        /// Displays the final exam questions, answers, correct answers, and total grade.
        /// </summary>
        public override void ShowExam()
        {
            Console.WriteLine("========== FINAL EXAM ==========");
            Console.WriteLine($"Time: {Time} minutes");
            Console.WriteLine($"Number Of Questions: {NumberOfQuestions}");
            Console.WriteLine();

            int TotalGrades = 0;

            for(int i=0;i<Questions.Length;i++)
            {
                Console.WriteLine($"Question {i + 1}");
                Console.WriteLine(Questions[i]);
                Console.WriteLine("Answers");

                for(int j=0; j < Questions[i].Answers.Length;j++)
                {
                    Console.WriteLine($"{Questions[i].Answers[j]}");
                }

                Console.WriteLine($"RightAnswers: {Questions[i].RightAnswer}");
                Console.WriteLine("------------------------------");

                TotalGrades += Questions[i].Mark;
            }

            Console.WriteLine($"Grade: {TotalGrades}");
        }
    }
}
