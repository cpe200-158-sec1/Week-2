using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Course
    {
        private string _Name;
        private string _Courseid;
        private string _Lecturer;
        private int _MaxStudent;
        private int _NumStudent;

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        public string CourseID
        {
            get { return _Courseid; }
            set
            {
                bool check = true;
                foreach (char cid in value)
                {
                    if (!char.IsDigit(cid))
                        check = false;
                }
                if (value.Length == 6 && check == true) _Courseid = value;
                    else Console.WriteLine("{0}: error try setting invalid CourseID!", _Courseid);
            }
        }
        public string Lecturer
        {
            get { return _Lecturer; }
            set { _Lecturer = value; }
        }
        public int MaxStudents
        {
            get { return _MaxStudent; }
            set { if (value > 0 && value < 81 && value >= _NumStudent) _MaxStudent = value; else Console.WriteLine("{0}: error try setting invalid Max No. Students!", _Courseid); }
        }
        public int NumStudents
        {
            get { return _NumStudent; }
            set { if (value > 0 && value < _MaxStudent) _NumStudent = value; else Console.WriteLine("{0}: error try setting invalid No. Students!", _Courseid); }
        }
        public Course()
        {
            _Name = "Unknown";
            _Courseid = "Unknown";
            _Lecturer = "Staff";
            _MaxStudent = 30;
        }
        public Course(string Cname,string Cid)
        {
            _Name = Cname;
            _Courseid = Cid;
            _Lecturer = "Staff";
            _MaxStudent = 30;
        }
        public Course(string Cname,string Cid,string Clec)
        {
            _Name = Cname;
            _Courseid = Cid;
            _Lecturer = Clec;
            _MaxStudent = 30;
        }
        public Course(string Cname,string Cid,string Clec,int MSt)
        {
            _Name = Cname;
            _Courseid = Cid;
            _Lecturer = Clec;
            _MaxStudent = MSt;
        }
        public override string ToString()
        {
            return string.Format("Course: {0} ({1}), Lecturer={2}, has {3} students, max={4}", _Name, _Courseid, _Lecturer, _NumStudent, _MaxStudent); 
        }
    }
}
