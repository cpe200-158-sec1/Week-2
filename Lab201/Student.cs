using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab201
{
    class Student
    {
        private string _name;
        private string _studentID;
        private int _yearOfBirth;
        private bool _isActive;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public string StudentID
        {
            get
            {
                return _studentID;
            }
            set
            {
                _studentID = value;
            }
        }
        public int YearOfBirth
        {
            get
            {
                return _yearOfBirth;
            }
            set
            {
                if (value < 1950 || value > 2000)
                {
                    Console.WriteLine("{0} error try setting invalid year-of-birth value!", this.StudentID);
                }
                else
                {
                    _yearOfBirth = value;
                }
            }
        }
        public bool isActive
        {
            get
            {
                return _isActive;
            }
            set
            {
                _isActive = value;
            }
        }
        public Student()
        {
            _name = "John Doe";
            _studentID = "Unknown";
            _yearOfBirth = 1995;
            _isActive = false;
        }
        public Student(string Nameinput, string IDinput)
        {
            _name = Nameinput;
            _studentID = IDinput;
            _yearOfBirth = 1995;
            _isActive = true;
        }
        public Student(string Nameinput, string IDinput, int Yearinput)
        {
            _name = Nameinput;
            _studentID = IDinput;
            _yearOfBirth = Yearinput;
            _isActive = true;
        }
        public Student(string Nameinput, string IDinput, int Yearinput, bool isActiveinput)
        {
            _name = Nameinput;
            _studentID = IDinput;
            _yearOfBirth = Yearinput;
            _isActive = isActiveinput;
        }
        public int getAge()
        {
            return (2015 - _yearOfBirth);
        }
        public override string ToString()
        {
            string a;
            if (_isActive)
            {
                a = "is active student";
            }
            else
            {
                a = "is NOT active student";
            }
            return string.Format("[Student: {0} ({1}), age={2}, {3}]", _name, _studentID, getAge(), a);
        }
    }
}
