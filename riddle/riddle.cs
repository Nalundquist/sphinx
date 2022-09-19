using System;

namespace Sphinx.Riddler
{
	public class Riddle
	{
		public string Answer { get; set; }
    public string Question { get; set; }
		public bool Answered { get; set; }

    public Riddle(string question, string answer)
    { 
      Question = question;
      Answer = answer;
			Answered = false;
    }

    public bool CheckAnswer(string userInput)
    {
      return(userInput == Answer);

    } 
	}
} 