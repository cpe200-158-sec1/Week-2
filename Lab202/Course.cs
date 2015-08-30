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
            _Name = "xxxxx" ;
            _CourseID = "xxxxxx" ;
            _Lecturer = "staff" ;
            _MaxStudents = 30 ;
            _NumStudents = 0;
        }

        public Course(string namec, string idc)
        {
            _Name = namec;
            _CourseID = idc;
            _Lecturer = "staff";
            _MaxStudents = 30;
            _NumStudents = 0;
        }

        public Course(string namec, string idc , string lecturec)
        {
            _Name = namec;
            _CourseID = idc;
            _Lecturer = lecturec;
            _MaxStudents = 30;
            _NumStudents = 0;
        }

        public Course(string namec, string idc, string lecturec, int max)
        {
            _Name = namec;
            _CourseID = idc;
            _Lecturer = lecturec;
            _MaxStudents = max;
            _NumStudents = 0;
        }

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
       
        public string CourseID
        {
            get { return _CourseID; }
            set { int n;
                if (value.Length == 6 && int.TryParse(value, out n) )
                     _CourseID = value;
                else
                {
                    Console.WriteLine(CourseID + ": error try setting invalid CourseID!");
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
            set {
                if (value < 0 || value > 80 || value < _NumStudents)
                    Console.WriteLine(_CourseID + ": error try setting invalid Max No. Students!");
                else
                    _MaxStudents = value; }
        }

        public int NumStudents
        {
            get { return _NumStudents; }
            set {
                if (value < 0 || value > _MaxStudents)
                    Console.WriteLine(_CourseID + ": error try setting invalid No.Students!");
                else
                    _NumStudents = value; }
        }

        public override string ToString()
        {
            return string.Format("[Course: {0} ({1}), Lecturer={2}, has {3} students, max={4}]", _Name, _CourseID, _Lecturer, _NumStudents, _MaxStudents);
        }
       
    
    }
}
