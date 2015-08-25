using System;
using Lab2;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab201
{
    class Student
    {
        private string _Name;
        private string _StudentID;
        private int _YearOfBirth;
        private bool _isActive;

        public Student()
        {
            _Name = "John Doe";
            _StudentID = "Unknown";
            _YearOfBirth = 1995;
            _isActive = false;

        }

        public Student(string name, string stdid)
        {
            _Name = name;
            _StudentID = stdid;
            _YearOfBirth = 1995;
            _isActive = true;
        }

        public Student(string name, string stdid, int yob)
        {
            _Name = name;
            _StudentID = stdid;
            _YearOfBirth = yob;
            _isActive = true;
        }

        public Student(string name, string stdid, int yob, bool active)
        {
            _Name = name;
            _StudentID = stdid;
            _YearOfBirth = yob;
            _isActive = active;
        }

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        public string StudentID
        {
            get { return _StudentID; }
            set { _StudentID = value; }
        }

        public int YearOfBirth
        {
            get { return _YearOfBirth; }
            set
            {
                if (value < 1995 || value > 2000)
                { Console.WriteLine(_StudentID+": error try setting invalid year-of-birth value!"); }
                else
                    _YearOfBirth = value;
            }
        }


        public bool isActive
        {
            get { return _isActive; }
            set { _isActive = value; }
        }

        public int getAge()
        {
            int age;
            age = 2015 - _YearOfBirth;
            return age;
        }

        public override string ToString()
        {
            return string.Format("[Student: {0} ({1}), age={2}, is {3}", _Name, _StudentID, getAge(), (isActive) ? " active student]" : " NOT active student]");
        }


    }

}
