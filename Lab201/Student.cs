namespace Lab2
{
    class Student
    {

        public string Name, StudentID;
        public int YearOfBirth; // YearOfBirth(from 1950 to 2000)
        public bool isActive;

        //1
        public Student()
        {
            Name = "John Doe";
            StudentID = "Unknow";
            YearOfBirth = 1950;
            isActive = false;
        }
        // Student(Name, StudentID) : takes 2 parameters
        public Student(string Name, string StudentID)
        {
            this.Name = Name;
            this.StudentID = StudentID;
            YearOfBirth = 1950;
            isActive = true;
        }
        // Student(Name, StudentID, YearOfBirth): takes 3 parameters
        public Student(string Name, string StudentID, int YearOfBirth)
        {
            this.Name = Name;
            this.StudentID = StudentID;
            this.YearOfBirth = checkyearofbirth_input(YearOfBirth) ;
            isActive = true;
        }
        // Student(Name, StudentID, YearOfBirth, isActive): takes 4 parameters
        public Student(string Name, string StudentID, int YearOfBirth, bool isActive)
        {
            this.Name = Name;
            this.StudentID = StudentID;
            this.YearOfBirth = checkyearofbirth_input(YearOfBirth);
            this.isActive = isActive;
        }

        //getAge(): calculate current age of student
        public int getAge()
        {
            int age;

            age = 2015 - YearOfBirth;

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

        private int checkyearofbirth_input(int yearofbirth)
        {
            if(yearofbirth <= 1950 || yearofbirth >= 2000)
            { }
            else { yearofbirth = 1950; }
            return yearofbirth;
        }

    }
}
