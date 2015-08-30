using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Student
    {
        private string _Name;
        private string _StudentID;
        private int _YearOfBirth;
        bool _isActive = true;

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
                if (value < 1950 || value > 2000)
                {
                    Console.WriteLine("{0}: error try setting invalid year-of-birth value!", _StudentID);
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
            _Name = "John Doe";
            _StudentID = "Unknow";
            _YearOfBirth = 1995;
            _isActive = false;
        }
        public Student(string name, string studentid)
        {
            _Name = name;
            _StudentID = studentid;
            _YearOfBirth = 1995;
            _isActive = true;
        }
        public Student(string name, string studentid, int YearOfBirth)
        {
            _Name = name;
            _StudentID = studentid;
            _YearOfBirth = YearOfBirth;
            _isActive = true;
        }
        public Student(string name, string studentid, int YearOfBirth, bool isactive)
        {
            _Name = name;
            _StudentID = studentid;
            _YearOfBirth = YearOfBirth;
            _isActive = isactive;
        }
        public int getAge()
        {
            return 2015 - _YearOfBirth;
        }
        public override string ToString()
        {
            return string.Format("[Student: {0} ({1}), age={2}, {3}", _Name, _StudentID, getAge(), (_isActive) ? " is active student]" : " is NOT active student]");
        }

    }
}




