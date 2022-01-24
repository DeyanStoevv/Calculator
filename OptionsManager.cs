using System;

namespace GitExercise
{
	public static class OptionsManager
	{
		public static string[] OptionsList = {
			"a - Add"," s-Substract"
		};

        public static void Add(double a, double b)
        {
            Console.WriteLine($"{a} + {b} = {a + b}");
        }
		public static void Subtract(double a, double b)
		{
			Console.WriteLine($"{a} - {b} = {a - b}");
		}



	}
}
