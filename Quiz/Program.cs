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

			Console.WriteLine("What is the name of the programming language that is the name of a snake?");
			var python = Console.ReadLine();

			if (python.ToLower() == "python")
			{
				correctAnswers += 1;
			}
			else
			{
				incorrectAnswers += 1;
			}

			Console.WriteLine("What is the name of the programming language that is the name of a gem?");
			var ruby = Console.ReadLine();

			if (ruby.ToLower() == "ruby")
			{
				correctAnswers += 1;
			}
			else
			{
				incorrectAnswers += 1;
			}

			Console.WriteLine("What is the name of the programming language that is the main language used for interactivity on the web?");
			var javascript = Console.ReadLine();

			if (javascript.ToLower() == "javascript")
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