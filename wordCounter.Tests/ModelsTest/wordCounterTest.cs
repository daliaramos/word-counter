using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project.Models;

namespace wordCounter.Models.Tests
{
  [TestClass]
  public class wordCounterTest
  {
    [TestMethod]
    public void Test_JustATest_True()
    {
      Assert.AreEqual(true, ProjectModel.Test(true));
      Assert.AreEqual(false, ProjectModel.Test(false));
    }
  }
}
