using System;

namespace StudentDatabaseApp
{
    public class Student
    {
        private int id;
        private string firstName;
        private string lastName;
        private string email;
        private Gender gender;
        private StudentType studentType;
        private int examResult;
        private double hwSent;
        private double hwEvaluated;
        private double teamScore;
        private double attendancies;
        private double bonus;
        private double result;

        public Student(int id,
            string firstName,
            string lastName,
            string email,
            Gender gender,
            StudentType studentType,
            int examResult,
            double hwSent,
            double hwEvaluated,
            double teamScore,
            double attendancies,
            double bonus)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
            this.gender = gender;
            this.studentType = studentType;
            this.ExamResult = examResult;
            this.HwSent = hwSent;
            this.HwEvaluated = hwEvaluated;
            this.TeamScore = teamScore;
            this.Attendancies = attendancies;
            this.Bonus = bonus;
            this.Result = CalculateResult();
        }

        public int Id
        {
            get { return this.id; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Please select positive value for ID", "Id");
                }

                this.id = value;
            }
        }

        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("First name cannot be empty string", "firstName");
                }

                this.firstName = value;
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Last name cannot be empty string", "lastName");
                }

                this.lastName = value;
            }
        }

        public Gender Gender
        {
            get { return this.gender; }
            private set { this.gender = value; }
        }

        public StudentType StudentType
        {
            get { return this.studentType; }
            private set { this.studentType = value; }
        }

        public string Email
        {
            get { return this.email; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Email cannot be empty string", "email");
                }

                this.email = value;
            }
        }

        public int ExamResult
        {
            get { return this.examResult; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Exam result cannot be a negative value", "examResult");
                }

                this.examResult = value;
            }
        }

        public double HwSent
        {
            get { return this.hwSent; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Homework sent cannot be a negative value", "hwSent");
                }

                this.hwSent = value;
            }
        }

        public double HwEvaluated
        {
            get { return this.hwEvaluated; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Homework evaluated cannot be a negative value", "hwEvaluated");
                }

                this.hwEvaluated = value;
            }
        }

        public double TeamScore
        {
            get { return this.teamScore; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Teamwork score cannot be a negative value", "teamScore");   
                }

                this.teamScore = value;
            }
        }

        public double Attendancies
        {
            get { return this.attendancies; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Attendancies cannot be a negative value", "attendancies");
                }

                this.attendancies = value;
            }
        }

        public double Bonus
        {
            get { return this.bonus; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Bonus cannot be a negative value", "bonus");
                }

                this.bonus = value;
            }
        }

        public double Result
        {
            get { return this.result; }
            private set { this.result = value; }
        }

        private double CalculateResult()
        {
            return (this.examResult + this.hwSent + this.hwEvaluated + this.teamScore +
                    this.attendancies + this.bonus) / 5;
        }
    }
}
