using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Course
    {


        //Name, CourseID, Lecturer, MaxStudents, NumStudents

        private string _Name;
        private string _CourseID;
        private string _Lecturer;
        private int _MaxStudents;
        private int _NumStudents;

       // Validation: CourseID(6-digit number only), 
         //       NumStudents(0-MaxStudents)
           //     MaxStudents(0-80, and >= NumStudents)

        public string Name
        {
            get{ return _Name; }
            set{ _Name = value; }
        }
        public string Lecturer
        {
            get { return _Lecturer; }
            set { _Lecturer = value; }
        }

        public string CourseID
        {
            get { return _CourseID; }
            set {
                       
              

                             int n;
                             bool isNumeric = int.TryParse(value, out n);
                            if (value.Length != 6)
                            {
                                Console.WriteLine("261200: error try setting invalid CourseID!");
                            }
                             
                             else if (!isNumeric)
                            {
                                Console.WriteLine("261200: error try setting invalid CourseID!");
                            }
                            else
                            {
                                _CourseID = value;
                            }

                }
        }

        public int NumStudents
        {
            get { return _NumStudents; }
            set {
                
                if(value >= 0 && value <= _MaxStudents)
                {
                    _NumStudents = value;
                }
                else
                {
                    Console.WriteLine("261200: error try setting invalid  No. Students!");
                }

               
            }
        }

        public int MaxStudents
        {
            get { return _MaxStudents; }
            set
            {

                if ((value >= 0 && value <= 80) && value >= _NumStudents)
                {
                    _MaxStudents = value;
                }
                else
                {
                    Console.WriteLine("261200: error try setting invalid Max No. Students!");
                }


            }
        }

        //Course() : set default state
        //Course(Name, CourseID): takes 2 parameters
        //Course(Name, CourseID, Lecturer): takes 3 parameters
        //Course(Name, CourseID, Lecturer, MaxStudents): takes 4 parameters      
        public Course()
        {
            this._Name = "Unknow";
            this._CourseID = "000000";
            this._Lecturer = "staff";
            this._MaxStudents = 30;
            this._NumStudents =0;
        }

        public Course(string Name,string CourseID)
        {
            this._Name = Name;
            this._CourseID = CourseID;
            this._Lecturer = "staff";
            this._MaxStudents = 30;
            this._NumStudents = 0;
        }

        public Course(string Name, string CourseID,string Lecturer)
        {
            this._Name = Name;
            this._CourseID = CourseID;
            this._Lecturer = Lecturer;
            this._MaxStudents = 30;
            this._NumStudents = 0;
        }

        public Course(string Name, string CourseID, string Lecturer,int MaxStudents)
        {
            this._Name = Name;
            this._CourseID = CourseID;
            this._Lecturer = Lecturer;
            this._MaxStudents = MaxStudents;
            this._NumStudents = 0;
        }


        public override string ToString()
        {
            //[Course: Object-Oriented Programming (261300), Lecturer=staff, has 0 students, max=30]
            string output = "";
            output += "[Course: " + _Name + "(" + _CourseID + "), Lecturer=" + _Lecturer + ", has " + _NumStudents + " students, max=" + _MaxStudents + "]";


            return output;
        }



    }
}
