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

    [TestMethod]
    public void GetWordScore_The_Six()
    {
      // Arrange
      string word = "the";
      int expectedScore = 6;

      // Act
      int returnedScore = ScrabbleScore.GetWordScore(word);

      // Assert
      Assert.AreEqual(expectedScore, returnedScore);
    }

    [TestMethod]
    public void GetWordScore_Quick_Twenty()
    {
      // Arrange
      string word = "quick";
      int expectedScore = 20;

      // Act
      int returnedScore = ScrabbleScore.GetWordScore(word);

      // Assert
      Assert.AreEqual(expectedScore, returnedScore);
    }

    [TestMethod]
    public void GetWordScore_Brown_Ten()
    {
      // Arrange
      string word = "brown";
      int expectedScore = 10;

      // Act
      int returnedScore = ScrabbleScore.GetWordScore(word);

      // Assert
      Assert.AreEqual(expectedScore, returnedScore);
    }

    [TestMethod]
    public void GetWordScore_Fox_Thirteen()
    {
      // Arrange
      string word = "fox";
      int expectedScore = 13;

      // Act
      int returnedScore = ScrabbleScore.GetWordScore(word);

      // Assert
      Assert.AreEqual(expectedScore, returnedScore);
    }

    [TestMethod]
    public void GetWordScore_Jumps_Sixteen()
    {
      // Arrange
      string word = "jumps";
      int expectedScore = 16;

      // Act
      int returnedScore = ScrabbleScore.GetWordScore(word);

      // Assert
      Assert.AreEqual(expectedScore, returnedScore);
    }

    [TestMethod]
    public void GetWordScore_Over_Seven()
    {
      // Arrange
      string word = "over";
      int expectedScore = 7;

      // Act
      int returnedScore = ScrabbleScore.GetWordScore(word);

      // Assert
      Assert.AreEqual(expectedScore, returnedScore);
    }

    [TestMethod]
    public void GetWordScore_Lazy_Sixteen()
    {
      // Arrange
      string word = "lazy";
      int expectedScore = 16;

      // Act
      int returnedScore = ScrabbleScore.GetWordScore(word);

      // Assert
      Assert.AreEqual(expectedScore, returnedScore);
    }

    [TestMethod]
    public void GetWordScore_Dog_Five()
    {
      // Arrange
      string word = "dog";
      int expectedScore = 5;

      // Act
      int returnedScore = ScrabbleScore.GetWordScore(word);

      // Assert
      Assert.AreEqual(expectedScore, returnedScore);
    }
  }
}
