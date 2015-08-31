using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{

    public class Course
    {
        private string _CourseID;
        private int _NumStudents;
        private int _MaxStudents;
        private string _Name;
        private string _Lecturer;


        public string CourseID
        {
            get { return _CourseID; }
            set {


                bool check = true;

                if (value.Length != 6)
                    check = false;

                //Console.WriteLine("Length= {0} for {1}",value.Length,value);

                foreach (char c in value)
                {
                  if (char.IsUpper(c) || char.IsLower(c))
                        check = false;
                  }

                //Console.WriteLine("check= {0} for {1}", check,value);
                if (check != true)
                    Console.WriteLine("{0}: error try setting invalid CourseID!", _CourseID);
                else _CourseID = value;
                 }

        }

        public int NumStudents
        {

            get { return _NumStudents; }
            set
            {


                if (value < 0 || value > _MaxStudents)
                    Console.WriteLine("{0}: error try setting invalid No. Students!", _CourseID);
                else _NumStudents = value;
            }
        }

        public int MaxStudents
        {
            get { return _MaxStudents; }
            set
            {


                if ((value < 0 || value > 80)||(value < _NumStudents))
                    Console.WriteLine("{0}: error try setting invalid Max no. Students!", _CourseID);
                else _MaxStudents = value;
            }
        }

        public string Name
        {
            get { return _Name; }
            set { _Name = value;  }
        }

        public string Lecturer
        {
            get { return _Lecturer; }
            set { _Lecturer = value; }
        }

        //constuctor

        public Course(string name,string id,string lec,int max)
        {
            _CourseID = id;
            _Lecturer = lec;
            _Name = name;
            _MaxStudents = max;
        }

        public Course(string name, string id, string lec )
        {
            _CourseID = id;
            _Lecturer = lec;
            _Name = name;
            _MaxStudents = 30;
        }

        public Course(string name, string id)
        {
            _CourseID = id;
            _Lecturer = "staff";
            _Name = name;
            _MaxStudents = 30;
        }

        public Course()
        {
            _CourseID = "Unknow";
            _Lecturer = "staff";
            _Name = "Unknow";
            _MaxStudents = 30;
        }

        public override string ToString()
        {
            return string.Format("[Course: {0} ({1}), Lecturer={2}, has {3} students, max={4}]", _Name, _CourseID, _Lecturer, _NumStudents, _MaxStudents);
        }



    }
}
