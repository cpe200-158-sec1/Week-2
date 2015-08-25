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
                bool isNum;
                int Num;
                isNum = int.TryParse(value, out Num);
                if (value.Length > 6 || isNum == false)
                {
                    Console.WriteLine(_CourseID + ": error try setting invalid CourseID!");
                }
                else
                {
                    _CourseID = value;
                }
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
                if ((value >= 0 && value <= 80) && (value >= _NumStudents))
                {
                    _MaxStudents = value;
                }
                else { Console.WriteLine(CourseID + ": error try setting invalid Max No. Students!"); }
            }
        }
        public int NumStudents
        {
            get { return _NumStudents; }
            set
            {
                if (value >= 0 && value <= _MaxStudents) { _NumStudents = value; }
                else { Console.WriteLine(CourseID + ": error try setting invalid No. Students!"); }
            }
        }
        //Constructor
        public Course()
        {
            _MaxStudents = 30;
            _Lecturer = "staff";
            _NumStudents = 0;
            _CourseID = "000000";
            _Name = " ";
        }
        public Course(string name, string courseid)
        {
            _Name = name;
            _Lecturer = "staff";
            _CourseID = courseid;
            _MaxStudents = 30;
        }
        public Course(string name, string courseid, string lecturer)
        {
            _Name = name;
            _CourseID = courseid;
            _Lecturer = lecturer;
            _MaxStudents = 30;
        }
        public Course(string name, string courseid, string lecturer, int maxstudents)
        {
            _Name = name;
            _CourseID = courseid;
            _Lecturer = lecturer;
            _MaxStudents = maxstudents;
        }
        //output 
        public override string ToString()
        {
            string output = ("[Course: " + Name + "(" + Convert.ToInt32(CourseID) + "), Lecturer = " + Lecturer + ", has " + Convert.ToInt32(NumStudents) + " students, max = " + Convert.ToInt32(MaxStudents) + "]");
            return output;
        }
    }
}
