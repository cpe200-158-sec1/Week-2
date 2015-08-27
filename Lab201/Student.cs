using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Student
    {

        private string _Name;
        private string _studentid;
        private int _year;
        private bool _isActive=false;

        public string name
        {
            get{return _Name; }
            set{_Name = value;}
        }
        public string studentid
        {
            get{ return _studentid;}
            set{
                if (value.Length > 0 || value.Length < 6)
                {
                    _studentid = studentid;
                }
                else
                    _studentid = value;
            }
        }
        public int year
        {
            get
            {
                return _year;

            }
            set
            {
                if (value < 1950 || value > 2000)
                {
                    Console.WriteLine("{0}: error try setting invalid year-of-birth value!");
                }

                
                    _year = value;
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
        public int getage()
        {

            return 2015 -_year;


        }
        public Student()
        {
            _Name = "Jonh Doe";
            _studentid = "(Unknown)";
            _year = 1995;
            _isActive = false;
        }
        public Student(string name, string studentid)
        {
            _Name = name;
            _studentid = studentid;
            _year = 1995;
            _isActive = true;
        }
        public Student(string name, string studentid, int year)
        {
            _Name = name;
            _studentid = studentid;
            _year = year;
            _isActive = true;
        }
        public Student(string name, string studentid, int year, bool isActive)
        {
            _Name = name;
            _studentid = studentid;
            _year = year;
            _isActive = true;
        }
        public override string ToString()
        {
            string s = "[Student:" + name + "(" + studentid + "),age=" + getage() + ",";

            if (_isActive)
            {
                s += "is active student]";
            }
            else
            {
                s += "is NoT active student]";
            }

            return s;
        }
    }

}







