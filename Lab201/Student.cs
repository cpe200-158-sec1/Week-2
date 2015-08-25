using System;

namespace Lab2
{
    class Student
    {

        private string _Name;
        private int _YearOfBirth;
        private string _Studentid;
        private bool _isActive;

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        public int YearOfBirth
        {
            get { return _YearOfBirth; }
            set { if (value < 1950 || value > 2000) Console.WriteLine("{0}: error try setting invalid year-of-birth value!",_Studentid); else _YearOfBirth = value; }
        }

        public string Studentid
        {
            get { return _Studentid; }
            set { _Studentid = value; }
        }

        public bool isActive
        {
            get { return _isActive; }
            set { _isActive = value; }
        }

        public Student()
        {
            _Name = "John Doe";
            _Studentid = "Unknown";
            _YearOfBirth = 1995;
            _isActive = false;
        }

        public Student(string stname ,string stid)
        {
            _Name = stname;
            _Studentid = stid;
            _YearOfBirth = 1995;
            _isActive = true;
        }

        public Student(string stname ,string stid ,int yob)
        {
            _Name = stname;
            _Studentid = stid;
            _YearOfBirth = yob;
            _isActive = true;
        }

        public Student(string stname ,string stid ,int yob ,bool active)
        {
            _Name = stname;
            _Studentid = stid;
            _YearOfBirth = yob;
            _isActive = active;
        }

        public int getAge()
        {
            return 2015 - _YearOfBirth;
        }

        public override string ToString()
        {
            return string.Format("[Student: {0} ({1}), {2}, {3}", _Name, _Studentid, _YearOfBirth, (_isActive) ? "is active student" : "is NOT active student");
        }

    }
}
