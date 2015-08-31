using System;
using Lab201;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab201
{
    class Student
    {

        private string _Name;
        private string  _StudentID;
        private int _YearOfBirth;
        private bool _isActive;

        public Student()
        {
            _Name = "John Doe";
            _StudentID = "Unknown";
            _YearOfBirth = 1995;
            _isActive = false;
        }

        public Student(string name, string StuID)
        {
            _Name = name;
            _StudentID = StuID;
            _YearOfBirth = 1995;
            _isActive = true;
        }


        public Student(string name, string StuID, int year)
        {
            _Name = name;
            _StudentID = StuID;
            _YearOfBirth = year;
            _isActive = true;
        }

        public Student(string name, string StuID, int year, bool status)
        {
            _Name = name;
            _StudentID = StuID;
            _YearOfBirth = year;
            _isActive = status;
        }

        public string Name
        { get
                { return _Name; }
          set
                { _Name = value; }
        }

        public string StudentID
        {
            get
                { return _StudentID; }
            set
                { _StudentID = value; }
        }

        public int YearOfBirth
        {
            get
                { return _YearOfBirth; }
            set
                {
                if (value >= 1950 && value <= 2000)
                {
                    _YearOfBirth = value;
                }
                else
                {
                    Console.WriteLine(_StudentID + ": error try setting invalid year-of-birth value!");
                }
            }
        }

        public bool isActive
        {
            get 
                { return _isActive; }
            set
                { _isActive = value; }
        }

        public int getAge()
        {
            int age = 0;
            age = 2015 - _YearOfBirth;
            return age;
        }

        public override string ToString()
        {
            return string.Format("[Student: {0} ({1}), age={2}, is {3}", _Name, _StudentID, getAge(), (isActive) ?
                                 " active student]" : " NOT active student]");
        }
    }
}
