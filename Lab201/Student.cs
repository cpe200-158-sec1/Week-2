using System;
using Lab201;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab201
{
    class Student
    {
        private string _Name;
        private string _StdId;
        private int _YOD;
        private bool _isActive;


        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        public string StdId
        {
            get { return _StdId; }
            set { _StdId = value; }
        }

        public int YearOfBirth
        {
            get { return _YOD; }
            set
            {
                if (value < 1950 || value > 2000)
                {
                    Console.WriteLine("{0} error please try setting new valid year of birth!", this.StdId);
                }
                else
                {
                    _YOD = value;
                }

            }
        }

        public bool isActive
        {
            get { return _isActive; }
            set { _isActive = value; }
        }

        //public string StisActive
        //{

        //    get { return StisActive; }

        //    set
        //    {
        //        if (isActive == false)
        //        {
        //            StisActive = "is NOT active";
        //        }
        //        else
        //            StisActive = "is active";
        //    }
        //}

        public int getAge()
        {
            return 2015 - YearOfBirth;
        }

        public Student()
        {
            _Name = "John Doe (Unknow)";
            _StdId = "57000";
            _YOD = 1995;
            _isActive = false;

        }

        public Student(string inName, string inStdId)
        {
            _Name = inName;
            _StdId = inStdId;
            _YOD = 1995;
            _isActive = true;
        }

        public Student(string inName, string inStdId, int inYOD)
        {
            _Name = inName;
            _StdId = inStdId;
            _YOD = inYOD;
            _isActive = true;
        }

        public Student(string inName, string inStdId, int inYOD, bool inisActive)
        {
            _Name = inName;
            _StdId = inStdId;
            _YOD = inYOD;
            _isActive = inisActive;
        }

        public override string ToString()
        {
            string act;
            if (_isActive)
            {
                act = "is active student";
            }
            else
            {
                act = "is NOT active student";
            }
            return string.Format("[Student:{0} ({1}), age={2}, {3}]", _Name, _StdId, getAge(), act);

        }

    }


}
