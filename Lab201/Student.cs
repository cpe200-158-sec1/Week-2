using System;

namespace Lab2
{
    public class Student
    {
        private string Name;
        private string id;
        private int YearOfBirth;
        private bool isActive;

        public string _Name
        {
            get { return Name; }
            set { Name = value; }
        }
        public string _id
        {
            get { return id; }
            set { id = value; }
        }
        public int _YearOfBirth
        {
            get { return YearOfBirth; }
            set { if (value > 2000 || value < 1950) Console.WriteLine("{0}: error try setting invalid year-of-birth value!", id); else YearOfBirth = value; }
        }
        public bool _isActive
        {
            get { return isActive; }
            set { isActive = value; }
        }

        //constructor
        public Student()
        {
            Name = "John Doe";
            id = "UNKNOW";
            YearOfBirth = 1995;
            isActive = false;
        }

        public Student(string stdnm, string stdid)
        {
            Name = stdnm;
            id = stdid;
            YearOfBirth = 1995;
            isActive = true;
        }

        public Student(string stdnm, string stdid, int stdyob)
        {
            Name = stdnm;
            id = stdid;
            YearOfBirth = stdyob;
            isActive = true;
        }

        public Student(string stdnm, string stdid, int stdyob, bool stdst)
        {
            Name = stdnm;
            id = stdid;
            YearOfBirth = stdyob;
            isActive = stdst;
        }

        public int getAge()
        {
            return 2015 - YearOfBirth;
        }

        public override string ToString()
        {
            return string.Format("[Student: {0} ({1}), age={2}, is {3}", Name, id, getAge(), (isActive) ? " is active student]" : " is NOT active student]");
        }
    }
}