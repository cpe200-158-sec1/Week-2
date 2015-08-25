using System;

namespace Lab2
{
    class Student
    {
  

      
        public int _yearofbirth; // Yepublic bool isActive;

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

        public bool isActive
        {
            get;
            set;

        }
        

        public int YearOfBirth
        {
            get
            {
                return _yearofbirth;
            }
            set
            {
                if(value < 1950 || value > 2000)
                {
                    Console.WriteLine(this.StudentID+ ": error try setting invalid year-of-birth value!");
                }
                else
                {
                    _yearofbirth = value;
                }
            }

        }


        //1
        public Student()
        {
            Name = "John Doe";
            StudentID = "Unknow";
            this._yearofbirth = 1995;
            isActive = false;
        }
        // Student(Name, StudentID) : takes 2 parameters
        public Student(string Name, string StudentID)
        {
            this.Name = Name;
            this.StudentID = StudentID;
            this._yearofbirth = 1995;
            isActive = true;
        }
        // Student(Name, StudentID, YearOfBirth): takes 3 parameters
        public Student(string Name, string StudentID, int YearOfBirth)
        {
            this.Name = Name;
            this.StudentID = StudentID;
            this.YearOfBirth = YearOfBirth;
            isActive = true;
        }
        // Student(Name, StudentID, YearOfBirth, isActive): takes 4 parameters
        public Student(string Name, string StudentID, int YearOfBirth, bool isActive)
        {
            this.Name = Name;
            this.StudentID = StudentID;
            this.YearOfBirth = YearOfBirth;
            this.isActive = isActive;
        }

        //getAge(): calculate current age of student
        public int getAge()
        {
            int age;

            age = 2015 - _yearofbirth;

            return age;
        }

        public override string ToString()
        {
            //[Student: s1 (57001), age=20, is active student]
            string output = "";
            output += "[Student: " + Name + " (" + StudentID + "), age=" + getAge() + ", is ";
            if (!isActive)
            {
                output += "NOT ";
            }
            output += "active student]";

            return output;
        }
        // ToString(): display object state in specify format(see expected output)



    }
}
