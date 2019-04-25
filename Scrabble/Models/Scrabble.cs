using System;
using System.Collections.Generic;

namespace Scrabble.Models
{
  public class Words
  {
    private static Dictionary<char, int> scrabblePoints= new Dictionary<char, int>()
    {
      {'A', 1}, {'B', 3}, {'C', 3}, {'D', 2}, {'E', 1}, {'F', 4}, {'G', 2}, {'H', 4}, {'I', 1}, {'J', 8},
      {'K', 5}, {'L', 1}, {'M', 3}, {'N', 1}, {'O', 1},
      {'P', 3}, {'Q', 10}, {'R', 1}, {'S', 1}, {'T', 1},
      {'U', 1}, {'V', 4}, {'W', 4}, {'X', 8}, {'Y', 4},
      {'Z', 10}
    };

    public int GetPoints(char letter)
    {
      letter = Char.ToUpper(letter);
      return scrabblePoints[letter];
    }

    public char[] CharOfWord(string Word)
    {
      char[] wordArray = Word.ToCharArray();
      return wordArray;
    }

    public int SumTheWord(string word)
    {
      int scrabbleScore = 0;
      char[] wordArray = CharOfWord(word);
      foreach(char letter in wordArray)
      {
        scrabbleScore += GetPoints(letter);
      }
      return scrabbleScore;

    }




  }
}
