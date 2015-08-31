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
        private string _StudentID;
        private int _YearofBirth;
        private bool _isActive = true;

        public Student()
        {
            _Name = "John Doe";
            _StudentID = "Unknow";
            _YearofBirth = 1995;
            _isActive = false;
        }
        public Student(string name, string stdid)
        {
            _Name = name;
            _StudentID = stdid;
            _YearofBirth = 1995;
            _isActive = true;
        }
        public Student(string name, string stdid, int yob)
        {
            _Name = name;
            _StudentID = stdid;
            _YearofBirth = yob;
            _isActive = true;
        }
        public Student(string name, string stdid, int yob, bool isActive)
        {
            _Name = name;
            _StudentID = stdid;
            _YearofBirth = yob;
            _isActive = isActive;
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
            get { return _YearofBirth; }
            set
            {
                if (value < 1950 || value >2000)
                {
                    Console.WriteLine("{0} error try setting invalid year - of - birth value!", _StudentID);
                }
                else
                {
                    _YearofBirth = value;
                }
            }
        }
        public bool isActive
        {
            get { return _isActive; }
            set { _isActive = value; }
        }
        public int getAge()
        {
            return 2015 - _YearofBirth;
        }
        public override string ToString()
        {
            return string.Format("Student: {0}  ({1}), age = {2}, is {3}", _Name, _StudentID, getAge(), (isActive) ? "active student ]" : "not active student");

        }
    }
}


