using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab201
{
    class Student
    {
        private string _Name;
        private string _StudentId;
        private int _YearofBirth;
        private bool _IsActive;

        public Student()
        {
            Name = "John Doe";
            StudentID = "unknow";
            YearOfBirth = 1995;
            isActive = false;
        }
        public Student(string Tname, string TStudentID)
        {
            Name = Tname;
            StudentID = TStudentID;
            YearOfBirth = 1995;
            isActive = true;
        }
        public Student(string Tname, string TstudentID, int Tyearofbrith)
        {
            Name = Tname;
            StudentID = TstudentID;
            YearOfBirth = Tyearofbrith;
            isActive = true;
        }
        public Student(string Tname, string TstudentID, int Tyearofbrith, bool Tisactive)
        {
            Name = Tname;
            StudentID = TstudentID;
            YearOfBirth = Tyearofbrith;
            isActive = Tisactive;
        }
        public override string ToString()
        {
            return string.Format("[Student: {0} ({1}), age={2}, is {3}", _Name, _StudentId, getAge(), (isActive) ? " active student]" : " NOT active student]");
        }

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        public string StudentID
        {
            get { return  _StudentId; }
            set {
                if (value.Length != 5 && value != "Unknown")
                    {
                    _StudentId = value;
                }
                  else
                    {
                    _StudentId = value;
                    }
                 }

        }
        public int YearOfBirth
        {
            get
            {
                return _YearofBirth;
            }
            set
            {
                if ( value <1950 || value > 2000)
                {
                    Console.WriteLine(StudentID + ": error try setting invalid year-of-birth value!");
                }
                else
                {
                    _YearofBirth = value;
                }
            }
        }
        public bool isActive
        {
            get
            {
                return _IsActive;
            }
            set
            {
                _IsActive = value;
            }
        }
        public int getAge()
        {
                return 2015 - YearOfBirth; 
        }


    }
}
