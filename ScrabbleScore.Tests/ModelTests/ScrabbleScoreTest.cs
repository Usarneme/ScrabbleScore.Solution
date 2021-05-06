using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScrabbleScoreNamespace;

namespace ScrabbleScoreTesting
{
  [TestClass]
  public class ScrabbleScoreTests
  {
    [TestMethod]
    public void GetWordScore_A_One()
    {
      // Arrange
      string word = "a";
      int expectedScore = 1;

      // Act
      int returnedScore = ScrabbleScore.GetWordScore(word);

      // Assert
      Assert.AreEqual(expectedScore, returnedScore);
    }

    [TestMethod]
    public void GetWordScore_B_Three()
    {
      string word = "b";
      int expectedScore = 3;
      int returnedScore = ScrabbleScore.GetWordScore(word);
      Assert.AreEqual(expectedScore, returnedScore);
    }
  }
}
