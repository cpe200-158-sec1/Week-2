using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Course
    {
        public string Name;
        private string _course_id;
        //6digit
        public string CourseID
        {
            get
            {
                return _course_id;
            }
            set
            {                
                if (value.Length != 6 )
                {
                    Console.WriteLine(_course_id+": error try setting invalid CourseID!");
                }               
                else
                {
                    int num;
                    bool check_num = int.TryParse(value,out num);

                    if (check_num == false)
                    {
                        Console.WriteLine(value + ": error try setting invalid CourseID!");
                    }
                    else
                    {
                        _course_id = value;
                    }
                    
                }

            }
        }

        public string Lecturer;
        private int _MaxStudents;
        //(0-80, and >= NumStudents)
        public int MaxStudents
        {
            get
            {
                return _MaxStudents;
            }
            set
            {
                if ((value > 0 || value < 80) && value >= _NumStudents)
                {
                    _MaxStudents = value;
                }
                else
                {
                    Console.WriteLine(_course_id+": error try setting invalid Max No. Students!");

                }
            }
        }
        //(0-MaxStudents)))
        private int _NumStudents;
        public int NumStudents
        {
            get
            {
                return _NumStudents;
            }
            set
            {
                if (value > MaxStudents || value < 0)
                {
                    Console.WriteLine(_course_id+": error try setting invalid No. Students!");

                }
                else
                {
                    _NumStudents = value;

                }
            }
        }

        public Course()
        {
            this.Name = "John";
            this._course_id = "00000";
            this._NumStudents = 0;
            this._MaxStudents = 30;
            this.Lecturer = "staff";
        }

        public Course(string Name, string course_id)
        {
            this.Name = Name;
            this._course_id = course_id;
            this._NumStudents = 0;

            this._MaxStudents = 30;
            this.Lecturer = "staff";

        }

        public Course(string Name, string course_id, string lecturer)
        {
            this.Name = Name;
            this._course_id = course_id;
            this._MaxStudents = 30;
            this.Lecturer = lecturer;
            this._NumStudents = 0;

        }
         
        public Course(string Name, string course_id, string lecturer, int max_student)
        {
            this.Name = Name;
            this._course_id = course_id;
            this._MaxStudents = max_student;
            this.Lecturer = lecturer;
            this._NumStudents = 0;

        }

        public override string ToString()
        {

            string s = "[Course: " + Name + " (" + _course_id + "), Lacterer=" + Lecturer + ", has "
                + _NumStudents + " students, max=" + _MaxStudents + "]";
            return s;
        }


    }
}
 