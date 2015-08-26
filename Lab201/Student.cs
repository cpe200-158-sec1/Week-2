using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Student
    {
        public string Name;
        private string student_id;

        private int _year_birth;
        public int year_birth
        {
            get
            {

                return _year_birth;
            }
            set
            {
                if (value <= 1950 || value >= 2000)
                {
                    Console.WriteLine(this.student_id + ": error try setting invalid year-of-birth value");


                }
                else
                {
                    _year_birth = value;
                }



            }
        }

        public bool isActive;
        private int age;




        public Student()
        {
            Name = "John Doe ";
            student_id = "unknown";
            _year_birth = 1995;
            isActive = false;
        }

        public Student(string name, string student_id)
        {
            this.Name = name;
            this.student_id = student_id;
            this.isActive = true;
            _year_birth = 1995;

        }

        public Student(string name, string student_id, int year_birth)
        {
            this.Name = name;
            this.student_id = student_id;
            this._year_birth = year_birth;
            this.isActive = true;
        }

        public Student(string name, string student_id, int year_birth, bool isActive)
        {
            this.Name = name;
            this.student_id = student_id;
            this._year_birth = year_birth;
            this.isActive = true;
        }

        public int getAge()
        {
            age = 2015 - this._year_birth;
            return age;
        }


        public override string ToString()
        {

            string s = "[Student: " + Name + " (" + student_id + "), age=" + getAge() + ", ";
            if (isActive == true)
            {
                s += " is active student]";
            }
            else if (isActive == false)
            {
                s += "is NOT active student]";

            }
            return s;
        }



    }

}

