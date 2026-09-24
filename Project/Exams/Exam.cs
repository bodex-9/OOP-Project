using System;
using System.Collections.Generic;
using System.Text;

namespace Exam0
{
    /// <summary>
    /// Represent the base class for different types of exams
    /// </summary>
    public abstract class Exam:IComparable,ICloneable
    {
        /// <summary>
        /// Gets or Sets the duration of the exam in minutes.
        /// </summary>
        public int Time {  get; set; }
        /// <summary>
        /// Gets or Sets the number of question in the exam
        /// </summary>
        public int NumberOfQuestions { get; set; }
        /// <summary>
        /// Gets or Sets the questions icluded in the exam
        /// </summary>
        public Question[] Questions { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Exam"/> class.
        /// </summary>
        /// <param name="time">The duration of the exam in minutes.</param>
        /// <param name="numberofQuestion">The number of questions in the exam.</param>
        /// <param name="questions">The questions included in the exam.</param>
        protected Exam(int time,int numberofQuestion, Question[] questions)
        {
            Time = time;
            NumberOfQuestions = numberofQuestion;
            Questions = questions;
        }

        /// <summary>
        /// Display the Exam to the user
        /// </summary>
        public abstract void ShowExam();
        /// <summary>
        /// Returns a string representation of the exam.
        /// </summary>
        /// <returns>
        /// A string containing the exam duration and number of questions.
        /// </returns>
        public override string ToString() => $"Time : {Time}\nNumberOfQuestions : {NumberOfQuestions}\n ";
        /// <summary>
        /// Creates a shallow copy of the current exam.
        /// </summary>
        /// <returns>
        /// A shallow copy of the current <see cref="Exam"/> object.
        /// </returns>
        public object Clone() => MemberwiseClone();
        /// <summary>
        /// Compares the current exam with another object using the exam duration.
        /// </summary>
        /// <param name="obj">The object to compare with the current exam.</param>
        /// <returns>
        /// A value less than zero if this exam is shorter,
        /// zero if both exams have the same duration,
        /// or a value greater than zero if this exam is longer.
        /// </returns>
        /// <exception cref="ArgumentException">
        /// Thrown when the specified object is not an <see cref="Exam"/>.
        /// </exception>
        public int CompareTo(object obj)
        {
            if (obj == null)
                return 1;


            Exam other = obj as Exam;

            if (other == null)
            {
                throw new ArgumentException("object is not a Exam");
            }

            return Time.CompareTo(other.Time);
        }
    }
}
