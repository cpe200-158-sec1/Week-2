using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab201
{
    class Student
    {
        private string student;
        private string _name;
        private int _studentID;
        private int _age;
        private int _yob;
        
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

        public int StudentID 
        {
            get
            {
                return _studentID;
            }
            set
            {
                _studentID = value;
            }
        }

        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (1 < age || age > 100)
                {

                }
                _age = value;
            }
        }

        public string Student
        {
            get
            {
                _name = "John Doe";
                _studentID = "(Unknown)";
                _age = "20";          
            }
        }

        public string YOB
        {
            get
            {
                return _yob;
            }
            set
            {
                if (2001 < yob || yob > 1949)
                {

                }
                _age = value;




            }
















    }




}
