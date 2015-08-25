using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab201
{
    class Student
    {
        //Name, StudentID, YearOfBirth, isActive
        private string _name;
        private string _id;
        private int _yob;
        private bool _ia;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string ID
        {
            get { return _id; }
            set { _id = value; }
        }
        public int YearOfBirth
        {
            get{ return _yob; }
            set
            {
                //from 1950 to 2000
                if (value >= 1950 && value <= 2000)
                    _yob = value;
                else//57005: error try setting invalid year-of-birth value!
                    Console.WriteLine(""+ID+ ":error try setting invalid year-of-birth value!" );
            }
        }
        public bool isActive
        {
            get { return _ia; }
            set { _ia = value; }
        }
        //Constructor
        public Student()
        {
            //[Student: John Doe (Unknown), age=20, is NOT active student]
            Name = "John Doe";
            ID = "Unknown";
            YearOfBirth = 1995;
            isActive = false;
        }
        public Student(string n, string id)
        {
            Name = n;
            ID = id;
            YearOfBirth = 1995;
            isActive = true;
        }
        public Student(string n, string id, int y)
        {
            Name = n;
            ID = id;
            YearOfBirth = y;
            isActive = true;
        }
        public Student(string n, string id, int y,bool ia)
        {
            Name = n;
            ID = id;
            YearOfBirth = y;
            isActive = ia;
        }
        
        //Methods
        public int getAge()
        {
            return 2015 - YearOfBirth;
        }
        public override string ToString()
        {
            //[Student: John Doe(Unknown), age=20, is NOT active student]
            string s = "[Student: " + Name + " (" + ID + "), age="+getAge()+", is ";
            if(isActive!=true)
            {
                s += "NOT";
            }
            s += " active student]";
            return s;
        }
    }
}
