using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab201
{
    class Student
    {
		private string _Name;
		private string _StudentId;
		private int _YearOfBirth;
		private bool _IsActive;
		
		public string Name
		{
			get {
					return _Name;
				}
			set {
					_Name = value;
				}
		}

		public string StudentId
		{
			get {
					return _StudentId;
				}
			set {
					_StudentId = value;
				}
		}

		public int YearOfBirth
		{
			get {
					return _YearOfBirth;
				}
			set {
					if (value < 1950 || value >2000)
					{
						Console.WriteLine("{0}: error try setting invalid year-of-birth value!", StudentId);
					}
					else
					{
						_YearOfBirth = value;
					}
				}
		}
		
		public bool IsActive	
		{
			get {
					return _IsActive;
				}
			set {
					_IsActive = value;
				}
		}

		public Student()
		{
			_Name = "John Doe";
			_StudentId = "Unknown";
			_YearOfBirth = 1995;
			_IsActive = false;
		}

		public Student(string NName, string NStudentId)
		{
			_Name = NName;
			_StudentId = NStudentId;
			_YearOfBirth = 1995;
			_IsActive = true;
		}

		public Student(string NName, string NStudentId, int NYearOfBirth)
		{
			_Name = NName;
			_StudentId = NStudentId;
			_YearOfBirth = NYearOfBirth;
			_IsActive = true;
		}

		public Student(string NName, string NStudentId, int NYearOfBirth, bool NIsActve)
		{
			_Name = NName;
			_StudentId = NStudentId;
			_YearOfBirth = NYearOfBirth;
			_IsActive = NIsActve;
		}

		public int getAge()
		{
			return 2015 - YearOfBirth;
		}

		public override string ToString()
		{
			string SIsActive;

			if (_IsActive)
			{
				SIsActive = "is active student";
			}
			else
			{
				SIsActive = "is NOT active student";
			}
			
			return string.Format("[Student: {0} ({1}), age={2}, {3}]", _Name, _StudentId, getAge(),SIsActive);
		}
    }
}
