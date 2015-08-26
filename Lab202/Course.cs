using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab202
{
    class Course
    {
        //Properties: Name, CourseID, Lecturer, MaxStudents, NumStudents
        private string _name;
        private string _id;
        private string _lec;
        private int _max;
        private int _nstd;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string CourseID
        {
            get { return _id; }
            set
            {
                //CourseID(6-digit number only),
                if(IsDigitsOnly(value)!=false)
                {
                    if (value.Length < 7 && _id != value)
                        _id = value;
                    else
                        Console.WriteLine("" + CourseID + ": error try setting invalid CourseID!");
                }
                else
                    Console.WriteLine("" + CourseID + ": error try setting invalid CourseID!");
            }

        }
        public string Lecturer
        {
            get { return _lec; }
            set { _lec = value; }
        }
        public int MaxStudents
        {
            //MaxStudents(0-80, and >= NumStudents)
            get { return _max; }
            set
            {
                if (value > 0 && value <= 80 && value >= _nstd)
                    _max = value;
                else
                    Console.WriteLine("" + CourseID + ": error try setting invalid Max No. Students!");
            }
        }
        public int NumStudents
        {
            //NumStudents(0-MaxStudents)
            get { return _nstd; }
            set
            {
                if (value >= 0 && value < MaxStudents)
                    _nstd = value;
                else
                    Console.WriteLine("" + CourseID + ": error try setting invalid No. Students!");
            }
        }

        //Constructors
        public Course(string n,string id)
        {
            Name = n;
            CourseID = id;
            Lecturer = "staff";
            MaxStudents = 30;
            NumStudents = 0;
        }
        public Course(string n, string id,string lec)
        {
            Name = n;
            CourseID = id;
            Lecturer = lec;
            MaxStudents = 30;
            NumStudents = 0;
        }
        public Course(string n, string id,string lec,int max)
        {
            Name = n;
            CourseID = id;
            Lecturer = lec;
            MaxStudents = max;
            NumStudents = 0;
        }

        //Methods
        public override string ToString()
        {
            //[Course: Object-Oriented Programming (261200), Lecturer=staff, has 0 students, max=30]
            string s = "[Course: " + Name + " (" + CourseID + "), Lecturer=" + Lecturer + ", has " + NumStudents + " students, max= " + MaxStudents + "]"; 
            return s;
        }
        bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }
    }
}
