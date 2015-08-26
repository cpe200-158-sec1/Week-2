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
        private string _studentId;
        private int _yearOfBirth;
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
        public string StudentId
        {
            get
            {
                return _studentId;
            }
            set
            {
                _studentId = value;
            }
        }
        public int YearOfBirth
        {
            get
            {
                return _yearOfBirth;
            }
            set
            {
                if (value < 1950 || value > 2000)
                {
                    Console.WriteLine("{0} : error try setting invalid year - of -birth value!", StudentId);
                }
                else
                {
                    _yearOfBirth = value;
                }
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

        //////////////////////////////////////////////

        public Student()
        {
            _name = "John Doe";
            _studentId = "UnKnow";
            _yearOfBirth = 1995;
            _isActive = false;
        }

        public Student(string name,string id)
        {
            _name = name;
            _studentId = id;
            _yearOfBirth = 1995;
            _isActive = true;
        }

        public Student(string name,string id,int birthYear)
        {
            _name = name;
            _studentId = id;
            _yearOfBirth = birthYear;
            _isActive = true;
        }
    
        public Student(string name,string id,int birthYear,bool active)
        {
            _name = name;
            _studentId = id;
            _yearOfBirth = birthYear;
            _isActive = active;
        }
        
        public long getAge()
        {
            return 2015 - _yearOfBirth;
        }

        public override string ToString()
        {
            string cout;
            if (isActive)
            {
                cout = "is active student";
            }
            else
            {
                cout = "is Not active student";
            }
            return string.Format("[Student : {0}({1}),age={2},{3}]", Name, StudentId, getAge(), cout);
        }
    }
}
