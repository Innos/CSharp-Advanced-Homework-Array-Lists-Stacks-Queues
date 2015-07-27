namespace Exams
{
    using System;
    using System.CodeDom;
    using System.Collections.Generic;
    using System.Linq;

    public class Student
    {
        private string firstName;

        private string lastName;

        private IList<Exam> exams;

        public Student(string firstName, string lastName, IList<Exam> exams)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Exams = exams;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("value", "First name cannot be emtpy.");
                }

                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("value", "Last name cannot be emtpy.");
                }

                this.lastName = value;
            }
        }

        public IList<Exam> Exams
        {
            get
            {
                return this.exams;
            }

            set
            {
                if (value == null || value.Count == 0)
                {
                    throw new ArgumentNullException("value", "Exams cannot be null or empty.");
                }

                this.exams = value;
            }
        }

        public IList<ExamResult> CheckExams()
        {
            return this.Exams.Select(t => t.Check()).ToList();
        }

        public double CalcAverageExamResultInPercents()
        {
            double[] examScore = new double[this.Exams.Count];
            IList<ExamResult> examResults = this.CheckExams();
            for (int i = 0; i < examResults.Count; i++)
            {
                examScore[i] =
                    ((double)examResults[i].Grade - examResults[i].MinGrade) /
                    (examResults[i].MaxGrade - examResults[i].MinGrade);
            }

            return examScore.Average();
        }
    }


}