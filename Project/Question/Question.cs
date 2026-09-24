using System;
using System.Collections.Generic;
using System.Text;

namespace Exam0
{
    /// <summary>
    /// Represent a General Exam Question
    /// </summary>
    public class Question : ICloneable, IComparable
    {
        /// <summary>
        /// Gets or Sets the header of the question
        /// </summary>
        public string Header { get; set; }
        /// <summary>
        /// Gets or Sets the body of the question
        /// </summary>
        public string Body { get; set; }
        /// <summary>
        /// Gets or Sets the mark  assigned to the question
        /// </summary>
        public int Mark { get; set; }
        /// <summary>
        /// Gets or Sets the answers available for the question
        /// </summary>
        public Answer[] Answers { get; set; }
        /// <summary>
        /// Gets or Sets the right answer of the question
        /// </summary>
        public Answer RightAnswer { get; set; }
        /// <summary>
        ///  Initializes a new instance of the <see cref="Question"/> class.
        /// </summary>
        /// <param name="header">The header of the question</param>
        /// <param name="body">The body of the question</param>
        /// <param name="mark">The mark  assigned to the question</param>
        /// <param name="answers">The answers available for the question</param>
        /// <param name="rightAnswer">The right answer of the question</param>
        public Question(string header, string body, int mark, Answer[] answers, Answer rightAnswer)
        {
            Header = header;
            Body = body;
            Mark = mark;
            Answers = answers;
            RightAnswer = rightAnswer;

        }
        /// <summary>
        /// Returns a string representation of the question.
        /// </summary>
        /// <returns>A string containing the question header, body, and mark.</returns>
        public override string ToString() => $"{Header}\n{Body}\n({Mark} Marks)";
        /// <summary>
        /// Creates a shallow copy of the current question.
        /// </summary>
        /// <returns>A shallow copy of the current <see cref="Question"/> object.</returns>
        public object Clone() => MemberwiseClone();
        /// <summary>
        /// Compares the current question with another object using the question mark.
        /// </summary>
        /// <param name="obj">The object to compare with the current question.</param>
        /// <returns>
        /// A value less than zero if this question is smaller,
        /// zero if both marks are equal,
        /// or a value greater than zero if this question is larger.
        /// </returns>
        /// <exception cref="ArgumentException">
        /// Thrown when the specified object is not a <see cref="Question"/>.
        /// </exception>
        public int CompareTo(object obj)
        {
            if (obj == null)
                return 1;


            Question other = obj as Question;

            if(other == null)
            {
                throw new ArgumentException("object is not a Question");
            }

            return Mark.CompareTo(other.Mark);
        }


    }
}
