using System;

namespace Lab2
{
    public class Course
    {
        private string Name;
        private string CourseID;
        private string Lecturer;
        private int MaxStudents;
        private int NumStudents;

        public string _Name
        {
            get { return Name; }
            set { Name = value; }
        }
        public string _CourseID
        {
            get { return CourseID; }
            set
            {
                bool chck = true;
                foreach (char c in _CourseID)
                {
                    if (!Char.IsDigit(c))
                        chck = false;
                }
                if (value.Length != 6 || chck == true) Console.WriteLine("{0}: error try setting invalid CourseID!", CourseID); else CourseID = value;
            }
        }
        public string _Lecturer
        {
            get { return Lecturer; }
            set { Lecturer = value; }
        }
        public int _MaxStudents
        {
            get { return MaxStudents; }
            set
            {
                if (value < NumStudents ) Console.WriteLine("{0}: error try setting invalid Max No. Students!", CourseID);
                else MaxStudents = value;
            }
        }
        public int _NumStudents
        {
            get { return NumStudents; }
            set { if (value > MaxStudents) Console.WriteLine("{0}: error try setting invalid No. Students!", CourseID); else NumStudents = value; }
        }

        public Course()
        {
            Name = "UNKNOW";
            CourseID = "UNKNOW";
            Lecturer = "staff";
            MaxStudents = 30;
        }
        public Course(string cnm, string cid)
        {
            Name = cnm;
            CourseID = cid;
            Lecturer = "staff";
            MaxStudents = 30;
        }
        public Course(string cnm, string cid, string clec)
        {
            Name = cnm;
            CourseID = cid;
            Lecturer = clec;
            MaxStudents = 30;
        }
        public Course(string cnm, string cid, string clec, int cmax)
        {
            Name = cnm;
            CourseID = cid;
            Lecturer = clec;
            MaxStudents = cmax;
        }

        public override string ToString()
        {
            return string.Format("[Course: {0} ({1}), Lecturer={2}, has {3} students, max={4}", Name, CourseID, Lecturer, NumStudents, MaxStudents);
        }
    }
};