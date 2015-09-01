using Lab202;
using System;

namespace Lab2
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			/* Testing the Course class */
			Course cpe200 = new Course ("Object-Oriented Programming", "261300");
			Course isne103 = new Course ("Programming Language for ISNE", "269103", "DOME");
			Course cpe453 = new Course ("DIP", "261105", "Dr. Kenneth Cosh", 60);

			Console.WriteLine ("\n--- Initial Courses state ---");
			Console.WriteLine (cpe200);
			Console.WriteLine (isne103);
			Console.WriteLine (cpe453);

			/* playing with cpe200 object */
			Console.WriteLine ("\n--- playing with cpe200 object ---");
			cpe200.Courseid = "261200";
			Console.WriteLine (cpe200);
			cpe200.Courseid = "2612OO";
			cpe200.Courseid = "2612002";

			cpe200.NumS = 40;
			Console.WriteLine (cpe200);
			cpe200.MaxS = 60;
			Console.WriteLine (cpe200);
			cpe200.NumS = 40;
			Console.WriteLine (cpe200);
			cpe200.MaxS = 35;
			cpe200.MaxS = 40;
			Console.WriteLine (cpe200);

			/* playing with cpe453 object */
			Console.WriteLine ("\n--- playing with cpe453 object ---");
			cpe453.n = "Digital Image Processing";
			cpe453.Courseid = "261453";
			cpe453.lecturer = "Sansanee";
			cpe453.MaxS = 20;
			Console.WriteLine (cpe453);
            Console.ReadKey();
		}
	}
}
