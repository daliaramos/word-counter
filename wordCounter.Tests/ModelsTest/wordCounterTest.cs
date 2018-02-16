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
      wordCounter wordCounter = new wordCounter("hello");
      Assert.AreEqual("hello", wordCounter.GetWords());
    }

    // [TestMethod]
    // public void GetCount_ReturnsNumOfWords()
    // {
    //   wordCounter wordCounter = new wordCounter("hello hello");
    //   Assert.AreEqual(2, wordCounter.GetCount());
    // }
  }
}
