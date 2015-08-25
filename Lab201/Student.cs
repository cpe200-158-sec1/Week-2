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
        private string _studentid;
        private long _yearofbrith;
        private bool _isactive;

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
                return _studentid;
            }
            set
            {
                _studentid = value;
            }
        }
        public long YearOfBirth
        {
            get
            {
                return _yearofbrith;
            }
            set
            {
                if (value < 1950 || value > 2000)
                {
                    Console.WriteLine("57005: error try setting invalid year - of - birth value!");
                }
                else
                {
                    _yearofbrith = value;
                }
            }
        }
        public bool isActive
        {
            get
            {
                return _isactive;
            }
            set
            {
                _isactive = value;
            }
        }
        
     public Student()
        {
            _name = "John Doe";
            _studentid = "UnKnow";
            _yearofbrith = 1995;
            _isactive = true;
        }

     public Student(string name_in,string id_in)
        {
            _name = name_in;
            _studentid = id_in;
            _yearofbrith = 1995;
            _isactive = true;
        }

     public Student(string name_in, string id_in, long year_in)
        {
            _name = name_in;
            _studentid = id_in;
            _yearofbrith = year_in;
            _isactive = true;
        }

    public Student(string name_in, string id_in, long year_in, bool act_in)
        {
            _name = name_in;
            _studentid = id_in;
            _yearofbrith = year_in;
            _isactive = act_in;
        }
    public long getAge()
        {
            return 2015 - _yearofbrith;
        }
    public override string ToString()
        {
            string s;
            if (isActive)
            {
                s = "is active student";
            }
            else
            {
                s = "is NOT active student";
            }
            return string.Format("[Student: {0} ({1}), age={2}, {3}] ", _name, _studentid, getAge(), s);
        }

    }
}