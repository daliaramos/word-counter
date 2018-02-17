using Microsoft.VisualStudio.TestTools.UnitTesting;
using wordCounter.Models;

namespace wordCounter.Models.Tests
{
  [TestClass]
  public class wordCounterTest
  {
    [TestMethod]
    public void GetTest_ReturnWord()
      {
        wordCounter wc = new wordCounter("hello", "hello my name is");

        Assert.AreEqual("hello", wc.GetWord());

      }

    [TestMethod]
    public void addWord_words()
      {
        wordCounter wc = new wordCounter ("yoyo", "yoyo yoyo yoyo");
        int Repeat = wc.addWord();
        int numTimes = 3;
        Assert.AreEqual(numTimes,Repeat);
      }

  }
}
