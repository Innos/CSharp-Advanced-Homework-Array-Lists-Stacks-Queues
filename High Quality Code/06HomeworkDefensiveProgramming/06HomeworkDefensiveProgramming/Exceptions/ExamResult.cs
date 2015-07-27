namespace Exams
{
    using System;

    public class ExamResult
    {
        private int grade;

        private int minGrade;

        private int maxGrade;

        private string comments;

        public ExamResult(int grade, int minGrade, int maxGrade, string comments)
        {
            this.Grade = grade;
            this.MinGrade = minGrade;
            this.MaxGrade = maxGrade;
            this.Comments = comments;
        }

        public int Grade
        {
            get
            {
                return this.grade;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("value", "Grade cannot be negative.");
                }

                this.grade = value;
            }
        }

        public int MinGrade 
        {
            get
            {
                return this.minGrade;
            }

            private set
            {
                if (value < 0)
                {     
                        throw new ArgumentOutOfRangeException("value", "Minimum grade cannot be negative.");
                }

                this.minGrade = value;
            }
        }

        public int MaxGrade
        {
            get
            {
                return this.maxGrade;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("value", "Maximum grade cannot be negative.");
                }

                this.maxGrade = value;
            }
        }

        public string Comments
        {
            get
            {
                return this.comments;
            }

            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("value", "Comments cannot be empty!");
                }

                this.comments = value;
            }
        }
    }
}
