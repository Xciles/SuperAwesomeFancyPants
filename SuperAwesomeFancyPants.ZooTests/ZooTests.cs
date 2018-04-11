using Microsoft.VisualStudio.TestTools.UnitTesting;
using SuperAwesomeFancyPants.InheritZoo.Business;

namespace SuperAwesomeFancyPants.ZooTests
{
    [TestClass]
    public class ZooTests
    {
        [TestMethod]
        public void CreateAndCheckZoo()
        {
            Zoo zoo = Zoo.Instance();

            Assert.AreEqual(zoo.GetNumberOfAnimals(), 0);

            zoo.FillZoo();
            Assert.AreEqual(zoo.GetNumberOfAnimals(), 5);
        }
    }
}