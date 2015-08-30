using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab202
{
    class Course
    {
        private string _Name;
        private string _CourseID;
        private string _Lecturer;
        private int _MaxStudents;
        private int _NumStudents;

        public Course()
        {
            _Name = "XXX";
            _CourseID = "000000";
            _Lecturer = "staff";
            _MaxStudents = 30;
            _NumStudents = 0;
        }
        public Course(string n, string c)
        {
            _Name = n;
            _CourseID = c;
            _Lecturer = "staff";
            _MaxStudents = 30;
        }
        public Course(string n, string c, string lec)
        {
            _Name = n;
            _CourseID = c;
            _Lecturer = lec;
            _MaxStudents = 30;
        }
        public Course(string n, string c, string lec, int maxst)
        {
            _Name = n;
            _CourseID = c;
            _Lecturer = lec;
            _MaxStudents = maxst;
        }
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        public string CourseID
        {
            get { return _CourseID; }
            set
            {
                bool check = false;
                char x = ' ';
                char[] array = value.ToCharArray();
                for (int i = 0; i < value.Length; i++)
                {
                    x = array[i];
                    if (char.IsLower(x) || char.IsUpper(x))
                        check = true;

                }
                if (value.Length != 6 || check)
                {
                    Console.WriteLine(_CourseID + ": error try setting invalid CourseID!");
                }
                else
                    _CourseID = value;
            }
        }
        public string Lecturer
        {
            get { return _Lecturer; }
            set { _Lecturer = value; }
        }
        public int MaxStudents
        {
            get { return _MaxStudents; }
            set
            {
                if (value < 0 || value > 80 || value < _NumStudents)
                    Console.WriteLine(_CourseID + ": error try setting invalid Max No. Students!");
                else
                    _MaxStudents = value;
            }
        }
        public int NumStudents
        {
            get { return _NumStudents; }
            set
            {
                if (value < 0 || value > _MaxStudents)
                    Console.WriteLine(_CourseID + ": error try setting invalid No.Students!");
                else
                    _NumStudents = value;
            }
        }
        public override string ToString()
        {
            string x = "[Course: " + Name + "(" + CourseID + "), Lecturer =" + Lecturer + ", has " + NumStudents + " students, max=" + MaxStudents + "]";
            return x;
        }

    }
}