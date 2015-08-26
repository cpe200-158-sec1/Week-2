using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab202
{
    class Course
    {
		private string _Name;
		private string _CourseId;
		private string _Lecturer;
		private int _MaxStudents;
		private int _NumStudents;

		public string Name
        {
            get {
					return _Name;
				}
            set {
					_Name = value;
				}
        }

		public string CourseId
		{
			get {
					return _CourseId;
				}
			set {
					int i = 0;
					while (i < value.Length)
					{
						if (value[i] < '0' || value[i] > '9')
						{
							Console.WriteLine("{0}: error try setting invalid CourseID!",this.CourseId);
							break;
						}
						i++;
					}

					if( value.Length != 6)
					{
						Console.WriteLine("{0}: error try setting invalid CourseID!", this.CourseId);
					}
					else
					{
						_CourseId = value;
					}
				}
		}

		public string Lecturer
		{
			get {
					return _Lecturer;
				}
			set {
					_Lecturer = value;
				}
        }

		public int MaxStudents
		{
			get {
					return _MaxStudents;
				}
			set {
					if (value < 0 || value > 80 || value < this.NumStudents)
					{
						Console.WriteLine("{0}: error try setting invalid Max No. Students!", this.CourseId);
					}
					else
					{
						_MaxStudents = value;
					}
				}
		}

		public int NumStudents
		{
			get {
					return _NumStudents;
				}
			set {
					if (value < 0 || value > this.MaxStudents)
					{
						Console.WriteLine("{0}: error try setting invalid No. Students!", this.CourseId);
					}
					else
					{
						_NumStudents = value;
					}
				}
		}

		public Course()
		{
			_Name = "";
			_CourseId = "";
			_Lecturer = "Staff";
			_MaxStudents = 30;
			_NumStudents = 0;
		}

		public Course(string NName, string NCourseId)
		{
			_Name = NName;
			_CourseId = NCourseId;
			_Lecturer = "Staff";
			_MaxStudents = 30;
			_NumStudents = 0;
		}

		public Course(string NName, string NCourseId, string NLecturer)
		{
			_Name = NName;
			_CourseId = NCourseId;
			_Lecturer = NLecturer;
			_MaxStudents = 30;
			_NumStudents = 0;
		}

		public Course(string NName, string NCourseId, string NLecturer, int NMaxStudents)
		{
			_Name = NName;
			_CourseId = NCourseId;
			_Lecturer = NLecturer;
			_MaxStudents = NMaxStudents;
			_NumStudents = 0;
		}

		public override string ToString()
		{
			return string.Format("[Course: {0} ({1}), Lecturer={2}, Has {3} Students, Max={4}]", _Name, _CourseId, _Lecturer, _NumStudents, _MaxStudents);
		}
    }
}
