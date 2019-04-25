using System;
using System.Collections.Generic;
using Scrabble.Models;

namespace Scrabble.Models
{
  class Program
  {
    static void Main()
    {
      Words newWords = new Words();
      Console.WriteLine("Welcome to the Scrabble.");
      Console.WriteLine("Please write a word to see its score: ");
      string userInput = Console.ReadLine();
      int userScore = newWords.SumTheWord(userInput);
      Console.WriteLine(userScore);
    }
  }

}
