using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab201
{
    class Student
    {
        private string Name;
        private string StudentID;
        private int YearofBirth;
        private bool isActive;
  
        public string _Name
        {
            get { return _Name; }
            set { Name = value; }             
        }
        public bool _isActive
        {
            get {return _isActive; }
            set { isActive = value; }
        } 
        public int _YearofBirth
        {
            get { return _YearofBirth; }       
            set
            {
                if (value < 1950 || value > 2000)
                {
                    Console.WriteLine(StudentID + " : error try setting invalid year-of-birth value!");
                }
                else
                {
                    YearofBirth = value;
                }             
            }
        }
        //default constuctor
        public Student()
        {
            this.isActive = false;
            this.Name = "John Doe";
            this.YearofBirth = 1995;
            this.StudentID = "unknow";
        }

        public Student(string n,string sid)
        {
            this.Name = n;
            this.StudentID = sid;
            this.YearofBirth = 1995;
            this.isActive = true;
        }
        public Student(string n,string sid,int y)
        {
            this.Name = n;
            this.StudentID = sid;
            this.setyear(y);
            this.isActive = true;
        }
        public Student(string n, string sid, int y,bool active)
        {
            this.Name = n;
            this.StudentID = sid;
            this.setyear(y);
            this.isActive = active;
        }
        public void setyear(int year)
        {
            if(year>=1950&&year<=2000)
            {
                this.YearofBirth = year;
            }
            else
            {
                Console.WriteLine(StudentID + " : error try setting invalid year-of-birth value!");
            }
        }
        public int getAge()
        {  
                return 2015 - YearofBirth;                       
        }
        public override string ToString()
        {
            string active=" ";
            if(isActive==false)
            {
                active = "NOT";
            }
            string output = ("[Student: " + Name + "(" + StudentID + ")" + ", age=" + getAge()+ ", is " +active+ " active student");
            return output;
        }
    }
}
