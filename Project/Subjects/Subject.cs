using System;
using System.Collections.Generic;
using System.Text;

namespace Exam0
{
    /// <summary>
    /// Represent a Subject that can contain an exam
    /// </summary>
    public class Subject
    {
        /// <summary>
        /// Gets or sets the unique identifier of the subject.
        /// </summary>
        public int SubjectId { get; set; }
        /// <summary>
        /// Gets or sets the name of the subject
        /// </summary>
        public string SubjectName { get; set; }
        /// <summary>
        /// Gets the exam associated with the subject.
        /// </summary>
        public Exam Exam { get; private set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Subject"/> class.
        /// </summary>
        /// <param name="subjectId">The unique identifier of the subject.</param>
        /// <param name="subjectName"> The name of the subject</param>
        public Subject(int subjectId, string subjectName)
        {
            SubjectId = subjectId;
            SubjectName = subjectName;
        }
        /// <summary>
        /// Associates an exam with the subject.
        /// </summary>
        /// <param name="exam">The exam associated with the subject.</param>

        public void CreateExam(Exam exam)
        {
            Exam = exam;
        }
        /// <summary>
        /// Returns a string representation of the subject.
        /// </summary>
        /// <returns>
        /// A string containing the subject identifier and name.
        /// </returns>
        public override string ToString() => $"Subject Id: {SubjectId}\nSubject Name: {SubjectName}";

    }
}
