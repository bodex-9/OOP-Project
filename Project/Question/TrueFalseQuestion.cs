using System;
using System.Collections.Generic;
using System.Text;

namespace Exam0
{
    /// <summary>
    /// Represent a True or False Questions
    /// </summary>
   public class TrueFalseQuestion:Question
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TrueFalseQuestion"/> class.
        /// </summary>
        /// <param name="header">The header of the question.</param>
        /// <param name="body">The body of the question.</param>
        /// <param name="mark">The mark assigned to the question.</param>
        /// <param name="answers">The available answers for the question.</param>
        /// <param name="rightAnswer">The correct answer for the question.</param>
        public TrueFalseQuestion(string header, string body, int mark, Answer[] answers, Answer rightAnswer):base(header,body,mark,answers,rightAnswer)
        {
            
        }
    }
}
