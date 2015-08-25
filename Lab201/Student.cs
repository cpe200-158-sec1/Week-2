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
        private string _studentid;
        private int _year;
        private int _age;
        private bool _isActive;

        public string name
        {
            get
            {
                return _Name;

            }
            set
            {
                _Name = name;

            }
        }
        public string studentid
        {
            get
            {
                return _studentid;

            }
            set
            {
                if (value.Length > 0 || value.Length < 6)
                {
                    throw new OverflowException();
                }
                _studentid = studentid;
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
                if (value >= 1950 || value < 2000)
                {
                    throw new OverflowException();
                }

                _year = year;
            }
        }
        public bool isActive
        {
            get
            {
                _isActive = isActive;
            }
            set
            {
                isActive = value;
            }
        }
        public int getage()
        {
            
          return 2015-year;
            
          
        }
        public Student()
        { 
            _Name=Jonh Doe;
            _age = 20;

        }
        public Student(string name,string studentid)
        {
            _Name = name;
            _studentid = studentid;
        }
        public Student(string name, string studentid,int year)
        {
            _Name = name;
            _studentid = studentid;
            _year = year;
        }
        public Student(string name, string studentid, int year,bool isActive)
        {
            _Name = name;
            _studentid = studentid;
            _year = year;
            isActive = true;
        }
        public override string ToString()
        {
            string s = "[Student:" + name + "(" + studentid + "),age=" + getage + ",";

            if (isActive)
            {
                s += "is active student]";
            }
            else
            {
                s += "NoT active student";];
            }

            return s;
        }
    }

}







