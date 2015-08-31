using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2



{
    public class Student
    {
        private string _name;
        private string _studentid;
        private int _yearofbirth;
        private bool _isactive;

        public int _YearOfBirth  
      {  
         get { return _yearofbirth; }  
        set
            {
                if (value > 2000 || value < 1950)
                    Console.WriteLine("{0}: error try setting invalid year-of-birth value!", _studentid);
            }  
     }

        public string name
        {
            get { return _name; }
            set { _name = value; }

        }

        public string studentid
        {
            get { return _studentid; }
            set { _studentid = value; }

        }

        public bool isactive
        {
            get { return _isactive; }
            set { _isactive = value; }

        }

        public Student(string name, string studentid, int yearofbirth, bool isactive)
        {
            _name = name;
            _studentid = studentid;
            _yearofbirth = yearofbirth;
            _isactive = isactive;
        }

        public Student(string name, string studentid)
        {
            _name = name;
            _studentid = studentid;
            _yearofbirth = 1995;
            _isactive = true;

        }

        public Student(string name, string studentid, int yearofbirth)
        {
            _name = name;
            _studentid = studentid;
            _yearofbirth = yearofbirth;
            _isactive = true;
        }

        public Student()
        {
            _name = "John Doe";
            _studentid = "Unknow";
            _yearofbirth = 1995;
            _isactive = false;
        }

        public int getAge()
        {
            return 2015 - _yearofbirth;
        }

        public override string ToString()
        {
            return string.Format("[Student: {0} ({1}), age={2},{3}", _name, _studentid, getAge(), (_isactive) ? " is active student]" : " is NOT active student]");
        }
    }


}
