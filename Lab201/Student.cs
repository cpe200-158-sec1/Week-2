using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Student
    {

        int _YearOfBirth;
        public string Name
        {
            get;
            set;
        }
        public string StudentID
        {
            get;
            set;
        }
        public int YearOfBirth
        {
            get
            {
                return _YearOfBirth;
            }
            set
            {
                if (value >= 1950 && value <= 2000)
                {
                    _YearOfBirth = value;
                }
                else
                {
                    Console.WriteLine(StudentID + ": error try setting invalid year-of-birth value!");
                }
            }
        }
        public bool isActive;

        public Student()
        {
            this.Name = "John Doe";
            this.StudentID = "Unknown";
            this.YearOfBirth = 1995;
            this.isActive = true;
        }

        public Student(string Name, string StudentID)
        {
            this.Name = Name;
            this.StudentID = StudentID;
            this.YearOfBirth = 1995;
            this.isActive = true;
        }

        public Student(string Name, string StudentID, int YearOfBirth)
        {
            this.Name = Name;
            this.StudentID = StudentID;
            this.YearOfBirth = YearOfBirth;
            this.isActive = true;
        }


        public Student(string Name, string StudentID, int YearOfBirth, bool isActive)
        {
            this.Name = Name;
            this.StudentID = StudentID;
            this.YearOfBirth = YearOfBirth;
            this.isActive = isActive;
        }

        private int getAge()
        {
            int age = 2015 - YearOfBirth;
            return age;
        }

        public override string ToString()
        {
            string text = "";
            text += "[Student: " + Name + " (" + StudentID + "),age= " + getAge() + ",is";
            if (isActive == false)
            {
                text += " Not ";
            }
            text += "Active student]";
            return text;
        }

        
    }



}
