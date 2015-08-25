using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab201
{
    class Student
    {
        private string _StudentID;
        private int _YearOfBirth;
        private string _Name;
        private bool _isActive;

        public Student()
        {
            _StudentID = "Unknown";
            _Name = "John Doe";
            _YearOfBirth = 1995;
            _isActive = false;
        }
        public Student(string n, string sid)
        {
            _Name = n;
            _StudentID = sid;
            _isActive = true;
            _YearOfBirth = 1995;
        }
        public Student(string n, string sid, int y)
        {
            _YearOfBirth = y;
            _Name = n;
            _StudentID = sid;
            _isActive = true;
        }
        public Student(string n, string sid, int y, bool ac)
        {
            _YearOfBirth = y;
            _Name = n;
            _StudentID = sid;
            _isActive = ac;
        }
        public string StudentID
        {
            get { return _StudentID; }
            set { _StudentID = value; }
        }
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        public bool isActive
        {
            get { return _isActive; }
            set
            {
                if (value)
                    _isActive = true;
                else
                    _isActive = false;
            }
        }
        public int YearOfBirth
        {
            get { return _YearOfBirth; }
            set
            {
                if (value < 1950 || value > 2000)
                {
                    Console.WriteLine("{0}: error try setting invalid year-of-birth value!", StudentID);
                }
                else
                    _YearOfBirth = value;
            }
        }
        public int getAge()
        {
            return 2015 - YearOfBirth;
        }
        public override string ToString()
        {
            string print = "[Student: " + Name + " (" + StudentID + "), age=" + getAge() + ", ";
            if (isActive)
                print += "is active student]";

            else
                print += "is NOT active student]";
            return print;
        }

    }
}
