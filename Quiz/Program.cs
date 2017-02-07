using System;

namespace Quiz
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			// ask three multiple-choice or true/false questions
			var correctAnswers = 0;
			var incorrectAnswers = 0;

			Console.WriteLine("What is my First Name?");
			var aaron = Console.ReadLine();

			if (aaron.ToLower() == "aaron")
			{
				correctAnswers += 1;
			}
			else
			{
				incorrectAnswers += 1;
			}

			Console.WriteLine("What is my Middle Name?");
			var matthew = Console.ReadLine();

			if (matthew.ToLower() == "matthew")
			{
				correctAnswers += 1;
			}
			else
			{
				incorrectAnswers += 1;
			}

			Console.WriteLine("What is my Last Name?");
			var harpt = Console.ReadLine();

			if (harpt.ToLower() == "harpt")
			{
				correctAnswers += 1;
			}
			else
			{
				incorrectAnswers += 1;
			}
			Console.WriteLine("You got " + correctAnswers + " right answer(s) and " + incorrectAnswers + " wrong answer(s).");
		}
	}
}