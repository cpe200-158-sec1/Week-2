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
        private string _name;
        private string _studentID;
        private int _yob;
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
                return _yob;
            }
            set
            {
                if (_yob >= 1995 && _yob <= 200)
                {
                    _yob = value;
                }
                else
                { Console.WriteLine(_studentID + ": error try setting invalid year-of-birth value!"); }
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


            public int Age()
        {
            int age;
            age = 2015 - _yob;
            return age;
        }

    public Student() {
                _name = "John Doe";
                _studentID = "Unknown";
                _yob = 1995;
                _isActive = false;
            }

       public Student(string n1,string s1) {
                _name = n1;
                _studentID = s1;
                _yob = 1995;
                _isActive = true;    
            }

        public Student(string n2,string s2,int y1) {
                _name = n2;
                _studentID = s2;
                _yob = y1;
                _isActive = true;
            }

        public Student(string n3,string s3,int y2,bool a) {
                _name = n3;
                _studentID = s3;
                _yob = y2;
                _isActive = a;
            }

        public override string ToString()
        {
            return string.Format("[Student: {0} ({1}), age={2}, is {3}", _name, _studentID, Age(), (_isActive) ? " active student]" : " NOT active student]");
        }

    }

}
