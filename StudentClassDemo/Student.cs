using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentClassDemo
{
    class Student
    {
        //-------------------------------------
        //Private Fields
        //-------------------------------------

        private string major;        
        private double average;
        private string studentFirstName;
        private string studentLastName;
        private string studentNumber;

        //-------------------------------------
        //Properties
        //-------------------------------------

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StudentNumber { get; set; }
        public string Major { get; set; }
        public double Average { get; private set; }

        private int score1;
        public int Score1
        {
            get { return score1; }
            set { score1 = value; CalcAverage(); }
        }
        private int score2;
        public int Score2
        {
            get { return score2; }
            set { score2 = value; CalcAverage(); }
        }
        private int score3;
        public int Score3
        {
            get { return score3; }
            set { score3 = value; CalcAverage(); }
        }

        //-------------------------------------
        //Constructors
        //-------------------------------------

        //default constructor
        public Student()
            : this("Number Pending", "TBD", "TBD", "Undeclared")
        {
        }

        //single parameter constructor
        public Student(string sID)
            : this(sID, "TBD", "TBD", "Undeclared")
        {
        }

        //constructor when we have student ID information and major
        public Student(string sID, string firstName, string lastName, string maj)
        {
            studentNumber = sID;
            studentFirstName = firstName;
            studentLastName = lastName;
            major = maj;
        }

        //constructor when we have student information and score information
        public Student(string sID, string firstName, string lastName,
            int s1, int s2, int s3, string maj)
            : this(sID, firstName, lastName, maj)
        {
            score1 = s1;
            score2 = s2;
            score3 = s3;
            CalcAverage();
        }

        //-------------------------------------
        //Instance Methods
        //------------------------------------
        public void CalcAverage()
        {
            average = score1 + score2 + score3 / 3.0;
        }
        public override string ToString()
        {
            return
                FirstName + " " + LastName
                + " Major: " + Major
                + " Average: " + Average;
        }

    }
}
