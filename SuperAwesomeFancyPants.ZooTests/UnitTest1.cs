using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SuperAwesomeFancyPants.ZooTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int x = 1, y = 2;

            Assert.IsFalse(x == y);
        }
    }
}
