﻿using System;
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
        private int _yearofbirth;
        private bool _isactive;
        public override string ToString()
        {
            string s = "[Student: " + Name + " (" + StudentID + "), age=" + getAge() + ", ";
            if (isActive)
            {
                s += "is active student]";
            }
            else
            {
                s += "is NOT active student]";
            }
            return s;
        }
        public Student()
        {
            Name = "John Doe";
            StudentID = "Unknown";
            YearOfBirth = 1995;
            isActive = false;
        }
        public Student(string pName, string pStudentID)
        {
            Name = pName;
            StudentID = pStudentID;
            YearOfBirth = 1995;
            isActive = true;
        }
        public Student(string pName, string pStudentID, int pYearOfBirth)
        {
            Name = pName;
            StudentID = pStudentID;
            YearOfBirth = pYearOfBirth;
            isActive = true;
        }
        public Student(string pName, string pStudentID, int pYearOfBirth, bool pisActive)
        {
            Name = pName;
            StudentID = pStudentID;
            YearOfBirth = pYearOfBirth;
            isActive = pisActive;
        }
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
                if (value.Length != 5 && value != "Unknown")
                {
                    throw new OverflowException();
                }
                else
                {
                    _studentid = value;
                }
            }
        }
        public int YearOfBirth
        {
            get
            {
                return _yearofbirth;
            }
            set
            {
                if (value < 1950 || value > 2000)
                {
                    Console.WriteLine(StudentID + ": error try setting invalid year-of-birth value!");
                }
                else
                {
                    _yearofbirth = value;
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
        public int getAge()
        {
            return 2015 - YearOfBirth;
        }
    }
}
