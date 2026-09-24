using System;
using System.Collections.Generic;
using System.Text;

namespace Exam0
{
    /// <summary>
    /// Represent an answer for an exam question
    /// </summary>
    public class Answer:ICloneable,IComparable
    {
        /// <summary>
        /// Get or Set the unique identifier of the answer.
        /// </summary>
        public int AnswerId { get; set; }
        /// <summary>
        /// Get or Set the text of answer.
        /// </summary>
        public string AnswerText { get; set; }
        /// <summary>
        /// Initilizes a new instance of the <see cref="Answer"/> class
        /// </summary>
        /// <param name="answerId">The unique identifier of the answer</param>
        /// <param name="answerText">The text of the answer.</param>
        public Answer(int answerId, string answerText)
        {
            AnswerId = answerId;
            AnswerText = answerText;
        }
        /// <summary>
        /// Return a string Representaion of the Answer
        /// </summary>
        /// <returns>A string contain the Answer identifier and the Answer text </returns>
        public override string ToString() => $"{AnswerId}:{AnswerText}";
         /// <summary>
         /// Create a shallow copy of the current answer
         /// </summary>
         /// <returns>Returns a shallow copy of the Current <see cref="Answer"/> object</returns>
        public object Clone() => MemberwiseClone();
        /// <summary>
        /// Compare the current answer with another object using answer identifier
        /// </summary>
        /// <param name="obj">the object compare with the current answer</param>
        /// <returns>
        /// A value less than zero if this answer is smaller,
        /// zero if both identifiers are equal,
        /// or a value greater than zero if this answer is larger.
        /// </returns>
        /// <exception cref="ArgumentException">
        /// Thrown when a spacified object is not a <see cref="Answer"/>
        /// </exception>
        public int CompareTo(object obj)
        {
            if (obj == null)
            {
                return 1 ;
            }

            Answer other = obj as Answer;

            if(other == null)
            {
                throw new ArgumentException("object is not answer");
            }

            return AnswerId.CompareTo(other.AnswerId);
        }

    }
}
