using Microsoft.VisualStudio.TestTools.UnitTesting;
using word.Models;

namespace word.Models.Tests
{
  [TestClass]
  public class wordTest
  {
    [TestMethod]
    public void GetTest_ReturnWord()
      {
        wordCounter wc = new wordCounter("hello", "hello my name is");

        Assert.AreEqual("hello", wc.GetWord());

      }

    [TestMethod]
    public void AddWord_words()
      {
        wordCounter wc = new wordCounter ("yoyo", "yoyo yoyo yoyo");
        int Repeat = wc.AddWord();
        int numTimes = 3;
        Assert.AreEqual(numTimes,Repeat);
      }

  }
}
