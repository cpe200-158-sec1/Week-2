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
        private int _yearofbirth;
        private bool _isActive;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string StudentID
        {
            get { return _studentID; }
            set { _studentID = value; }
        }
        public int YearOfBirth
        {
            get { return _yearofbirth; }
            set
            {
                if (value < 1950 || value > 2000)
                {
                    Console.WriteLine("{0} : error try setting invalid year-of-birth value!", _studentID);
                }
            }
        }
        public bool isActive
        {
            get { return _isActive; }
            set { _isActive = value; }
        }

        public Student()
        {
            _name = "John Doe";
            _studentID = "UNKNOW";
            _yearofbirth = 1995;
            _isActive = false;
        }
        public Student(string stdName, string stdID)
        {
            _name = stdName;
            _studentID = stdID;
            _yearofbirth = 1995;
            _isActive = true;
        }
        public Student(string stdName, string stdID, int stdyearOfbirth)
        {
            _name = stdName;
            _studentID = stdID;
            _yearofbirth = stdyearOfbirth;
            _isActive = true;
        }
        public Student(string stdName, string stdID, int stdyearOfbirth, bool stdActive)
        {
            _name = stdName;
            _studentID = stdID;
            _yearofbirth = stdyearOfbirth;
            _isActive = stdActive;
        }

        public int getAge()
        {
            return 2015 - _yearofbirth;
        }
        public override string ToString()
        {
            return string.Format("[Student: {0} ({1}), age={2}, is {3}", _name, _studentID, getAge(), (isActive) ? " is active student]" : " is NOT active student]");
        }
    }
}
