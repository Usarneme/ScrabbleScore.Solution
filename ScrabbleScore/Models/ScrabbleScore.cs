using System.Collections.Generic;
namespace ScrabbleScoreNamespace
{
  public class ScrabbleScore
  {

    // A, E, I, O, U, L, N, R, S, T       1
    // D, G                               2
    // B, C, M, P                         3
    // F, H, V, W, Y                      4
    // K                                  5
    // J, X                               8
    // Q, Z                               10

    private static Dictionary<char, int> _scoreSheet = new Dictionary<char, int>()
    {
      {'a', 1},
      {'b', 0}
    };

    private static int GetLetterScore(char letter)
    {
      int characterScore = _scoreSheet[letter];
      return characterScore;
    }

    public static int GetWordScore(string word)
    {
      int totalScore = 0;

      foreach (char letter in word)
      {
        totalScore += GetLetterScore(letter);
      }

      return totalScore;
    }
  }
}
