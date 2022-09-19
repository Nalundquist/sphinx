using System;
using System.Collections.Generic;
using Sphinx.Riddler;

namespace Sphinx
{
	public class Program
	{
		public static void Main () {
			Riddle screenRiddle = new Riddle("10,000 flames under a gossamer veil, enthralls all who see it and remarkably frail", "screen");
			Riddle cRiddle = new Riddle ("Do you even lift?  A forgotten wink sets it adrift; however, if impeccable, is ready in a jiff.", "c#");
			Riddle shadowRiddle = new Riddle ("There is a thing that nothing is, yet it has a name. It's sometimes tall and sometimes short, joins our talk, joins our sport, and plays at every game", "shadow");
			Riddle riverRiddle = new Riddle ("What can run but never walk, has a mouth but never talks, has a bed but never sleeps, has a head but never weeps?", "river");
			Riddle windRiddle = new Riddle ("Voiceless it cries, wingless flutters, toothless bites, mouthless mutters.", "wind");
			Riddle fallenRiddle = new Riddle ("Walk on the living, they don't even mumble.  Walk on the dead, they mutter and grumble.", "fallen leaves");
			Riddle timeRiddle = new Riddle ("This thing all things devours; birds, beasts trees, flowers; gnaws iron, bites steel; grinds hard stones to meal; slays king, ruins town; and beats the mountain down.", "time");
			Riddle clockRiddle = new Riddle ("This thing runs but cannot walk, sometimes sings but never talks.  Lacks arms, has hands; lacks a head but has a face.", "clock");

			List<Riddle> Riddles = new List<Riddle> { screenRiddle, cRiddle, shadowRiddle, riverRiddle, windRiddle, fallenRiddle, timeRiddle, clockRiddle };

	
			Random rand = new Random();
			while (Riddles.Count > 0) {
				int ranIndex = rand.Next(Riddles.Count);
				Console.WriteLine("Your life is at stake. Riddle me this or perish!");
				Riddle randRiddle = Riddles[ranIndex];
				Console.WriteLine(randRiddle.Question);
				string userInput = Console.ReadLine();
				if (randRiddle.CheckAnswer(userInput))
				{	 
					Riddles.Remove(Riddles[ranIndex]);
					Console.WriteLine("You answered correctly. You are safe... for now.");
					Console.WriteLine("Your next riddle is");
				}
				else
				{
					Console.WriteLine("You are INCORRECT! Your soul shall be ruthlessly devoured by ravashed ravens for all of E T E R N I T Y.");
				}
			}
		}
	}
}