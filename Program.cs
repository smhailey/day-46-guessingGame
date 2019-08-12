using System;

namespace day_46_guessingGame
{
  class Program
  {
    static void Main(string[] args)
    {
      bool quit = false;
      Random rng = new Random();
      int randomNumber = rng.Next(1, 101);
      Console.WriteLine($"random number = { randomNumber}");
      while (!quit)
      {
        Console.WriteLine("Please type a number between 1 and 100 below:");
        string stringGuess = Console.ReadLine();
        Int32.TryParse(stringGuess, out int numGuess);
        Console.WriteLine($"Your guess: { numGuess}");
        if (numGuess == randomNumber)
        {
          Console.WriteLine("You win!");
          quit = true;
        }
        else if (numGuess < randomNumber)
        {
          Console.WriteLine("Your guess was too low. Guess again:");
        }
        else
        {
          Console.WriteLine("Your guess was too high. Guess again:");
        }

      }
    }
  }
}
