using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab202;

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
            Name = "";
            CourseID = "0000";
            Lecturer = "Staff";
            MaxStudents = 30 ;

        }
        public Course(string n,string CID)
        {
            Name = n;
            CourseID = CID;
            Lecturer = "STAFF";
            MaxStudents = 30;
            
        }
        public Course(string n,string CID,string Lec)
        {
            Name = n;
            CourseID = CID;
            Lecturer = Lec;
            MaxStudents = 30;
        }
        public Course(string n, string CID, string Lec,int MAX)
        {
            Name = n;
            CourseID = CID;
            Lecturer = Lec;
            MaxStudents = MAX;
        }

        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                _Name = value;
            }
        }
        public string CourseID
        {
            get
            {
                return _CourseID;
            }
            set
            {
                int n;
                if (value.Length ==6 && int.TryParse(value,out n))
                {
                    _CourseID = value;
                }
                else
                {
                    Console.WriteLine(_CourseID + ": error try setting invalid CourseID!");
                }
            }
        }
        public string Lecturer
        {
            get
            {
                return _Lecturer;
            }
            set
            {
                _Lecturer = value;
            }
        }
        public int MaxStudents
        {
            get
            {
                return _MaxStudents;
            }
            set
            {
                if(value>0 && value<80 && value >= NumStudents)
                {
                    _MaxStudents = value;
                }
                else
                {
                    Console.WriteLine(_CourseID + ": error try setting invalid Max No. Students!");
                }
            }
        }
        public int NumStudents
        {
            get
            {
                return _NumStudents;
            }
            set
            {
                if(value>0 && value <= MaxStudents)
                {
                    _NumStudents = value;
                }
                else
                {
                    Console.WriteLine(_CourseID+": error try setting invalid No. Students!");
   
                }
            }
        }
        public override string ToString()
        {
            return string.Format("[Course: {0} ({1}), Lecturer= {2}, has Students{3}, Max= {4}]",Name,CourseID,Lecturer,NumStudents,MaxStudents);
        }
    }
}
